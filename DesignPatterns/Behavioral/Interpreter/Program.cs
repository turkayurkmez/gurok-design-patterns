// See https://aka.ms/new-console-template for more information
using InterpreterSample;




Console.WriteLine("Hello, World!");
Console.WriteLine("Bir roma rakamı giriniz");
string input = Console.ReadLine();
Interpreter interpreter = new Interpreter(input);


/*
 *   Belirli bir algoritma (ancak iyi tanımlanmış sabit bir grameri olan bir dili olmalı) ile oluşturulmuş bir girdiyi
 *   Başka bir formattaki çıktıya çeviren pattern.
 *   
 */

List<Level> levels = new List<Level>
{
    new LevelThousand(),
    new LevelHundred(),
    new LevelTen(),
    new LevelOne()
};

foreach (var item in levels)
{
    item.Convert(interpreter);
}

Console.WriteLine(interpreter.Output);





