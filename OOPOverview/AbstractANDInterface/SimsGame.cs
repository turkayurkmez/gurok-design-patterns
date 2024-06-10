using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractANDInterface
{
    public interface IKiyafet
    {

    }
    public abstract class UstGiyim : IKiyafet
    {

    }
    public class Kazak : UstGiyim { }
    public class KirmiziKazak: Kazak
    {

    }
    public class Oyuncu
    {
        public void Giy(IKiyafet giyim)
        {

        }
    }
}
