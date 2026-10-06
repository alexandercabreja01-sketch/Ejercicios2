using System;

class Ejercicio1
{
    static void Main()
    {
        Console.Write("Ingrese el primer valor: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo valor: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n================ RESULTADOS ================");
        Console.WriteLine($"Suma: {num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"Resta: {num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"Multiplicación: {num1} * {num2} = {num1 * num2}");

        if (num2 != 0)
            Console.WriteLine($"División: {num1} / {num2} = {num1 / num2}");
        else
            Console.WriteLine("División: No se puede dividir entre cero.");

        if (num1 >= 0)
            Console.WriteLine($"Raíz cuadrada del primer valor ({num1}): {Math.Sqrt(num1):F2}");
        else
            Console.WriteLine($"Raíz cuadrada del primer valor ({num1}): No definida en números reales.");

        if (num2 >= 0)
            Console.WriteLine($"Raíz cuadrada del segundo valor ({num2}): {Math.Sqrt(num2):F2}");
        else
            Console.WriteLine($"Raíz cuadrada del segundo valor ({num2}): No definida en números reales.");
    }
}
