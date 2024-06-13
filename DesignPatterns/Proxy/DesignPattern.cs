using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface IMath
    {
        int Division(int x, int y);

    }

    public class Math : IMath
    {
        public int Division(int x, int y)
        {
            return x / y;
        }
    }
    public class MathProxy : IMath
    {
        private readonly IMath _math;

        public MathProxy(IMath math)
        {
            _math = math;
        }

        public int Division(int x, int y)
        {
            //Eğer business kuralına uymazsanız; hatayı MathProxy verecek. Sorun yoksa math nesnesine gönderecek.
            if (y == 0)
            {
                throw new ArgumentException("Tam sayılar 0'a bölünemez!");
            }
            return _math.Division(x, y);
        }
    }
}
