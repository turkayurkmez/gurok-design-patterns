using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Report
    {
        public string ExcelFilePath { get; set; }
        public Report(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException();
            }
            ExcelFilePath = filePath;
        }
    }
}
