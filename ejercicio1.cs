using System;

public class Program
{
    public static void Main()
    {
        // Ejemplo de uso del método
        DeterminarParImpar(5);
        DeterminarParImpar(10);
    }
    
    public static void DeterminarParImpar(int numero)
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine($"El número {numero} es par");
        }
        else
        {
            Console.WriteLine($"El número {numero} es impar");
        }
    }
}