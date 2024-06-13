using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /*
     *  Hem PDF hem de HTML olarak alabileceğiniz Satış ve Performans raporlarınız var. Geliştirme yapısını nasıl tasarlayacağız?
     *  
     *  
     */
    public class Report
    {
        public Format Format { get; set; }
    }

    public class Format
    {    
    }

    public class HTMLFormat: Format
    {

    }

    public class PDFFormat: Format { }

    public class SalesReport: Report { }
    public class  PerformanceReport : Report
    {
        
    }


    //public class PDFSalesReport  : SalesReport { }
    //public class HTMLSalesReport : SalesReport { }
}
