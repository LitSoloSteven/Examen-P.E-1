using System;

class Program
{
    static void Main()
    {
        // Llamamos al método que calcula el promedio
        CalcularPromedio();
    }

    // Método para calcular el promedio de 3 notas
    static void CalcularPromedio()
    {
        // Variables locales (solo sirven aquí dentro)
        double nota1, nota2, nota3, promedio;

        Console.WriteLine("Calcular promedio de 3 notas (0 a 100)");

        // Pedir primera nota con validación
        Console.Write("Escribe la primera nota: ");
        nota1 = LeerNota();

        // Pedir segunda nota con validación
        Console.Write("Escribe la segunda nota: ");
        nota2 = LeerNota();

        // Pedir tercera nota con validación
        Console.Write("Escribe la tercera nota: ");
        nota3 = LeerNota();

        // Sacar el promedio
        promedio = (nota1 + nota2 + nota3) / 3;

        // Mostrar resultado
        Console.WriteLine($"El promedio es: {promedio}");
    }

    // Método para leer una nota válida
    static double LeerNota()
    {
        double nota;

        // Bucle hasta que la nota sea válida
        while (true)
        {
            string entrada = Console.ReadLine();

            // Validar si es número
            if (!double.TryParse(entrada, out nota))
            {
                Console.Write("Error: escribe un número válido: ");
                continue;
            }

            // Validar rango entre 0 y 100
            if (nota < 0 || nota > 100)
            {
                Console.Write("Error: la nota debe estar entre 0 y 100: ");
                continue;
            }

            // Si todo está bien, salimos del ciclo
            break;
        }

        return nota;
    }
}
