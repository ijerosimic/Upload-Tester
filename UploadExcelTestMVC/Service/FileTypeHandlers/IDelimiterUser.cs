using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UploadExcelTestMVC.Service.FileTypeHandlers
{
    public interface IDelimiterUser : IFileHandler
    {
        string _delimiter { get;}
    }
}
