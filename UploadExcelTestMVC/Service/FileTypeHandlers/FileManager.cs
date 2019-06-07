using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UploadExcelTestMVC.Models;

namespace UploadExcelTestMVC.Service.FileTypeHandlers
{
    public class FileManager : IFileManager
    {
        public List<HoursLogTableTemp> HandleFile(string fileName, string delimiter, string path)
        {
            var extension = Path.GetExtension(fileName);
            var fileType = extension.Substring(extension.IndexOf(".") + 1).ToLower().Trim();
            var handler = FileHandlerFactory.GetHandler(delimiter, fileType);

            return handler is IFileHandler ? handler.ProcessFile(path) : new List<HoursLogTableTemp>();
        }
    }
}
