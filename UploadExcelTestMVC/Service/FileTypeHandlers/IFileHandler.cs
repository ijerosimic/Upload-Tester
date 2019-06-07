using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using UploadExcelTestMVC.Models;

namespace UploadExcelTestMVC.Service.FileTypeHandlers
{
    public interface IFileHandler
    {
        List<HoursLogTableTemp> ProcessFile(string fullPath);
    }
}