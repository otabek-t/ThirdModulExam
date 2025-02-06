using Microsoft.AspNetCore.Http;

namespace Storage.Service.Services
{
    internal interface IService
    {
        void CreateFolder(string folderPath);
        void UploadFile(IFormFile file, string? folderPath);
        void UploadWithChunks(IFormFile file, string? folderPath);
        void UploadFiles(List<IFormFile> files, string? folderPath);
        void DeleteFile(string filePath);
        void DeleteFolder(string folderPath);
        void DownloadFile(string filePath);
        List<IFormFile> GetFormFiles();
    }
}