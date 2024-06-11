using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    //public enum CardType
    //{
    //    Standard,
    //    Silver,
    //    Gold,
    //    Premium
    //}

    //public class CardGenerator
    //{
    //    protected CardType cardType;
    //    public CardType GetCard()
    //    {

    //    }
    //}

    public abstract class CardType
    {

        public abstract decimal GetDiscounted(decimal price);
       
    }

    public class StandardCard : CardType
    {
        public override decimal GetDiscounted(decimal price)
        {
            return price * .95m;
        }
    }

    public class SilverCard : CardType
    {
        public override decimal GetDiscounted(decimal price)
        {
            return price * .9m;
        }
    }

    public class GoldCard : CardType
    {
        public override decimal GetDiscounted(decimal price)
        {
            return price * .85m;
        }
    }

    public class PremiumCard : CardType
    {
        public override decimal GetDiscounted(decimal price)
        {
            return price * .5m;
        }
    }


    public class Customer
    {
        public string Name { get; set; }
        public CardType Card { get; set; }
    }
    public class OrderManagement
    {
        public Customer Customer { get; set; }
        public decimal GetDiscountedPrice(decimal price)
        {
            //switch (Customer.Card)
            //{
            //    case CardType.Standard:
            //        return price * .95m;
            //    case CardType.Silver:
            //        return price * .9m;
            //    case CardType.Gold:
            //        return price * .85m;                    
            //    default:
            //        return price;
            //}
            return Customer.Card.GetDiscounted(price);
        }
    }
}
