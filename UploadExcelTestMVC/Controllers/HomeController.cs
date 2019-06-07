using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using UploadExcelTestMVC.Data;
using UploadExcelTestMVC.Models;
using UploadExcelTestMVC.Service;
using UploadExcelTestMVC.Service.FileTypeHandlers;

namespace UploadExcelTestMVC.Controllers
{
    public class HomeController : Controller
    {
        IHostingEnvironment _hostingEnvironment { get; }
        AppDbContext _context { get; }
        IHomeService _service { get; }
        public HomeController(IHostingEnvironment hostingEnvironment, AppDbContext context, IHomeService service)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
            _service = service;
        }

        public IActionResult Index() => View();

        [HttpPost]
        public int Upload([FromBody]List<HoursLogTable> logger)
        {
            if (logger.Count == 0) return -1;

            var counter = new List<int>();

            foreach (var entry in logger)
            {
                var log = new HoursLogTable()
                {
                    WorkerID = entry.WorkerID,
                    WorkerName = entry.WorkerName,
                    WorkerSurname = entry.WorkerSurname,
                    Hours = entry.Hours
                };

                _context.Add(log);
                counter.Add(_context.SaveChanges());
            }

            if (counter.Count == logger.Count) return 1;
            else return 0;
        }

        [HttpPost]
        public IActionResult Preview()
        {
            IFormFile file = Request.Form.Files[0];
            var delimiter = Request.Form.Keys.FirstOrDefault();

            var folderName = "Upload";
            var webRootPath = _hostingEnvironment.WebRootPath;
            var newPath = Path.Combine(webRootPath, folderName);
            var hoursLogged = _service.SaveTemp(file, delimiter, newPath);

            if (hoursLogged.Count > 0) return PartialView("_FilePreviewPartialView", hoursLogged);
            return PartialView("_ErrorPartialView");
        }
    }
}
