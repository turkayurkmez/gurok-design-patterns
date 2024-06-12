using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /*
     * Senaryo: 
     * 
     * Bir harita uygulaması yapıyorsunuz. Bir turist, ziyaret amacına göre haritada ziyaret edeceği lokasyonları görmektedir:
     *    Örnek: amacı kültür olan bir turist; müze, sergi salonu vs gibi yerleri görmeli.    */

    //0. Haritada (Product) gösterilecek ziyaret noktaları
    public interface IVisitPoint
    {
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public string Name { get; set; }
    }
    public class SultanahmetCamii : IVisitPoint
    {
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public string Name { get; set; }
    }

    public class TopkapiSarayi : IVisitPoint
    {
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public string Name { get; set; }
    }

    public class YerebatanSarnici : IVisitPoint
    {
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public string Name { get; set; }
    }

    //1. Product: Fabrikanızın geliştireceği ürün (abstract class ya da interface olmalı):
    public interface IMap
    {
        public List<IVisitPoint> VisitPoints { get; set; }
    }

    //2. Concrete Products: Üretilecek ürünleri tanımlayan nesneler
    public class ReligionMap : IMap
    {
        public List<IVisitPoint> VisitPoints { get; set; }
    }
    public class CultureMap : IMap
    {
        public List<IVisitPoint> VisitPoints { get; set; }
    }

    //3. Creator: ihtiyaç duyduğunuz ürünü oluşturacak (fabrika) sınıf:
    public abstract class MapGenerator
    {
        protected IMap map;
        protected abstract void CreateMap();
        public MapGenerator()
        {
            CreateMap();     
        }

        public void Show()
        {
            foreach (var visitPoint in map.VisitPoints)
            {
                Console.WriteLine(visitPoint.GetType().Name);
            }
        }

    }

    public class ReligionMapGenerator : MapGenerator
    {
        protected override void CreateMap()
        {
            ReligionMap religionMap = new ReligionMap();
            religionMap.VisitPoints = new List<IVisitPoint>();
            religionMap.VisitPoints.Add(new SultanahmetCamii());

            this.map = religionMap;
        }
    }

    public class CultureMapGenerator : MapGenerator
    {
        protected override void CreateMap()
        {
            CultureMap cultureMap = new CultureMap();
            cultureMap.VisitPoints = new List<IVisitPoint>();
            cultureMap.VisitPoints.Add(new YerebatanSarnici());
            cultureMap.VisitPoints.Add(new TopkapiSarayi());


            this.map = cultureMap;
        }
    }

}


