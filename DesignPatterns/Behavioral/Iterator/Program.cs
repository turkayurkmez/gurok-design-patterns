// See https://aka.ms/new-console-template for more information
using Iterator;

Console.WriteLine("Hello, World!");
//Problem: Bellekteki bir koleksiyon içinde navigasyon yapmanız gerek (ileri, geri, başa dön veya sona git). Bu nedenle iterator kullanılmalısınız.

var words = new List<string>() { "A","B","C","D","E","F"};
//var items = words.Skip(3).Take(2).ToList();
//var rangeItems = words[^1];

IteratorClass iteratorClass = new IteratorClass(words);

var current = iteratorClass.Current;
Console.WriteLine(current);
while (iteratorClass.MoveNext())
{
    Console.WriteLine(iteratorClass.Current);
}

iteratorClass.First();
Console.WriteLine(iteratorClass.Current);
iteratorClass.Last();
Console.WriteLine(iteratorClass.Current);






