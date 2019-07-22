using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsvToJsonConverterTest.Models
{
    public class CsvFileLine
    {
        public string Date { get; set; }
        public string Type { get; set; }
        public CsvEnderLine Ender { get; set; }
        public List<CsvOrderLine> Orders { get; set; } = new List<CsvOrderLine>();

        public CsvFileLine(string date, string type)
        {
            Date = date;
            Type = type;
        }

        public void AddOrder(string date, string code, string number)
        {
            Orders.Add(new CsvOrderLine(date, code, number));
        }

        public CsvOrderLine MostRecentOrder => Orders.LastOrDefault();

        public void AddEnder(string process, string paid, string created)
        {
            Ender = new CsvEnderLine(process, paid, created);
        }
    }
}
