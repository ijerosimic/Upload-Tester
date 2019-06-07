using CsvHelper;
using ExcelDataReader;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadExcelTestMVC.Data;
using UploadExcelTestMVC.Models;

namespace UploadExcelTestMVC.Service
{
    public class HomeService : IHomeService
    {
        IFileManager _handler { get; }
        public HomeService(IFileManager handler) => _handler = handler;
        public List<HoursLogTableTemp> SaveTemp(IFormFile file, string delimiter, string path)
        {
            try
            {
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);

                if (file.Length > 0)
                {
                    string fullPath = Path.Combine(path, file.FileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        stream.Position = 0;
                    }

                    return _handler.HandleFile(file.FileName, delimiter, fullPath);
                }
                return new List<HoursLogTableTemp>();
            }
            catch
            {
                return new List<HoursLogTableTemp>();
            }
        }
    }
}
