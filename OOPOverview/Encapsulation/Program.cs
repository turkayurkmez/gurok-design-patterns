// See https://aka.ms/new-console-template for more information
using Encapsulation;

Console.WriteLine("Hello, World!");

Product product = new Product();
Console.WriteLine("Fiyat Giriniz");
var value = int.Parse(Console.ReadLine());
//if (value < 0)
//{
//    throw new Exception();
//}
product.SetPrice(value);
Console.WriteLine(product.Stock);

