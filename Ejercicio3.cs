using System;

class Program
{
    // Variable global que indica la escala de conversión
    static string escala;

    static void Main()
    {
        // Elegir la escala
        while (true)
        {
            Console.WriteLine("Elige la escala de conversión:");
            Console.WriteLine("1 - Celsius a Fahrenheit");
            Console.WriteLine("2 - Fahrenheit a Celsius");
            Console.Write("Opción: ");
            string opcion = Console.ReadLine()??"";

            if (opcion == "1")
            {
                escala = "C";
                break;
            }
            else if (opcion == "2")
            {
                escala = "F";
                break;
            }
            else
            {
                Console.WriteLine("Por favor ingresa una opción válida (1 o 2).");
            }
        }

        // Llamamos al método de conversión
        ConvertirTemperatura();
    }

    static void ConvertirTemperatura()
    {
        double temperatura;

        // Pedir la temperatura con validación
        while (true)
        {
            Console.Write("Ingresa la temperatura a convertir: ");
            string entrada = Console.ReadLine()??"";

            if (double.TryParse(entrada, out temperatura))
            {
                break;
            }
            else
            {
                Console.WriteLine("Por favor ingresa un número válido.");
            }
        }

        double resultado = 0;

        // Usamos la variable global para decidir la conversión
        if (escala == "C")
        {
            resultado = (temperatura * 9 / 5) + 32;
            Console.WriteLine($"{temperatura}°C = {resultado}°F");
        }
        else if (escala == "F")
        {
            resultado = (temperatura - 32) * 5 / 9;
            Console.WriteLine($"{temperatura}°F = {resultado}°C");
        }
    }
}
