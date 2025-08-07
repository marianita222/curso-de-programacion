using System;

public class Program
{
    public static void Main()
    {
        // Ejemplos de uso
        CalcularOperacion(5.5, 2.0, '+');
        CalcularOperacion(10.0, 4.0, '-');
        CalcularOperacion(3.0, 2.5, '*');
        CalcularOperacion(8.0, 2.0, '/');
        CalcularOperacion(5.0, 0.0, '/');
        CalcularOperacion(7.0, 3.0, '%');
    }

    public static void CalcularOperacion(double num1, double num2, char operador)
    {
        double resultado;
        bool operacionValida = true;
        string mensajeError = "";

        switch (operador)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                }
                else
                {
                    operacionValida = false;
                    mensajeError = "Error: División por cero no permitida.";
                }
                break;
            default:
                operacionValida = false;
                mensajeError = $"Error: Operador '{operador}' no válido. Use +, -, * o /.";
                break;
        }

        if (operacionValida)
        {
            Console.WriteLine($"{num1} {operador} {num2} = {num1 + operador + num2}");
        }
        else
        {
            Console.WriteLine(mensajeError);
        }
    }
}