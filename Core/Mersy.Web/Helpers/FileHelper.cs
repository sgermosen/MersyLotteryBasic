using Mersy.Common.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Mersy.Web.Helpers
{
    public class FileHelper
    {

        public static string UploadFile(IFormFile vmfile, string path, string root, string folder, ref Owner owner)
        {
            if (vmfile != null && vmfile.Length > 0)
            {
                var basePath = $"wwwroot\\{root}\\{folder}";
                var guid = Guid.NewGuid().ToString();
                var ext = Path.GetExtension(vmfile.FileName);
                var file = $"{guid}{ext}";

                path = Path.Combine(Directory.GetCurrentDirectory(), basePath, file);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    vmfile.CopyTo(stream);
                }

                path = $"~/{root}/{folder}/{file}";


                var size = (vmfile.Length / 1024);
                size /= 1024;
                if (size <= 1)
                    size = 1;

                owner.MegabytesAvailable -= Convert.ToInt32(size);
                //  owner.Imagen = path;

            }

            return path;
        }
        public static async Task<string> UploadFile(IFormFile vmfile, string path, string root, string folder)
        {
            if (vmfile != null && vmfile.Length > 0)
            {
                var basePath = $"wwwroot\\{root}\\{folder}";
                var guid = Guid.NewGuid().ToString();
                var ext = Path.GetExtension(vmfile.FileName);
                var file = $"{guid}{ext}";

                path = Path.Combine(Directory.GetCurrentDirectory(), basePath, file);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await vmfile.CopyToAsync(stream);
                }

                path = $"~/{root}/{folder}/{file}";
            }

            return path;
        }
    }
}
