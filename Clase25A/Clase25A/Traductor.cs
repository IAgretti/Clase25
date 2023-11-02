using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase25A
{
    public abstract class Traductor
    {
        public abstract string Lenguaje();
        public void Print()
        {
            Console.WriteLine("Soy traductor de: " + Lenguaje());
        }
    }
    public class AlemanT: Traductor
    {
        public override string Lenguaje()
        {
            return "Alemán!";
        }
    }
    public class InglesT: Traductor
    {
        public override string Lenguaje()
        {
            return "Inglés";
        }
    }
    public class FrancesT: Traductor
    {
        public override string Lenguaje()
        {
            return "Francés!";
        }
    }
}
