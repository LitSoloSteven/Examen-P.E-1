using System;

class Program
{
    // Variable global para acumular la suma
    static double sumaTotal = 0;

    // Método que suma un número al acumulador global
    static void SumarNumero()
    {
        double numero;

        Console.Write("Ingresa un número: ");
        string entrada = Console.ReadLine()??"";

        // Validar si es número
        if (!double.TryParse(entrada, out numero))
        {
            Console.WriteLine("¡Eso no es un número válido! Se reiniciará el programa.");
            return; // Salir del método para reiniciar el bucle principal
        }

        // Sumar al total global
        sumaTotal += numero;

        Console.WriteLine("Suma acumulada: " + sumaTotal);
    }

    // Método principal
    static void Main()
    {
        while (true) // Bucle principal que se repite mientras el usuario quiera
        {
            // Preguntar al usuario si quiere empezar
            Console.Write("¿Deseas ingresar un número? (s/n): ");
            string respuesta = Console.ReadLine()??"";

            if (respuesta.ToLower() == "s")
            {
                SumarNumero(); // Llamada a la función
            }
            else if (respuesta.ToLower() == "n")
            {
                Console.WriteLine("La suma total final es: " + sumaTotal);
                break; // Salir del programa
            }
            else
            {
                Console.WriteLine("Por favor ingresa 's' para sí o 'n' para no.");
            }

            Console.WriteLine(); // Línea en blanco
        }
    }
}
