using System;
using System.Collections.Generic;
using System.Text;

namespace CsvToJsonConverterTest.Models
{
    public class CsvEnderLine
    {
        public string Process { get; set; }
        public string Paid { get; set; }
        public string Created { get; set; }

        public CsvEnderLine(string process, string paid, string created)
        {
            Process = process;
            Paid = paid;
            Created = created;
        }
    }
}
