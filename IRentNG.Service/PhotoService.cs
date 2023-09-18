using IRentNG.Service.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using IRentNG.Entities.Exceptions;

namespace IRentNG.Service
{
    public class PhotoService : IPhotoService
    {
        private IConfiguration Configuration { get; }
        private Cloudinary _cloudinary;

        public PhotoService(IConfiguration configuration)
        {
            Configuration = configuration;
            var cloudinarySettings = Configuration.GetSection("CloudinarySettings");
            var cloudName = cloudinarySettings["CloudName"];
            var apiKey = cloudinarySettings["ApiKey"];
            var apiSecret = cloudinarySettings["ApiSecret"];
            Account account = new Account(cloudName, apiKey, apiSecret);

            _cloudinary = new Cloudinary(account);
        }

        public string UploadPhoto(IFormFile file)
        {
            var uploadResult = new ImageUploadResult();
            if (file.Length > 0)
            {
                using (var stream = file.OpenReadStream())
                {
                    var uploadParams = new ImageUploadParams()
                    {
                        File = new FileDescription(file.Name, stream)
                    };
                    uploadResult = _cloudinary.Upload(uploadParams);
                }
            }

            if (uploadResult.Url is null)
                throw new PhotoFileUploadException();

            string url = uploadResult.Url.ToString();
            string publicId = uploadResult.PublicId;//work with this next time

            return url;
        }

        public IEnumerable<string> UploadPhotos(IFormFile file)
        {
            throw new NotImplementedException();
        }
    }
}
