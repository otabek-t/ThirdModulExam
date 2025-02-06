using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace StorageBroker.Service.Services;

internal interface IStorageService
{
    void CreateFolder(string folderPath);
    void UploadFile(IFormFile file, string? folderPath);
    void UploadWithChunks(IFormFile file, string? folderPath);
    void UploadFiles(List<IFormFile> files, string? folderPath);
    void DeleteFile(string filePath);
    void DeleteFolder(string folderPath);
    void DownloadFile(string filePath);
    List<IFormFile> GetContentOfTxtFile();
}
