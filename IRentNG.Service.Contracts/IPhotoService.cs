using Microsoft.AspNetCore.Http;

namespace IRentNG.Service.Contracts
{
    public interface IPhotoService
    {
        string UploadPhoto(IFormFile file);
        IEnumerable<string> UploadPhotos(IFormFile file);
    }
}