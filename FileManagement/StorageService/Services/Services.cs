using Microsoft.AspNetCore.Http;

namespace Storage.Service.Services;

public class Services : IService
{
    public void CreateFolder(string folderPath)
    {
        
    }

    public void DeleteFile(string filePath)
    {
        throw new NotImplementedException();
    }

    public void DeleteFolder(string folderPath)
    {
        throw new NotImplementedException();
    }

    public void DownloadFile(string filePath)
    {
        throw new NotImplementedException();
    }

    public List<IFormFile> GetFormFiles()
    {
        throw new NotImplementedException();
    }

    public void UploadFile(IFormFile file, string? folderPath)
    {
        throw new NotImplementedException();
    }

    public void UploadFiles(List<IFormFile> files, string? folderPath)
    {
        throw new NotImplementedException();
    }

    public void UploadWithChunks(IFormFile file, string? folderPath)
    {
        throw new NotImplementedException();
    }
}
