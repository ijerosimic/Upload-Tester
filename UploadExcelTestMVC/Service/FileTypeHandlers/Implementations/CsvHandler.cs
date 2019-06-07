using CsvHelper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UploadExcelTestMVC.Models;

namespace UploadExcelTestMVC.Service.FileTypeHandlers
{
    public class CsvHandler : IDelimiterUser
    {
        public string _delimiter { get; }
        public CsvHandler(string delimiter) => _delimiter = delimiter;

        public List<HoursLogTableTemp> ProcessFile(string fullPath)
        {
            using (var reader = new StreamReader(fullPath))
            using (var csv = new CsvReader(reader))
            {
                var config = csv.Configuration;
                config.HasHeaderRecord = false;
                config.MissingFieldFound = null;
                config.BadDataFound = null;
                //config.Delimiter = ",";
                config.Delimiter = _delimiter;

                var records = csv.GetRecords<dynamic>().ToList();
                var hoursLogged = new List<HoursLogTableTemp>();
                var rowCounter = 0;

                foreach (IDictionary<string, object> record in records)
                {
                    var values = record.Values.ToList();

                    var log = new HoursLogTableTemp()
                    {
                        RowID = ++rowCounter,
                        RowData = new List<string>()
                    };

                    values.ForEach(v => log.RowData.Add(v.ToString()));
                    hoursLogged.Add(log);
                }

                return hoursLogged;
            }
        }
    }
}
