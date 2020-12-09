using Mersy.Common.Entities;
using Mersy.Common.Models;
using Mersy.Common.Request;
using Mersy.Common.Responses;
using Mersy.Infraestructure;
using Mersy.Web.Helpers;
using Mersy.Web.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using EmailRequest = Mersy.Common.Request.EmailRequest;

namespace Mersy.Web.Controllers.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IUserHelper _userHelper;
        private readonly IConfiguration _configuration;
        private readonly IBlobHelper _blobHelper;
        private readonly IMailHelper _mailHelper;
        private readonly ApplicationDbContext _context;

        public AccountController(
            IUserHelper userHelper,
            IConfiguration configuration,
            IBlobHelper blobHelper,
            IMailHelper mailHelper,
            ApplicationDbContext context)
        {
            _userHelper = userHelper;
            _configuration = configuration;
            _blobHelper = blobHelper;
            _mailHelper = mailHelper;
            _context = context;
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost]
        public async Task<IActionResult> GetUser()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            string email = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var user = await _userHelper.GetUserByEmailAsync(email);
            if (user == null)
            {
                return NotFound("Error001");
            }

            return Ok(user);
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _context.Users
                .ToListAsync();
            return Ok(users);
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> PostUser([FromBody] UserRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new Response
                {
                    IsSuccess = false,
                    Message = "Bad request",
                    Result = ModelState
                });
            }

            var user = await _userHelper.GetUserByEmailAsync(request.Email);
            if (user != null)
            {
                return BadRequest(new Response
                {
                    IsSuccess = false,
                    Message = "Error003"
                });
            }

            //City city = await _context.Cities.FindAsync(request.CityId);
            //if (city == null)
            //{
            //    return BadRequest(new Response
            //    {
            //        IsSuccess = false,
            //        Message = "Error004"
            //    });
            //}

            Guid imageId = Guid.Empty;

            if (request.ImageArray != null)
            {
                imageId = await _blobHelper.UploadBlobAsync(request.ImageArray, "users");
            }

            user = new ApplicationUser
            {
                Address = request.Address,
                Email = request.Email,
                //  Name = request.Name,
                PhoneNumber = request.Phone,
                UserName = request.Email,
                // ImageId = imageId,
                // UserType = UserType.User,
                // Latitude = request.Latitude,
                //  Logitude = request.Logitude
            };

            IdentityResult result = await _userHelper.AddUserAsync(user, request.Password);
            if (result != IdentityResult.Success)
            {
                return BadRequest(result.Errors.FirstOrDefault().Description);
            }

            var userNew = await _userHelper.GetUserByEmailAsync(request.Email);
            //  await _userHelper.AddUserToRoleAsync(userNew, user.UserType.ToString());

            string myToken = await _userHelper.GenerateEmailConfirmationTokenAsync(user);
            string tokenLink = Url.Action("ConfirmEmail", "Account", new
            {
                userid = user.Id,
                token = myToken
            }, protocol: HttpContext.Request.Scheme);

            _mailHelper.SendMail(request.Email, "Email Confirmation", $"<h1>Email Confirmation</h1>" +
                $"To confirm your email please click on the link<p><a href = \"{tokenLink}\">Confirm Email</a></p>");

            return Ok(new Response { IsSuccess = true });
        }


        [HttpPost]
        [Route("RecoverPassword")]
        public async Task<IActionResult> RecoverPassword([FromBody] EmailRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new Response
                {
                    IsSuccess = false,
                    Message = "Bad request"
                });
            }

            var user = await _userHelper.GetUserByEmailAsync(request.Email);
            if (user == null)
            {
                return BadRequest(new Response
                {
                    IsSuccess = false,
                    Message = "Error001"
                });
            }

            string myToken = await _userHelper.GeneratePasswordResetTokenAsync(user);
            string link = Url.Action("ResetPassword", "Account", new { token = myToken }, protocol: HttpContext.Request.Scheme);
            _mailHelper.SendMail(request.Email, "Password Recover", $"<h1>Password Recover</h1>" +
                $"Click on the following link to change your password:<p>" +
                $"<a href = \"{link}\">Change Password</a></p>");

            return Ok(new Response { IsSuccess = true });
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut]
        public async Task<IActionResult> PutUser([FromBody] UserRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            string email = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var user = await _userHelper.GetUserByEmailAsync(email);
            if (user == null)
            {
                return NotFound("Error001");
            }

            //City city = await _context.Cities.FindAsync(request.CityId);
            //if (city == null)
            //{
            //    return BadRequest(new Response
            //    {
            //        IsSuccess = false,
            //        Message = "Error004"
            //    });
            //}

            //Guid imageId = user.ImageId;

            //if (request.ImageArray != null)
            //{
            //    imageId = await _blobHelper.UploadBlobAsync(request.ImageArray, "users");
            //}

            user.Name = request.FirstName;
            //  user.LastName = request.LastName;
            user.Address = request.Address;
            user.PhoneNumber = request.Phone;

            //   user.ImageId = imageId;
            //   user.Logitude = request.Logitude;
            //   user.Latitude = request.Latitude;

            IdentityResult respose = await _userHelper.UpdateUserAsync(user);
            if (!respose.Succeeded)
            {
                return BadRequest(respose.Errors.FirstOrDefault().Description);
            }

            var updatedUser = await _userHelper.GetUserByEmailAsync(email);
            return Ok(updatedUser);
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost]
        [Route("ChangePassword")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new Response
                {
                    IsSuccess = false,
                    Message = "Bad request",
                    Result = ModelState
                });
            }

            string email = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var user = await _userHelper.GetUserByEmailAsync(email);
            if (user == null)
            {
                return NotFound("Error001");
            }

            IdentityResult result = await _userHelper.ChangePasswordAsync(user, request.OldPassword, request.NewPassword);
            if (!result.Succeeded)
            {
                var message = result.Errors.FirstOrDefault().Description;
                return BadRequest(new Response
                {
                    IsSuccess = false,
                    Message = "Error005"
                });
            }

            return Ok(new Response { IsSuccess = true });
        }

        [HttpPost]
        [Route("CreateToken")]
        public async Task<IActionResult> CreateToken([FromBody] LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userHelper.GetUserByEmailAsync(model.Username);
                if (user != null)
                {
                    Microsoft.AspNetCore.Identity.SignInResult result = await _userHelper.ValidatePasswordAsync(user, model.Password);

                    if (result.Succeeded)
                    {
                        object results = GetToken(user);
                        return Created(string.Empty, results);
                    }
                }
            }

            return BadRequest();
        }

        [HttpPost]
        [Route("LoginFacebook")]
        public async Task<IActionResult> LoginFacebook([FromBody] FacebookProfile model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userHelper.GetUserByEmailAsync(model.Email);
                if (user == null)
                {
                    await _userHelper.AddUserAsync(model);
                }
                else
                {
                    //   user.ImageFacebook = model.Picture?.Data?.Url;
                    // user.FirstName = model.FirstName;
                    //  user.LastName = model.LastName;
                    await _userHelper.UpdateUserAsync(user);
                }

                object results = GetToken(user);
                return Created(string.Empty, results);
            }

            return BadRequest();
        }

        private object GetToken(ApplicationUser user)
        {
            Claim[] claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));
            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            JwtSecurityToken token = new JwtSecurityToken(
                _configuration["Tokens:Issuer"],
                _configuration["Tokens:Audience"],
                claims,
                expires: DateTime.UtcNow.AddDays(99),
                signingCredentials: credentials);

            return new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token),
                expiration = token.ValidTo,
                user
            };
        }
    }
}
//[HttpPost]
//    [Route("CreateToken")]
//    public async Task<IActionResult> CreateToken([FromBody] LoginViewModel model)
//    {
//        if (ModelState.IsValid)
//        {
//            var user = await _userHelper.GetUserByEmailAsync(model.Username);
//            if (user != null)
//            {
//                Microsoft.AspNetCore.Identity.SignInResult result = await _userHelper.ValidatePasswordAsync(user, model.Password);

//                if (result.Succeeded)
//                {
//                    Claim[] claims = new[]
//                    {
//                    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
//                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
//                };

//                    SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));
//                    SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
//                    JwtSecurityToken token = new JwtSecurityToken(
//                        _configuration["Tokens:Issuer"],
//                        _configuration["Tokens:Audience"],
//                        claims,
//                        expires: DateTime.Now.AddDays(99),
//                        signingCredentials: credentials);
//                    var results = new
//                    {
//                        token = new JwtSecurityTokenHandler().WriteToken(token),
//                        expiration = token.ValidTo,
//                        user
//                    };

//                    return Created(string.Empty, results);
//                }
//            }
//        }

//        return BadRequest();
//    }

//    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
//    [HttpPost]
//    [Route("GetUserByEmail")]
//    public async Task<IActionResult> GetUserByEmail([FromBody] EmailRequest request)
//    {
//        if (!ModelState.IsValid)
//        {
//            return BadRequest();
//        }

//        var user = await _userHelper.GetUserByEmailAsync(request.Email);
//        if (user == null)
//        {
//            return NotFound("Error001");
//        }

//        return Ok(user);
//    }




