using System;

class Program
{
    static void Main()
    {
        double radio;

        // Pedir radio con validación
        while (true)
        {
            Console.Write("Escribe el radio (mayor que 0): ");
            if (!double.TryParse(Console.ReadLine(), out radio) || radio <= 0)
            {
                Console.WriteLine("Error: escribe un número mayor que 0.");
                continue;
            }
            break;
        }

        // Calcular y mostrar perímetro directamente
        Console.WriteLine($"El perímetro del círculo es: {CalcularPerimetro(radio)}");
    }

    // Método que recibe el radio y devuelve el perímetro
    static double CalcularPerimetro(double radio)
    {
        return 2 * Math.PI * radio; // retornamos directamente sin variable extra
    }
}

