using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UploadExcelTestMVC.Models;

namespace UploadExcelTestMVC.Service.FileTypeHandlers
{
    public class XlsHandler : IFileHandler
    {
        public List<HoursLogTableTemp> ProcessFile(string fullPath)
        {
            using (var stream = File.Open(fullPath, FileMode.Open, FileAccess.Read))
            {
                IExcelDataReader reader;
                using (reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var config = new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = r => new ExcelDataTableConfiguration
                        {
                            UseHeaderRow = false
                        }
                    };

                    var dataSet = reader.AsDataSet(config);
                    var dataTable = dataSet.Tables;
                    var rows = dataTable[0].Rows;
                    var columns = dataTable[0].Columns;

                    var hoursLogged = new List<HoursLogTableTemp>();

                    for (var row = 0; row < rows.Count; row++)
                    {
                        var log = new HoursLogTableTemp
                        {
                            RowID = 0,
                            RowData = new List<string>()
                        };

                        var cell = new CellMapper();

                        for (var col = 0; col < columns.Count; col++)
                        {
                            log.RowID = row;
                            log.RowData.Add((rows[row][col]).ToString());
                        }

                        log.ColCount = columns.Count;
                        hoursLogged.Add(log);
                    }
                    return hoursLogged;
                }
            }
        }
    }
}
