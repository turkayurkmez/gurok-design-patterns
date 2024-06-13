// See https://aka.ms/new-console-template for more information
using Facade;

Console.WriteLine("Hello, World!");
/*
 * Çok fazla nesne kullanarak çok karmaşık işler yapmanız gereken bir senaryonuz var. Geliştiricinin en kolay biçimde bu işlemi yapması için ne yapmalısınız?
 */

OrderService orderService = new OrderService();
var cardItems = new List<CardItem>()
{
    new(){ ProductId=1, Quantity = 8},
    new(){ ProductId=2, Quantity = 5}

};

orderService.CreateOrder("Türkay", cardItems);