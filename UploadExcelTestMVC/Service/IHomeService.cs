using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UploadExcelTestMVC.Models;

namespace UploadExcelTestMVC.Service
{
    public interface IHomeService
    {
        List<HoursLogTableTemp> SaveTemp(IFormFile file, string delimiter, string newPath);
    }
}
