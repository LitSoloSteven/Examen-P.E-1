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

        // Definir rangos según escala
        double minTemp, maxTemp;
        if (escala == "C")
        {
            minTemp = -273.15; //  límite mínimo
            maxTemp = 1.417e32;  // Límite superior
        }
        else
        {
            minTemp = 1.8*(-273.15); // Equivalente en °F
            maxTemp = 1.417e32*(9/5)+32;  // Equivalente en °F
        }

        // Pedir la temperatura con validación
        while (true)
        {
            Console.Write($"Ingresa la temperatura a convertir ({minTemp:F2} a {maxTemp:F2}): ");
            string entrada = Console.ReadLine()??"";

            if (double.TryParse(entrada, out temperatura))
            {
                if (temperatura >= minTemp && temperatura <= maxTemp)
                {
                    break; // Entrada válida
                }
                else
                {
                    Console.WriteLine($"Por favor ingresa un número dentro del rango {minTemp:F2} a {maxTemp:F2}.");
                }
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
            Console.WriteLine($"{temperatura}°C = {resultado:F2}°F");
        }
        else if (escala == "F")
        {
            resultado = (temperatura - 32) * 5 / 9;
            Console.WriteLine($"{temperatura}°F = {resultado:F2}°C");
        }
    }
}
