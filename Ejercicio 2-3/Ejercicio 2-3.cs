using System;
using System.Collections.Generic;
using System.Linq;

class Estudiante
{
    public string Nombre;
    public string Apellido;
    public double N1, N2, N3, N4;
    public double Promedio;
    public char Literal;
}

class Ejercicio2
{
    static void Main()
    {
        List<Estudiante> lista = new List<Estudiante>();
        string continuar = "S";

        Console.WriteLine("==========================================================");
        Console.WriteLine("           Colegio Dios es bueno. Calificaciones           ");
        Console.WriteLine("==========================================================");

        while (continuar.ToUpper() == "S")
        {
            Estudiante e = new Estudiante();

            Console.Write("\nNombre: ");
            e.Nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            e.Apellido = Console.ReadLine();

            Console.Write("Nota 1: ");
            e.N1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2: ");
            e.N2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3: ");
            e.N3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 4: ");
            e.N4 = Convert.ToDouble(Console.ReadLine());

            e.Promedio = (e.N1 + e.N2 + e.N3 + e.N4) / 4.0;

            if (e.Promedio >= 90 && e.Promedio <= 100)
                e.Literal = 'A';
            else if (e.Promedio >= 80)
                e.Literal = 'B';
            else if (e.Promedio >= 70)
                e.Literal = 'C';
            else
                e.Literal = 'F';

            lista.Add(e);

            Console.Write("\n¿Desea ingresar otro estudiante? (S/N): ");
            continuar = Console.ReadLine();
        }

   
        var ordenada = lista.OrderBy(x => x.Apellido).ToList();

        Console.WriteLine("\n==========================================================");
        Console.WriteLine("Nombre\tApellido\tNota1\tNota2\tNota3\tNota4\tPromedio\tLiteral");
        Console.WriteLine("==========================================================");

        foreach (var e in ordenada)
        {
            Console.WriteLine($"{e.Nombre}\t{e.Apellido}\t\t{e.N1}\t{e.N2}\t{e.N3}\t{e.N4}\t{e.Promedio:F1}\t\t{e.Literal}");
        }

        Console.WriteLine("\n==========================================================");
        Console.WriteLine("Estudiantes en A: " + lista.Count(x => x.Literal == 'A'));
        Console.WriteLine("Estudiantes en B: " + lista.Count(x => x.Literal == 'B'));
        Console.WriteLine("Estudiantes en C: " + lista.Count(x => x.Literal == 'C'));
        Console.WriteLine("Estudiantes Reprobados: " + lista.Count(x => x.Literal == 'F'));
        Console.WriteLine("==========================================================");
    }
}
