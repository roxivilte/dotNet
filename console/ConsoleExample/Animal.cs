using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExample
{
    public abstract class Animal
    {
        public string nombre;
        public Animal()
        {
            
        }
        public Animal (string nombre)
        {
            this.nombre = nombre;
            Console.WriteLine("- Animal(string)");
        }
        public virtual void Saludar()
        {
            Console.WriteLine($"El animal {nombre} saluda");
        }
        public void Comer()
        {
            Console.WriteLine($"El animal {nombre} come");
        }
    }
}
