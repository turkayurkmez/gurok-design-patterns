// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility;

Console.WriteLine("Hello, World!");
/*
 * Bir istek, birden fazla işlemden geçerek bir sonuca ulaşıyor. Her bir işlem benzer standartlar ve aynı amaç için çalışıyor (örnek: Asp.net core'de http request ya da ATM'deki para analojisi). Hangi işlemin nasıl yapılacağını en ideal nasıl tasarlarsınız?
 */

ReservationRequest reservationRequest = new ReservationRequest()
{
    Owner = "Türkay",
    CheckIn = new DateOnly(2024, 6, 18),
    CheckOut = new DateOnly(2024,6,19),
    Country = "Italy"
};

CheckOwnerHandler checkOwnerHandler = new CheckOwnerHandler();
CheckInAndOutHandler checkInAndOutHandler   = new CheckInAndOutHandler();
IsAvailableHandler isAvailableHandler = new IsAvailableHandler();
IsCountryTurkeyHandler ısCountryTurkeyHandler = new IsCountryTurkeyHandler();
IsCountryItalyHandler ısCountryItalyHandler = new IsCountryItalyHandler();

checkOwnerHandler.Next = checkInAndOutHandler;
checkInAndOutHandler.Next = isAvailableHandler;
isAvailableHandler.Next = ısCountryTurkeyHandler;
ısCountryTurkeyHandler.Next = ısCountryItalyHandler;

checkOwnerHandler.Handler(reservationRequest);
