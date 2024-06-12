using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /*
     * Senaryo:
     * 
     * Karmaşık süreçlerden geçerek (farklı db, dosya okuma gibi) rapor oluşturan bir nesneniz var. 
     * 
     */

    //1. Ne üreteceksiniz? (Product)
    public class Report
    {
        public string Title { get; set; }
        public string Data { get; set; }
        public string Graph { get; set; }
    }

    //2. Bu karmaşık aşamaları belirten, interface....(IBuilder)
    public interface IReportBuilder
    {
        void BuildTitle();
        void BuildData();
        void BuildGraph();

        Report GetBuildingReport();
    }

    //3. (2. adımdaki) interface'i implemente eden sınıfları oluşturun:

    public class WeeklySalesReportBuilder : IReportBuilder
    {

        private Report report = new Report();
        public void BuildData()
        {
            //buradaki işin karmaşık olduğunu unutmayınız.
            report.Data = "Haftalık satış verisi";
        }

        public void BuildGraph()
        {
            report.Graph = "Haftalık satış grafiği eklendi";
        }

        public void BuildTitle()
        {
            report.Title = "Haftalık Satış Raporu";
        }

        public Report GetBuildingReport()
        {
            return report;
        }
    }

    public class WeeklyEmployeePerformanceReportBuilder : IReportBuilder
    {

        private Report report = new Report();
        public void BuildData()
        {
            //buradaki işin karmaşık olduğunu unutmayınız.
            report.Data = "Haftalık çalışan performans verisi";
        }

        public void BuildGraph()
        {
            report.Graph = "Haftalık çalışan performans grafiği eklendi";
        }

        public void BuildTitle()
        {
            report.Title = "Haftalık çalışan performans Raporu";
        }

        public Report GetBuildingReport()
        {
            return report;
        }
    }

    //4. Product nesnesini, düzenli bir biçimde üretecek olan Director sınfı:
    public class ReportBuilderDirector
    {
        public IReportBuilder Builder { get; set; }
        public Report GetReport()
        {
            Builder.BuildTitle();
            Builder.BuildData();
            Builder.BuildGraph();
            return Builder.GetBuildingReport();
        }
    }
}
