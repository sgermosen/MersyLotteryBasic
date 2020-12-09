namespace Mersy.Web.Controllers
{
    using CommonTasks.Data;
    using Mersy.Infraestructure;
    using Mersy.Infraestructure.Extensions;
    using Mersy.Web.Helpers;
    using Mersy.Web.Models;
    using Microsoft.AspNetCore.Authorization;
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

    public class AccountController : PsBaseController
    {
          private readonly IUserHelper _userHelper;
        private readonly IMailHelper _mailHelper;
        //private readonly ICountryRepository countryRepository;
        private readonly IConfiguration _configuration;
       // private readonly IBlobHelper _blobHelper;


        public AccountController(ApplicationDbContext context,
            IUserHelper userHelper,
            ICurrentUserFactory currentUser,
            IConfiguration configuration, 
            IMailHelper mailHelper
           // , IBlobHelper blobHelper
            ) : base(context, userHelper, currentUser)
        {
            //  UserHelper = userHelper;
            _mailHelper = mailHelper;
            this._configuration = configuration;
            _userHelper = userHelper;
            _configuration = configuration;
          //  _blobHelper = blobHelper;
            _mailHelper = mailHelper; 
        }

        //public AccountController(ApplicationDbContext context,
        //    IUserHelper userHelper, ICurrentUserFactory currentUser,          
        //   // IMailHelper mailHelper,
        //    IConfiguration configuration)
        //{
        //    Context = context;
        //    UserHelper = userHelper;
        //   // this._mailHelper = mailHelper;
        //    //   this.countryRepository = countryRepository;
        //    this._configuration = configuration;
        //}

        [Authorize]
        public async Task<IActionResult> MyAccount()
        {
            var vm = new UsersViewModel();
            var usr = await GetFullUserAsync();

            usr.Transfer(ref vm, null, false);

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> MyAccount(UsersViewModel view)
        {
            if (view.ActualPassword != "" || view.ConfirmPassword != "" || view.NewPassword != "")
            {
                if (view.ActualPassword == "")
                {
                    ModelState.AddModelError("", "Debe indicar la Contraseña Actual");
                }
                if (view.NewPassword == "")
                {
                    ModelState.AddModelError("", "Debe indicar una Nueva Contraseña");
                }
                if (view.ConfirmPassword == "")
                {
                    ModelState.AddModelError("", "Debe indicar una Confirmacion de Contraseña");
                }
                if (view.ConfirmPassword != view.NewPassword)
                {
                    ModelState.AddModelError("", "La Contraseña y la Confirmacion de Contraseña deben ser iguales");
                }

            }
            if (!ModelState.IsValid) return View(view);
            var user = await GetFullContectedPersonAsync();// await Context.Users.FindAsync(view.Id);
            var owner = await GetOwnerAsync();
            if (view.ImageFile != null)
            {
                var path = FileHelper.UploadFile(view.ImageFile, view.Imagen, "images", "user", ref owner);
                user.Imagen = path;
            }

            user.Name = view.Name;
            user.Address = view.Address;
            user.PhoneNumber = view.PhoneNumber;
            if (view.ActualPassword != null && view.ConfirmPassword != null && view.NewPassword != null)
            {
                var result = await UserHelper.ChangePasswordAsync(user, view.ActualPassword, view.NewPassword);
                if (!result.Succeeded)
                {
                    ModelState.AddModelError(string.Empty, result.Errors.FirstOrDefault().Description);
                }
            }
            Context.Entry(user).State = EntityState.Modified;

            await Context.SaveChangesAsync();
            return View(view);
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.RedirectToAction("Index", "Home");
            }

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!model.Username.Contains("@"))
                model.Username += "@mersyrd.com";

            var user = await GetFullUserAsync(model.Username);
            var strError = "";

            if (user != null)
            {
                if (!user.Owner.IsActive)
                {
                    strError = "Usuario o Cliente Inactivo, ";
                }
            }

            if (this.ModelState.IsValid)
            {
                var result = await UserHelper.LoginAsync(model);

                if (result.Succeeded)
                {
                    if (this.Request.Query.Keys.Contains("ReturnUrl"))
                    {
                        return this.Redirect(this.Request.Query["ReturnUrl"].First());
                    }

                    return this.RedirectToAction("Index", "Home");
                }
            }

            this.ModelState.AddModelError(string.Empty, $"{strError}Acceso Fallido.");
            return this.View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await UserHelper.LogoutAsync();
            return this.RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            //var model = new RegisterNewUserViewModel
            //{
            //    Countries = this.countryRepository.GetComboCountries(),
            //    Cities = this.countryRepository.GetComboCities(0)
            //};

            return this.View();
        }


        //[HttpPost]
        //public async Task<IActionResult> Register(RegisterNewUserViewModel model)
        //{
        //    if (this.ModelState.IsValid)
        //    {
        //        var user = await UserHelper.GetUserByEmailAsync(model.Username);
        //        if (user == null)
        //        {
        //            //  var city = await this.countryRepository.GetCityAsync(model.CityId);

        //            user = new ApplicationUser
        //            {
        //                Name = model.FirstName,
        //                Lastname = model.LastName,
        //                Email = model.Username,
        //                UserName = model.Username,
        //                Address = model.Address,
        //                PhoneNumber = model.PhoneNumber,
        //                //CityId = model.CityId,
        //                //City = city
        //            };

        //            var result = await UserHelper.AddUserAsync(user, model.Password);
        //            if (result != IdentityResult.Success)
        //            {
        //                this.ModelState.AddModelError(string.Empty, "Usuario no pudo ser creado");
        //                return this.View(model);
        //            }

        //            var myToken = await UserHelper.GenerateEmailConfirmationTokenAsync(user);
        //            var tokenLink = this.Url.Action("ConfirmEmail", "Account", new
        //            {
        //                userid = user.Id,
        //                token = myToken
        //            }, protocol: HttpContext.Request.Scheme);

        //            this._mailHelper.SendMail(model.Username, "911 Reactions Email confirmation", $"<h1>911 Reactions Email confirmation</h1>" +
        //                                                                                         $"Para permitir el acceso a tu usuario, " +
        //                                                                                         $"porfavor, has click en este link:</br></br><a href = \"{tokenLink}\">Confirmar Correo</a>");
        //            this.ViewBag.Message = "Las instrucciones para permitir el acceso a tu usuario, han sido enviadas a tu correo.";
        //            return this.View(model);
        //        }

        //        this.ModelState.AddModelError(string.Empty, "El usuario ya esta registrado.");
        //    }

        //    return this.View(model);
        //}

        //public async Task<IActionResult> ChangeUser()
        //{
        //    var user = await UserHelper.GetUserByEmailAsync(this.User.Identity.Name);
        //    var model = new ChangeUserViewModel();

        //    if (user != null)
        //    {
        //        model.FirstName = user.Name;
        //        model.LastName = user.Lastname;
        //        model.Address = user.Address;
        //        model.PhoneNumber = user.PhoneNumber;

        //        //var city = await this.countryRepository.GetCityAsync(user.CityId);
        //        //if (city != null)
        //        //{
        //        //    var country = await this.countryRepository.GetCountryAsync(city);
        //        //    if (country != null)
        //        //    {
        //        //        model.CountryId = country.Id;
        //        //        model.Cities = this.countryRepository.GetComboCities(country.Id);
        //        //        model.Countries = this.countryRepository.GetComboCountries();
        //        //        model.CityId = user.CityId;
        //        //    }
        //        //}
        //    }

        //    //model.Cities = this.countryRepository.GetComboCities(model.CountryId);
        //    //model.Countries = this.countryRepository.GetComboCountries();
        //    return this.View(model);
        //}

        //[HttpPost]
        //public async Task<IActionResult> ChangeUser(ChangeUserViewModel model)
        //{
        //    if (this.ModelState.IsValid)
        //    {
        //        var user = await UserHelper.GetUserByEmailAsync(this.User.Identity.Name);
        //        if (user != null)
        //        {
        //            //  var city = await this.countryRepository.GetCityAsync(model.CityId);

        //            user.Name = model.FirstName;
        //            user.Lastname = model.LastName;
        //            user.Address = model.Address;
        //            user.PhoneNumber = model.PhoneNumber;
        //            //user.CityId = model.CityId;
        //            //user.City = city;

        //            var respose = await UserHelper.UpdateUserAsync(user);
        //            if (respose.Succeeded)
        //            {
        //                this.ViewBag.UserMessage = "Usuario Actualizado!";
        //            }
        //            else
        //            {
        //                this.ModelState.AddModelError(string.Empty, respose.Errors.FirstOrDefault().Description);
        //            }
        //        }
        //        else
        //        {
        //            this.ModelState.AddModelError(string.Empty, "Usuario no Encontrado.");
        //        }
        //    }

        //    return this.View(model);
        //}

        //public IActionResult ChangePassword()
        //{
        //    return this.View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        //{
        //    if (this.ModelState.IsValid)
        //    {
        //        var user = await UserHelper.GetUserByEmailAsync(this.User.Identity.Name);
        //        if (user != null)
        //        {
        //            var result = await UserHelper.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
        //            if (result.Succeeded)
        //            {
        //                return this.RedirectToAction("ChangeUser");
        //            }
        //            else
        //            {
        //                this.ModelState.AddModelError(string.Empty, result.Errors.FirstOrDefault().Description);
        //            }
        //        }
        //        else
        //        {
        //            this.ModelState.AddModelError(string.Empty, "Usuario no Encontrado!!.");
        //        }
        //    }

        //    return this.View(model);
        //}

        [HttpPost]
        public async Task<IActionResult> CreateToken([FromBody] LoginViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                var user = await UserHelper.GetUserByEmailAsync(model.Username);
                if (user != null)
                {
                    var result = await UserHelper.ValidatePasswordAsync(
                        user,
                        model.Password);

                    if (result.Succeeded)
                    {
                        var claims = new[]
                        {
                                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                            };

                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this._configuration["Tokens:Key"]));
                        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                        var token = new JwtSecurityToken(
                            this._configuration["Tokens:Issuer"],
                            this._configuration["Tokens:Audience"],
                            claims,
                            expires: DateTime.Now.AddDays(15),
                            signingCredentials: credentials);
                        var results = new
                        {
                            token = new JwtSecurityTokenHandler().WriteToken(token),
                            expiration = token.ValidTo
                        };

                        return this.Created(string.Empty, results);
                    }
                }
            }

            return this.BadRequest();
        }

        public IActionResult NotAuthorized()
        {
            return this.View();
        }

        //public async Task<JsonResult> GetCitiesAsync(int countryId)
        //{
        //   // var country = await this.countryRepository.GetCountryWithCitiesAsync(countryId);
        //    //return this.Json(country.Cities.OrderBy(c => c.Name));
        //}

        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(token))
            {
                return this.NotFound();
            }

            var user = await UserHelper.GetUserByIdAsync(userId);
            if (user == null)
            {
                return this.NotFound();
            }

            var result = await UserHelper.ConfirmEmailAsync(user, token);
            if (!result.Succeeded)
            {
                return this.NotFound();
            }

            return View();
        }

        public IActionResult RecoverPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RecoverPassword(RecoverPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await UserHelper.GetUserByEmailAsync(model.Email);
                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "The email doesn't correspont to a registered user.");
                    return View(model);
                }

                string myToken = await UserHelper.GeneratePasswordResetTokenAsync(user);
                string link = Url.Action(
                    "ResetPassword",
                    "Account",
                    new { token = myToken }, protocol: HttpContext.Request.Scheme);
                _mailHelper.SendMail(model.Email, "Password Reset", $"<h1>Password Reset</h1>" +
                    $"To reset the password click in this link:</br></br>" +
                    $"<a href = \"{link}\">Reset Password</a>");
                ViewBag.Message = "The instructions to recover your password has been sent to email.";
                return View();

            }

            return View(model);
        }

        public IActionResult ResetPassword(string token)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            var user = await UserHelper.GetUserByEmailAsync(model.UserName);
            if (user != null)
            {
                var result = await UserHelper.ResetPasswordAsync(user, model.Token, model.Password);
                if (result.Succeeded)
                {
                    ViewBag.Message = "Password reset successful.";
                    return View();
                }

                ViewBag.Message = "Error while resetting the password.";
                return View(model);
            }

            ViewBag.Message = "User not found.";
            return View(model);
        }



        public async Task<IActionResult> ChangeUser()
        {
            var user = await _userHelper.GetUserByEmailAsync(User.Identity.Name);
            if (user == null)
            {
                return NotFound();
            }
             

            EditUserViewModel model = new EditUserViewModel
            {
                Nickname = user.Nickname,
                Address = user.Address,
                FirstName = user.Name,
                //LastName = user.Lastname,
                PhoneNumber = user.PhoneNumber,
                // ImageId = user.ImageId, 
                Id = user.Id, 
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeUser(EditUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                Guid imageId = model.ImageId;

                //if (model.ImageFile != null)
                //{
                //    imageId = await _blobHelper.UploadBlobAsync(model.ImageFile, "users");
                //}

                var user = await _userHelper.GetUserByEmailAsync(User.Identity.Name);

                user.Name = model.FirstName;
                user.Nickname = model.Nickname;
                user.Address = model.Address;
                user.PhoneNumber = model.PhoneNumber;

               // user.ImageId = imageId;
               

                await _userHelper.UpdateUserAsync(user);
                return RedirectToAction("Index", "Home");
            }

         
            return View(model);
        }

        
         

        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await UserHelper.GetUserByEmailAsync(User.Identity.Name);
                if (user != null)
                {
                    var result = await UserHelper.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("ChangeUser");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, result.Errors.FirstOrDefault().Description);
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "User no found.");
                }
            }

            return View(model);
        }

        //    public IActionResult RecoverPassword()
        //    {
        //        return this.View();
        //    }

        //    [HttpPost]
        //    public async Task<IActionResult> RecoverPassword(RecoverPasswordViewModel model)
        //    {
        //        if (this.ModelState.IsValid)
        //        {
        //            var user = await UserHelper.GetUserByEmailAsync(model.Email);
        //            if (user == null)
        //            {
        //                ModelState.AddModelError(string.Empty, "Este email no corresponde al usuario registrado.");
        //                return this.View(model);
        //            }

        //            var myToken = await UserHelper.GeneratePasswordResetTokenAsync(user);
        //            var link = this.Url.Action("ResetPassword", "Account", new { token = myToken }, protocol: HttpContext.Request.Scheme);
        //            var mailSender = new MailHelper(_configuration);
        //            mailSender.SendMail(model.Email, "Reacciones 911 Recuperacion de Contraseña", $"<h1>Reacciones 911 Recuperacion de Contraseña</h1>" +
        //                                                                                          $"Para resetear su contraseña, haga click en este link:</br></br>" +
        //                                                                                          $"<a href = \"{link}\">Resetear Contraseña</a>");
        //            this.ViewBag.Message = "Las instrucciones para recuperar tu contraseña, han sido enviadas a tu Correo";
        //            return this.View();

        //        }

        //        return this.View(model);
        //    }

        //    public IActionResult ResetPassword(string token)
        //    {
        //        return View();
        //    }

        //    [HttpPost]
        //    public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        //    {
        //        var user = await UserHelper.GetUserByEmailAsync(model.UserName);
        //        if (user != null)
        //        {
        //            var result = await UserHelper.ResetPasswordAsync(user, model.Token, model.Password);
        //            if (result.Succeeded)
        //            {
        //                this.ViewBag.Message = "Contraseña Reseteada Satisfactoriamente.";
        //                return this.View();
        //            }

        //            this.ViewBag.Message = "Error mientras se intentaba resetear la contraseña.";
        //            return View(model);
        //        }

        //        this.ViewBag.Message = "Ususario no encontrado.";
        //        return View(model);
        //    }

    }
}