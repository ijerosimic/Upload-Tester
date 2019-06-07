using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UploadExcelTestMVC.Models
{
    [Table("ExcelUploadTestTable")]
    public class HoursLogTable
    {
        [Key]
        public int ID { get; set; }
        [Index(0)]
        public string WorkerID { get; set; }
        [Index(1)]
        public string WorkerName { get; set; }
        [Index(2)]
        public string WorkerSurname { get; set; }
        [Index(3)]
        public string Hours { get; set; }
    }
}
