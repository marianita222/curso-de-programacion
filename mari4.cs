using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear una lista de strings con tu información
        List<string> miInformacion = new List<string> { "mariana", "quintero", "21" }; 
        
        
        miInformacion.Add("daniele");
        miInformacion.Add("espitia");
        miInformacion.Add("25"); 

      
        Console.WriteLine("Elementos en la lista:");
        foreach (var item in miInformacion)
        {
            Console.WriteLine(item);
        }
    }
}