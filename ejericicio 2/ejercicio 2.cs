using System;

class Ejercicio2
{
    static void Main()
    {
        string continuar = "S";

        Console.WriteLine("==========================================================");
        Console.WriteLine("           Colegio Dios es bueno. Calificaciones           ");
        Console.WriteLine("==========================================================");

        while (continuar.ToUpper() == "S")
        {
            Console.Write("\nNombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Nota 1: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3: ");
            double n3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 4: ");
            double n4 = Convert.ToDouble(Console.ReadLine());

            double promedio = (n1 + n2 + n3 + n4) / 4.0;
            char literal;

            if (promedio >= 90 && promedio <= 100)
                literal = 'A';
            else if (promedio >= 80)
                literal = 'B';
            else if (promedio >= 70)
                literal = 'C';
            else
                literal = 'F';

            Console.WriteLine("\n==========================================================");
            Console.WriteLine("Nombre\tApellido\tNota1\tNota2\tNota3\tNota4\tPromedio\tLiteral");
            Console.WriteLine("==========================================================");
            Console.WriteLine($"{nombre}\t{apellido}\t{n1}\t{n2}\t{n3}\t{n4}\t{promedio:F1}\t\t{literal}");

            Console.Write("\n¿Desea ingresar otro estudiante? (S/N): ");
            continuar = Console.ReadLine();
        }
    }
}
