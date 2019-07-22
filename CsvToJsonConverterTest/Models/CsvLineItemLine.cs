using System;
using System.Collections.Generic;
using System.Text;

namespace CsvToJsonConverterTest.Models
{
    public class CsvLineItemLine
    {
        public string Sku { get; set; }
        public string Quantity { get; set; }

        public CsvLineItemLine(string sku, string quantity)
        {
            Sku = sku;
            Quantity = quantity;
        }
    }
}
