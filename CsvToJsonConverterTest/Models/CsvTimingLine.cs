using System;
using System.Collections.Generic;
using System.Text;

namespace CsvToJsonConverterTest.Models
{
    public class CsvTimingLine
    {
        public string Start { get; set; }
        public string Stop { get; set; }
        public string Gap { get; set; }
        public string Offset { get; set; }
        public string Pause { get; set; }
    }
}
