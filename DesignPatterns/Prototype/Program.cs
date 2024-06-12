// See https://aka.ms/new-console-template for more information
using Prototype;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 * Bellekte oluşturulması çok zaman alan bir nesneniz var. Ama aynısından bir kaç tane kullanmanız gerek. İlki hariç diğerlerinin hiç zaman almaması için yapabileceğimiz bir şey var mı?
 * 
 */

string[] letters = { "A", "B", "C", "D" };
var cloneLetters = (string[]) letters.Clone();
cloneLetters[0] = "F";

Chair chair1 = new Chair();
Console.WriteLine(chair1);
Chair chair2 = (Chair)chair1.Clone(true);
chair2.No = 2;
chair2.Cinema.Movie = "Poor Things";
Console.WriteLine(chair2);
Chair chair3 = (Chair)chair1.Clone();
chair3.No = 3;
Console.WriteLine(chair3);

Console.WriteLine($"DİKKAT Chair1 nesnesi: {chair1}");

