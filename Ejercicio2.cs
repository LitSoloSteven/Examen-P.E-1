using System;

class Program
{
    static void Main()
    {
        CalcularAreaRectangulo(); // Llamamos al método
    }

    static void CalcularAreaRectangulo()
    {
        double baseRectangulo;
        double alturaRectangulo;

        // Pedir la base y validar
        while (true)
        {
            Console.Write("Ingresa la base del rectángulo (mayor que 0): ");
            string entrada = Console.ReadLine()??"";

            if (double.TryParse(entrada, out baseRectangulo) && baseRectangulo > 0)
            {
                break; // Entrada válida
            }
            else
            {
                Console.WriteLine("Por favor ingresa un número válido mayor que 0.");
            }
        }

        // Pedir la altura y validar
        while (true)
        {
            Console.Write("Ingresa la altura del rectángulo (mayor que 0): ");
            string entrada = Console.ReadLine()??"";

            if (double.TryParse(entrada, out alturaRectangulo) && alturaRectangulo > 0)
            {
                break; // Entrada válida
            }
            else
            {
                Console.WriteLine("Por favor ingresa un número válido mayor que 0.");
            }
        }

        // Variable local para el área
        double area = baseRectangulo * alturaRectangulo;

        // Mostrar el resultado
        Console.WriteLine("El área del rectángulo es: " + area);
    }
}
