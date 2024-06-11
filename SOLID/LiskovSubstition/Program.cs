// See https://aka.ms/new-console-template for more information
using LiskovSubstition;

Console.WriteLine("Hello, World!");

//Square square = new Square();
//square.Width = 15;
//Console.WriteLine(square.GetArea()) ;
var rectangle = Geometry.GetRectangle(5);
//rectangle.Width = 5;
//rectangle.Height = 10;

Console.WriteLine(rectangle.GetArea());

/*
 * Miras alan nesne; veren nesnenin davranışını değiştirmemeli.
 * 
 */