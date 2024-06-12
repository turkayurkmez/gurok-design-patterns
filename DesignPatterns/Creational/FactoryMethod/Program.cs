// See https://aka.ms/new-console-template for more information
using FactoryMethod;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 *   Bir nesneyi oluştururken; o nesnenin sorumlu olduğu başka nesneleri de oluşturmak istiyorsunuz. Bu ihtiyacınızı nasıl giderirsiniz.
 *   
 */

CultureMapGenerator mapGenerator = new CultureMapGenerator();
mapGenerator.Show();


ReligionMapGenerator religionMap = new ReligionMapGenerator();
religionMap.Show();