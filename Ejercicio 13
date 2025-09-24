using System;

public class JuegoAdivinanza
{
    private int numeroSecreto;
    private int intentos;

    public JuegoAdivinanza()
    {
        Random rnd = new Random();
        numeroSecreto = rnd.Next(1, 101);
        intentos = 0;
    }

    public int ObtenerNumeroValidado()
    {
        int numero;

        while (true)
        {
            Console.Write("Adivina el numero (entre 1 y 100): ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out numero))
            {
                if (numero >= 1 && numero <= 100)
                {
                    return numero;
                }
                else
                {
                    Console.WriteLine("El numero debe estar entre 1 y 100. Intentalo de nuevo.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no valida. Por favor, introduce un numero.");
            }
        }
    }

    public void ComprobarAdivinanza(int numeroUsuario)
    {
        intentos++;

        if (numeroUsuario == numeroSecreto)
        {
            Console.WriteLine($"Felicidades. Adivinaste el numero en {intentos} intentos.");
        }
        else if (numeroUsuario > numeroSecreto)
        {
            Console.WriteLine("Demasiado alto. Intentalo de nuevo.");
        }
        else
        {
            Console.WriteLine("Demasiado bajo. Intentalo de nuevo.");
        }
    }
    
    public bool HaAdivinado(int numeroUsuario)
    {
        return numeroUsuario == numeroSecreto;
    }
}

class Program
{
    static void Main(string[] args)
    {
        JuegoAdivinanza miJuego = new JuegoAdivinanza();
        int adivinanzaUsuario;

        Console.WriteLine("Bienvenido al Juego de Adivinanza Mejorado.");

        do
        {
            adivinanzaUsuario = miJuego.ObtenerNumeroValidado();
            miJuego.ComprobarAdivinanza(adivinanzaUsuario);
        } while (!miJuego.HaAdivinado(adivinanzaUsuario));

        Console.ReadKey();
    }
}
