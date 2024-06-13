using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    /*Senaryo:
       Bir otel rezervasyonu yapacaksınız. Bu istekte kurallar:
         1. Rezervasyon yapan kişi
         2. Check-in ve out tarihleri
         3. Otel musait olmalı
         4. Doğru otele gitmeli
     */
    public class ReservationRequest
    {
        public string Owner { get; set; }
        public DateOnly CheckIn { get; set; }
        public DateOnly CheckOut { get; set; }
        public int ParticipantsCount { get; set; }
        public string Country { get; set; }
    }

    public interface IHandler
    {
        void Handler(ReservationRequest reservationRequest);
        IHandler Next { get; set; }
    }
    public abstract class HandlerBase : IHandler
    {
        public IHandler Next { get; set; }

        public abstract void Handler(ReservationRequest reservationRequest);
        public HandlerBase()
        {
                
        }
        public HandlerBase(HandlerBase next)
        {
            Next = next;            
        }
    }
    /*Senaryo:
      Bir otel rezervasyonu yapacaksınız. Bu istekte kurallar:
        1. Rezervasyon yapan kişi boş mu dolu
        2. Check-in ve out tarihleri
        3. Otel musait olmalı
        4. Doğru otele gitmeli
    */

    public class CheckOwnerHandler : HandlerBase
    {
        public override void Handler(ReservationRequest reservationRequest)
        {
            if (string.IsNullOrEmpty(reservationRequest.Owner))
            {
                throw new Exception("Rezervasyon kimin adına?");
            }
            Next.Handler(reservationRequest);
        }
    }

    public class CheckInAndOutHandler : HandlerBase
    {
        public override void Handler(ReservationRequest reservationRequest)
        {
            if (reservationRequest.CheckIn >= reservationRequest.CheckOut)
            {
                throw new Exception("Rezervasyon tarihleri hatalı!");
            }
            Next.Handler(reservationRequest);
        }
    }

    public class IsAvailableHandler : HandlerBase
    {
        public override void Handler(ReservationRequest reservationRequest)
        {
            var number = new Random().Next(0,20);
            var isEven = number % 7 == 0;
            if (isEven)
            {
                throw new Exception("Ne yazık ki bu tarihlerde yer yok!");
            }
            Next.Handler(reservationRequest);
        }
    }

    public class IsCountryTurkeyHandler : HandlerBase
    {
        public override void Handler(ReservationRequest reservationRequest)
        {
          
            if (reservationRequest.Country.Contains("Türkiye"))
            {
                Console.WriteLine("Türkiye'de rezervasyon yapıldı");
            }
            else
            {
                Next.Handler(reservationRequest);
            }
        
        }
    }

    public class IsCountryItalyHandler : HandlerBase
    {
        public override void Handler(ReservationRequest reservationRequest)
        {

            if (reservationRequest.Country.Contains("Italy"))
            {
                Console.WriteLine("İtalya'da rezervasyon yapıldı");
            }
            else
            {
                Next.Handler(reservationRequest);
            }

        }
    }


}
