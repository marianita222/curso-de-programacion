using System;

public class Program
{
    public static void Main()
    {
        CalcularSuma1Al100();
    }
    
    public static void CalcularSuma1Al100()
    {
        int suma = 0; // Inicializamos la variable para acumular la suma
        
        for (int i = 1; i <= 100; i++)
        {
            suma += i; // Equivalente a: suma = suma + i;
        }
        
        Console.WriteLine($"La suma de los números del 1 al 100 es: {suma}");
    }
}