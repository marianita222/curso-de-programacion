using System;

public class Program
{
    public static void Main()
    {
        // Llamamos al método para imprimir la tabla del 7
        ImprimirTablaDel7();
    }
    
    public static void ImprimirTablaDel7()
    {
        Console.WriteLine("Tabla de multiplicar del 7:");
        
        for (int i = 1; i <= 10; i++)
        {
            int resultado = 7 * i;
            Console.WriteLine($"7 x {i} = {resultado}");
        }
    }
}