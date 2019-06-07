using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UploadExcelTestMVC.Models
{
    [NotMapped]
    public class HoursLogTableTemp
    {
        [Key]
        public List<string> RowData { get; set; }
        public int RowID { get; set; }
        public int ColCount { get; set; }
    }
}
