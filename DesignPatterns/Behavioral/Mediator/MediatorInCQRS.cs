using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public interface ISQLCommand
    {

    }
    public class CreateNewProductCommand : ISQLCommand
    {

    }


    public class MediatorForSQL
    {

        public  ISQLCommand Command { private get; set; }

        public void Handle(CrateNewProductCommandHandler handler)
        {

            handler.Handle(Command);
        }
    }

    public class CrateNewProductCommandHandler
    {
        public void Handle(ISQLCommand command)
        {
            Console.WriteLine("Ürün Eklendi");
        }
    }
}
