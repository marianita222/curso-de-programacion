using System;

namespace PersonasEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            mariana();
            julio();
            elio();
            dickson();

            Console.ReadKey();
        }

        public static void mariana()
        {
            Console.WriteLine("\n\n--- Mariana ---");
            int edad = 21;
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Hobby: Hacer galletas");
        }

        public static void julio()
        {
            Console.WriteLine("\n\n--- Julio ---");
            int edad = 18;
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("comer");
        }

        public static void elio ()
        {
            Console.WriteLine("\n\n--- elio ---");
            int edad = 7;
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("le gusta chupar");
        }

        public static void dickson()
        {
            Console.WriteLine("\n\n--- dickson ---");
            int edad = 30;
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("no hace falta decir que le gusta");
        }
    }
}

