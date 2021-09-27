using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExample
{
    public class Perro:Animal
    {
        public Perro() { }

        public override void Saludar()
        {
            Console.WriteLine($"{nombre} saluda");

        }
        public void Saltar()
        {
            Console.WriteLine($"{nombre} salta");

        }
    }

}
