using System;

namespace ConsoleExample
{
    public static class NameExtensions
    {
        public static void AskName()
        {
            Console.WriteLine("Escribe tu nombre:");
        }

        public static bool ValidateName()
        {
            Console.WriteLine("Escribe tu nombre:");
            var name = Console.ReadLine();
            if (!String.IsNullOrEmpty(name))
            {
                Console.WriteLine($"Hola {name}");
                return true;
            }
            return ValidateName();
        }
    }
}
