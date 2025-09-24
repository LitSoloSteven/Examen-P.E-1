using System;

class Program
{
    static int numeroOriginal = 0;

    static void Main(string[] args)
    {
        numeroOriginal = LeerEnteroDesdeConsola("Ingresa un número entero: ");
        int valorAbsoluto = numeroOriginal >= 0 ? numeroOriginal : -numeroOriginal;

        int numeroInvertido = InvertirNumero(valorAbsoluto);

        Console.WriteLine("Número original: " + numeroOriginal);
        Console.WriteLine("Número invertido: " + numeroInvertido);

        if (valorAbsoluto == numeroInvertido)
            Console.WriteLine("El número ES capicúa.");
        else
            Console.WriteLine("El número NO es capicúa.");
    }

    static int LeerEnteroDesdeConsola(string mensaje)
    {
        int valorLeido;
        while (true)
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine()??"";
            if (int.TryParse(entrada, out valorLeido)) break;
            Console.WriteLine("Entrada inválida. Debes ingresar un número entero.");
        }
        return valorLeido;
    }

    static int InvertirNumero(int numeroAInvertir)
    {
        int numeroResultado = 0;
        int numeroTemporal = numeroAInvertir;

        // caso especial: si numeroAInvertir == 0 -> devuelve 0
        if (numeroTemporal == 0) return 0;

        while (numeroTemporal > 0)
        {
            int digitoActual = numeroTemporal % 10;
            numeroResultado = (numeroResultado * 10) + digitoActual;
            numeroTemporal = numeroTemporal / 10;
        }

        return numeroResultado;
    }
}