using System;

public class Program
{
    public static void Main()
    {
        // Ejemplos de uso
        VerificarNumero(5);
        VerificarNumero(-3);
        VerificarNumero(0);
    }
    
    public static void VerificarNumero(int numero)
    {
        if (numero > 0)
        {
            Console.WriteLine($"El número {numero} es positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine($"El número {numero} es negativo.");
        }
        else
        {
            Console.WriteLine($"El número es cero.");
        }
    }
}