using System;
using System.Collections.Generic;
using System.Text;

namespace CsvToJsonConverterTest.Models
{
    public class CsvBuyerLine
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }

        public CsvBuyerLine(string name, string street, string zip)
        {
            Name = name;
            Street = street;
            Zip = zip;
        }
    }
}
