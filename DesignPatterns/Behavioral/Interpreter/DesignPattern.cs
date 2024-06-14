using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterSample
{


    /*
     *        Birler   Onlar    Yüzler   Binler  
     *Bir      I        X        C        M
     *Dört     IV       XL       CD      
     *Beş      V        L        D
     *Dokuz    IX       XC       CM
     */

    public class Interpreter
    {
        public string Input { get; set; }
        public int Output { get; set; }

        public Interpreter(string input)
        {
            Input = input;
        }

    }

    public abstract class Level
    {
        public abstract string One();
        public abstract string Four();
        public abstract string Five();
        public abstract string Nine();

        public abstract int Multiply();
        public void Convert(Interpreter interpreter)
        {
            if (interpreter.Input.Length == 0)
            {
                return;
            }

            if (interpreter.Input.StartsWith(Nine()))
            {
                interpreter.Output += 9 * Multiply();
                interpreter.Input = interpreter.Input.Substring(2);
            }

            if (interpreter.Input.StartsWith(Four()))
            {
                interpreter.Output += 4 * Multiply();
                interpreter.Input = interpreter.Input.Substring(2);

            }

            if (interpreter.Input.StartsWith(Five()))
            {
                interpreter.Output += 5 * Multiply();
                interpreter.Input = interpreter.Input.Substring(1);
            }

            while (interpreter.Input.StartsWith(One()))
            {
                interpreter.Output += 1 * Multiply();
                interpreter.Input = interpreter.Input.Substring(1);
            }


        }



    }

    public class LevelOne : Level
    {
        public override string Five()
        {
            return "V";
        }

        public override string Four()
        {
            return "IV";
        }

        public override int Multiply()
        {
            return 1;
        }

        public override string Nine()
        {
            return "IX";
        }

        public override string One()
        {
            return "I";
        }
    }

    public class LevelTen : Level
    {
        public override string Five()
        {
            return "L";
        }

        public override string Four()
        {
            return "XL";
        }

        public override int Multiply()
        {
            return 10;
        }

        public override string Nine()
        {
            return "XC";
        }

        public override string One()
        {
            return "X";
        }
    }

    public class LevelHundred : Level
    {
        public override string Five()
        {
            return "D";
        }

        public override string Four()
        {
            return "CD";
        }

        public override int Multiply()
        {
            return 100;

        }

        public override string Nine()
        {
            return "CM";
        }

        public override string One()
        {
            return "C";
        }
    }

    public class LevelThousand : Level
    {
        public override string Five()
        {
            return " ";
        }

        public override string Four()
        {
            return " ";

        }

        public override int Multiply()
        {
            return 1000;
        }

        public override string Nine()
        {
            return " ";

        }

        public override string One()
        {
            return "M";
        }
    }
}
