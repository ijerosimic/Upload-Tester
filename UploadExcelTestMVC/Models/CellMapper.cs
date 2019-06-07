using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UploadExcelTestMVC.Models
{
    [NotMapped]
    public class CellMapper
    {
        public int ColID { get; set; }
        public string CellData { get; set; }
    }
}
