using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Yemek
    {
        public int PismeSuresi { get; set; }
        public List<string> Malzemeler { get; set; }
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }

        public void Pisir()
        {
            Console.WriteLine($"{GetType().Name}, {PismeSuresi} dakikada pişti");
        }

        public virtual void SunumYap()
        {
            Console.WriteLine($"{GetType().Name}, pilavla sunuldu");
        }
    }

    public class Corba : Yemek
    {
        public bool LimonVarMi { get; set; }

    }

    public class EtYemek : Yemek
    {
        public string EtTuru { get; set; }
    }

    public class TepsiKebabi : EtYemek
    {
        public bool AciliMi { get; set; }
    }

    public class Tatli : Yemek
    {
        public bool SerbetliMi { get; set; }
    }
    public class Tulumba: Tatli
    {
        public override void SunumYap()
        {
            Console.WriteLine($"{GetType().Name}, dondurmayla sunuldu");
        }
    }
}
