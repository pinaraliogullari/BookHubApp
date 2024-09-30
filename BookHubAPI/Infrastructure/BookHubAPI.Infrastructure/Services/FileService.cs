﻿using BookHubAPI.Application.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using static BookHubAPI.Infrastructure.StaticServices.NameService;

namespace BookHubAPI.Infrastructure.Services;

public class FileService : IFileService
{
    private readonly IWebHostEnvironment _webHostEnvironment;

    public FileService(IWebHostEnvironment webHostEnvironment)
    {
        _webHostEnvironment = webHostEnvironment;
    }

    public async Task<bool> CopyFileAsync(string path, IFormFile file)
    {
        try
        {
            await using FileStream fileStream = new(path, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize: 1024 * 1024, useAsync: false);
            await fileStream.CopyToAsync(fileStream);
            await fileStream.FlushAsync();
            return true;
        }
        catch (Exception ex)
        {
            //todo log!
            throw ex;
        }
    }

    private async Task<string> FileRenameAsync(string path, string fileName)
    {
        await Task.Run(async () =>
        {
            string extension = Path.GetExtension(fileName);
            string oldName = Path.GetFileNameWithoutExtension(fileName);
            string newFileName = $"{NameOperation.CharacterRegulatory(oldName)}{extension}";
            if (File.Exists($"{path}\\{newFileName}"))
                await FileRenameAsync(path, newFileName);
            
        });
        return "";
       
    }

    public async Task<List<(string fileName, string path)>> UploadAsync(string path, IFormFileCollection files)
    {
        string uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, path);
        if (!Directory.Exists(uploadPath))
            Directory.CreateDirectory(uploadPath);

        List<(string fileName, string path)> data = new();
        List<bool> results = new();
        foreach (IFormFile file in files)
        {
            string fileNewName = await FileRenameAsync(file.FileName);
            bool result = await CopyFileAsync($"{uploadPath}\\{fileNewName}", file);
            data.Add((fileNewName, $"{uploadPath}\\{fileNewName}"));
            results.Add(result);
        }
        if (results.TrueForAll(x => x.Equals(true)))
            return data;
        return null;
        //todo  an error occured while the file upload  , error exception will be apply.
    }
}
