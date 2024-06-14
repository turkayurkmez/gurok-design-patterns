using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bir nesnenin metodlarını değiştirmeden ya da metot eklemeden nesneye fonksiyonellik kazandırmak isterseniz. Visitor pattern'i uygundur.
             * 
             * SENARYO: Bir özel kursun çalışanlarının maaşlarına ve ay içerisindeki tatil günlerinde değişiklik yapacaksınız. Her seferinde metot yenilemek yerine, bu tasarım desenini kullanacağız.
             */

            Calisanlar calisanlar = new Calisanlar();
            calisanlar.Ekle(new Yazilimci("Müge"));
            calisanlar.Ekle(new Muhasebeci("Ali"));
            calisanlar.Ekle(new InsanKaynaklari("Aytaç"));

            calisanlar.TumunuKabulEt(new MaasFonksiyon());
            calisanlar.TumunuKabulEt(new TatilGunleri());

            Console.ReadLine();
        }
    }

    public interface IElement
    {
        void Accept(Visitor visitor);
    }

    public abstract class Visitor
    {
        public void ReflectiveVisit(IElement element)
        {
            var types = new Type[] { element.GetType() };
            var visitMethod = this.GetType().GetMethod("Visit", types);
            if (visitMethod != null)
            {
                visitMethod.Invoke(this, new object[] { element });
            }
        }
    }

    public class Calisan : IElement
    {
        public Calisan(string ad, double maas, int tatilGunleri)
        {
            Ad = ad;
            Maas = maas;
            TatilGunleri = tatilGunleri;
        }

        public string Ad { get; set; }
        public int TatilGunleri { get; set; }
        public double Maas { get; set; }
        public void Accept(Visitor visitor)
        {
            visitor.ReflectiveVisit(this);
        }
    }

    public class Calisanlar : List<Calisan>
    {
        public void Ekle(Calisan calisan)
        {
            this.Add(calisan);
        }

        public void Cikart(Calisan calisan)
        {
            this.Remove(calisan);
        }
        public void TumunuKabulEt(Visitor visitor)
        {
            foreach (var item in this)
            {
                item.Accept(visitor);
            }
            Console.WriteLine("Ziyaretçinin fonksiyonu kabul edildi");
        }
    }

    public class Yazilimci : Calisan
    {
        public Yazilimci(string ad)
            : base(ad, 4000, 8)
        {

        }
    }
    public class Muhasebeci : Calisan
    {
        public Muhasebeci(string ad)
            : base(ad, 2000, 4)
        {

        }
    }

    public class InsanKaynaklari : Calisan
    {
        public InsanKaynaklari(string ad)
            : base(ad, 3500, 6)
        {

        }
    }

    public class MaasFonksiyon : Visitor
    {
        public void Visit(Yazilimci yazilimci)
        {
            DoVisit(yazilimci);
        }
        public void Visit(Muhasebeci muhasebeci)
        {
            DoVisit(muhasebeci);
        }

        public void Visit(InsanKaynaklari uzman)
        {
            DoVisit(uzman);
        }

        private void DoVisit(IElement element)
        {
            Calisan calisan = element as Calisan;
            calisan.Maas *= 1.20;
            Console.WriteLine("{0} tipindeki çalışanın yeni maaşı:{1}", calisan.GetType().Name, calisan.Maas);
        }

    }
    public class TatilGunleri : Visitor
    {
        public void Visit(Yazilimci yazilimci)
        {
            DoVisit(yazilimci);
        }
        public void Visit(Muhasebeci muhasebeci)
        {
            DoVisit(muhasebeci);
        }
        public void Visit(InsanKaynaklari uzman)
        {
            DoVisit(uzman);
        }

        private void DoVisit(IElement element)
        {
            Calisan calisan = element as Calisan;
            calisan.TatilGunleri += 3;
            Console.WriteLine("{0} tipindeki çalışanın yeni tatil sayısı (aylık):{1}", calisan.GetType().Name, calisan.TatilGunleri);
        }
    }








}
