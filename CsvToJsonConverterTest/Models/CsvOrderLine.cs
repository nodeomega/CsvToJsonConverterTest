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
        public List<CsvLineItemLine> Items { get; set; }

        public CsvOrderLine(string date, string code, string number)
        {
            Date = date;
            Code = code;
            Number = number;
        }
    }
}
