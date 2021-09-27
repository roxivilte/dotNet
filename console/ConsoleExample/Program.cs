using System;

namespace ConsoleExample
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var p = new Perro();
            p.nombre = "Berlin";
            p.Saltar();
            p.Saludar();

            Animal b = new Ballena();
            b.nombre = "Wally";
            b.Saludar();

            //NameExtensions.ValidateName();
        }
    }
}
