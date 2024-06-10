using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Product
    {
       
        private decimal price;
        public void SetPrice(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(paramName: nameof(value), "fiyat değeri negatif olamaz! ");
            }
            this.price = value;
        }

        public decimal GetPrice()
        {
            return price;
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Stock { get; private set; }

    }
}
