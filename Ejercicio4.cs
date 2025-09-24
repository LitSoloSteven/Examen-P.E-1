using System;

class Program
{
    // Variable global para acumular la suma
    static double sumaTotal = 0;

    // Método que suma un número al acumulador global
    static void SumarNumero()
    {
        double numero;

        while (true)
        {
            Console.Write("Ingresa un número: ");
            string entrada = Console.ReadLine()??"";

            if (double.TryParse(entrada, out numero))
            {
                break; // Entrada válida
            }
            else
            {
                Console.WriteLine("Por favor ingresa un número válido.");
            }
        }

        // Sumar al total global
        sumaTotal += numero;

        Console.WriteLine("Suma acumulada: " + sumaTotal);
    }

    // Método principal
    static void Main()
    {
        // Preguntar al usuario si quiere empezar
        Console.Write("¿Deseas ingresar un número? (s/n): ");
        string respuesta = Console.ReadLine()??"";

        // Mientras el usuario diga "s", seguimos sumando
        while (respuesta.ToLower() == "s")
        {
            SumarNumero(); // Llamada a la función

            // Preguntar si quiere ingresar otro número
            Console.Write("¿Deseas ingresar otro número? (s/n): ");
            respuesta = Console.ReadLine()??"";
        }

        Console.WriteLine("La suma total final es: " + sumaTotal);
    }
}
