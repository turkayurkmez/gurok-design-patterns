using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /*
	 * Bellekte bir kelime koleksiyonunuz var. Kelimeler üzerinde navigasyon yapacağız.
	 */
    public class IteratorClass : IEnumerator<string>
    {
        private readonly List<string> words;

        int position = 0;
        public IteratorClass(List<string> words)
        {
            this.words = words;
        }

        public string Current => words[position];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            position++;
            return position < words.Count;
        }

        public void Reset()
        {
            position = 0;
        }
        public void First()
        {
            position = 0;
        }
        public void Last()
        {
            position = words.Count -1;
        }
    }



}
