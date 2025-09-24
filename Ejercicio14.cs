using System;
using System.Collections.Generic;
using System.Linq;

public class NotasEstudiantes
{
    private List<double> notas = new List<double>();

    public double ObtenerNotaValidada()
    {
        double nota; // Aquí la variable está declarada pero sin valor.

        while (true)
        {
            Console.Write("Por favor, introduce una nota (0-100): ");
            string entrada = Console.ReadLine();

            if (double.TryParse(entrada, out nota))
            {
                if (nota >= 0 && nota <= 100)
                {
                    return nota; // Retorna el valor y sale del metodo
                }
                else
                {
                    Console.WriteLine("La nota debe estar entre 0 y 100. Por favor, intentalo de nuevo.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no valida. Por favor, introduce un numero.");
            }
        }
    }

    public void AgregarNota(double nota)
    {
        notas.Add(nota);
        Console.WriteLine($"Nota de {nota} agregada con exito.");
    }
    
    public double CalcularPromedio()
    {
        if (notas.Count == 0)
        {
            Console.WriteLine("No hay notas para calcular el promedio.");
            return 0;
        }

        double sumaNotas = 0;
        foreach (double n in notas)
        {
            sumaNotas += n;
        }
        return sumaNotas / notas.Count;
    }
    
    public void MostrarExtremos()
    {
        if (notas.Count == 0)
        {
            Console.WriteLine("No hay notas para mostrar.");
            return;
        }

        double notaMasAlta = notas.Max();
        double notaMasBaja = notas.Min();

        Console.WriteLine($"La nota mas alta es: {notaMasAlta}");
        Console.WriteLine($"La nota mas baja es: {notaMasBaja}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        NotasEstudiantes miGestion = new NotasEstudiantes();

        Console.WriteLine("Vamos a agregar 3 notas.");
        for (int i = 0; i < 3; i++)
        {
            double notaValida = miGestion.ObtenerNotaValidada();
            miGestion.AgregarNota(notaValida);
        }

        Console.WriteLine("\n--- Resultados ---");
        double promedioActual = miGestion.CalcularPromedio();
        Console.WriteLine($"El promedio de las notas es: {promedioActual:F2}");
        
        miGestion.MostrarExtremos();

        Console.ReadKey();
    }
}
