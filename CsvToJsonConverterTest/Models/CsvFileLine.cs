using System;
using System.Collections.Generic;
using System.Text;

namespace CsvToJsonConverterTest.Models
{
    public class CsvFileLine
    {
        public string Date { get; set; }
        public string Type { get; set; }
        public CsvEnderLine Ender { get; set; }
        public List<CsvOrderLine> Orders { get; set; }

        public CsvFileLine(string date, string type)
        {
            Date = date;
            Type = type;
        }
    }
}
