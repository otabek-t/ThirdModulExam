using Microsoft.AspNetCore.Http;

namespace StorageBroker.Service.Services;

public class StorageServiceBroker : IStorageService
{
    private readonly IStorageService _storageService;

    

    private string _dataPath;
    public StorageServiceBroker()
    {
        _dataPath = Path.Combine(Directory.GetCurrentDirectory(), "data");
        if (!Directory.Exists(_dataPath))
        {
            Directory.CreateDirectory(_dataPath);
        }

    }
    public void CreateFolder(string folderPath)
    {
        var fileAdd = Path.Combine(_dataPath, folderPath);
        _storageService.CreateFolder(folderPath);
    }

    public void DeleteFile(string filePath)
    {
        _storageService.DeleteFile(filePath);
    }

    public void DeleteFolder(string folderPath)
    {
        _storageService.DeleteFolder(folderPath);
    }

    public void DownloadFile(string filePath)
    {
        _storageService.DownloadFile(filePath);
    }

    public List<IFormFile> GetContentOfTxtFile()
    {
        var result = new List<IFormFile>();
        return result;
    }

    public void UploadFile(IFormFile file, string? folderPath)
    {
        var uploadPath = Path.Combine(_dataPath, folderPath);
        using (StreamReader stream = new StreamReader())
        {
            file.CopyTo(folderPath);
        }
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
