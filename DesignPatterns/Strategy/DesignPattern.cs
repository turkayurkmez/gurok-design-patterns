using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	/*İçerisinde sıralama yaptığınız bir koleksiyonunuz var. Sıralaması algoritması değiştiğinde bu değişimi nasıl yöneteceğiz?*/

	public class Product
	{

	}

    public class  ProductCollection
    {
        public void Sort(ISortAlgorithm sortAlgorithm)
        {
            //bubble sort ile ürünler sıralanıyor.....
            sortAlgorithm.Sort();
        }
    }

    public interface ISortAlgorithm
    {
        void Sort();
    }

    public class BubbleSortAlgorithm : ISortAlgorithm
    {
        public void Sort()
        {
            Console.WriteLine("Bubble sort ile sıralandı");
        }
    }
    public class HeapSortAlgorithm : ISortAlgorithm
    {
        public void Sort()
        {
            Console.WriteLine("Heap sort ile sıralandı");
        }
    }
}
