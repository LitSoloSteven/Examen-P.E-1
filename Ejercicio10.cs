using System;

class Program
{
    // Variable global: guarda la puntuación del jugador
    static int puntuacion = 0;

    static void Main()
    {
        Console.WriteLine(" Juego de puntuación ");

        string opcion;
        do
        {
            Console.WriteLine("\nElige una opción:");
            Console.WriteLine("1 - Ganar puntos");
            Console.WriteLine("2 - Salir");
            Console.Write("Opción: ");
            opcion = Console.ReadLine();

            if (opcion == "1")
            {
                GanarPuntos(); // llamar al método que suma puntos
            }
            else if (opcion == "2")
            {
                Console.WriteLine("¡Juego terminado!");
            }
            else
            {
                Console.WriteLine("Error: opción no válida.");
            }

        } while (opcion != "2"); // repetir hasta que el usuario decida salir
    }

    // Método que aumenta la puntuación y la muestra
    static void GanarPuntos()
    {
        puntuacion += 10; // sumar 10 a la puntuación global
        Console.WriteLine($"Tu puntuación es: {puntuacion}");
    }
}

