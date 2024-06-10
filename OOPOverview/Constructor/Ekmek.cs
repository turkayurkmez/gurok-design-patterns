using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Ekmek
    {
        public int Adet { get; set; }
        public string Tur { get; set; }

        public Ekmek() : this(1,"Beyaz") { 
            //Adet = 1;
            //Tur = "Beyaz";
        }
        public Ekmek(int adet):this(adet,"Beyaz")
        {
            //Adet = adet;
            //Tur = "Beyaz";
        }
        public Ekmek(string tur):this(1,tur)
        {
            //Tur = tur;
            //Adet = 1;
        }

        public Ekmek(int adet, string tur)
        {
            Adet = adet;
            Tur = tur;

            biseyYap();
        }

        private void biseyYap()
        {
            throw new NotImplementedException();
        }
    }
}

