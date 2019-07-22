using System;
using System.Collections.Generic;
using System.Text;

namespace CsvToJsonConverterTest.Models
{
    public class CsvOrderLine
    {
        public string Date { get; set; }
        public string Code { get; set; }
        public string Number { get; set; }
        public CsvBuyerLine Buyer { get; set; }
        public CsvTimingLine Timings { get; set; }
        public List<CsvLineItemLine> Items { get; set; } = new List<CsvLineItemLine>();

        public CsvOrderLine(string date, string code, string number)
        {
            Date = date;
            Code = code;
            Number = number;
        }

        public void SetBuyer(string name, string street, string zip)
        {
            Buyer = new CsvBuyerLine(name, street, zip);
        }

        public void SetTimings(string start, string stop, string gap, string offset, string pause)
        {
            Timings = new CsvTimingLine(start, stop, gap, offset, pause);
        }

        public void AddItemLine(string sku, string quantity)
        {
            Items?.Add(new CsvLineItemLine(sku, quantity));
        }
    }
}
