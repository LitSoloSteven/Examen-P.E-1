using System;

class Program
{
    // Variable global: guarda los intentos del jugador
    static int intentos = 0;

    static void Main()
    {
        Random rnd = new Random(); // sirve para generar un número al azar
        int numeroSecreto = rnd.Next(1, 101); // número secreto entre 1 y 100
        bool adivinado = false; // controla si ya se acertó

        Console.WriteLine("Juego: Adivina el número (1 al 100)");

        while (!adivinado) // se repite hasta que adivine
        {
            Console.Write("Escribe tu intento: ");
            string entrada = Console.ReadLine(); // lo que escribe el jugador

            int numeroUsuario;

            // Validar si realmente es un número
            if (!int.TryParse(entrada, out numeroUsuario))
            {
                Console.WriteLine("Error: solo puedes escribir números.");
                continue; // vuelve a pedir
            }

            // Validar que el número esté entre 1 y 100
            if (numeroUsuario < 1 || numeroUsuario > 100)
            {
                Console.WriteLine("Error: el número debe estar entre 1 y 100.");
                continue;
            }

            intentos++; // sumamos cada intento
            Console.WriteLine($"Intento #{intentos}: escribiste {numeroUsuario}");

            // Comparar con el secreto
            if (numeroUsuario == numeroSecreto)
            {
                Console.WriteLine($"¡Ganaste! Lo lograste en {intentos} intentos.");
                adivinado = true; // termina el juego
            }
            else if (numeroUsuario < numeroSecreto)
            {
                Console.WriteLine("El número secreto es más grande.");
            }
            else
            {
                Console.WriteLine("El número secreto es más pequeño.");
            }
        }

        Console.WriteLine("Fin del juego.");
    }
}

