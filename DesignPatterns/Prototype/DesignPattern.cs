using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Prototype
{
    /*
	 * Senaryo: 
	 * Bir sinema koltuk seçim ekranı yapıyorsunuz. 300 koltuk nesnesi bellekte olmalı. 
	 */
    public class Chair : ICloneable
    {
        public int No { get; set; }
        public string Letter { get; set; }
        public string DefaultColor { get; set; }

        public Cinema Cinema { get; set; }

        public Chair()
        {
            Console.WriteLine($"{DateTime.Now} nesne oluşturuluyor....");
            Thread.Sleep(10000);
            Console.WriteLine($"{DateTime.Now} nesne oluşturuldu....");
            Cinema = new Cinema() { Movie = "King Kong ve Godzilla", MovieTime = DateTime.Now };
            No = 1;
            Letter = "A";
            DefaultColor = "Black";

        }
        public object Clone()
        {
            return MemberwiseClone();
        }

        public object Clone(bool isDeepClone)
        {
            return isDeepClone ? deepClone() : Clone();
        }

        private object? deepClone()
        {
            var serialized = JsonConvert.SerializeObject(this);
            var output = JsonConvert.DeserializeObject<Chair>(serialized);
            return output;
        }

        public override string ToString()
        {
            return $"{Letter}{No}-{Cinema.Movie}";
        }
    }

    public class Cinema
    {
        public string Movie { get; set; }
        public DateTime MovieTime { get; set; }
    }
}
