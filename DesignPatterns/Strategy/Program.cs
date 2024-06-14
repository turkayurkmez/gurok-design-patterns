// See https://aka.ms/new-console-template for more information
using Strategy;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 *   Bir iş için yazdığınız bir algoritmanın değişmesi gerekirse; minimum kod değişikliğiyle bu güncellemeyi nasıl yaparsınız?
 */

ProductCollection productCollection = new ProductCollection();
productCollection.Sort(new BubbleSortAlgorithm());  
productCollection.Sort(new HeapSortAlgorithm());    