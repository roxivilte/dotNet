using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExample
{
    public class Ballena:Animal
    {
        public Ballena() { }

        public override void Saludar()
        {
            Console.WriteLine($"{nombre} esta saludando");
        }
    }
}
