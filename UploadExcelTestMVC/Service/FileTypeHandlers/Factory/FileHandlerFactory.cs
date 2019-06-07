using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UploadExcelTestMVC.Service.FileTypeHandlers
{
    public static class FileHandlerFactory
    {
        public static IFileHandler GetHandler(string delimiter, string fileType)
        {
            switch (fileType)
            {
                case "xls":
                case "xlsx":
                    return new XlsHandler();
                case "csv":
                case "txt":
                    return new CsvHandler(delimiter);
                default:
                    return null;
            }
        }
    }
}
