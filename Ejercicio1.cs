using System;

class Program
{
    // Variable global
    static int contador = 0;

    static void Main()
    {
        // Llamamos varias veces al método para probar
        ContadorAccesos();
        ContadorAccesos();
        ContadorAccesos();
    }

    static void ContadorAccesos()
    {
        // Incrementamos el contador global
        contador++;

        // Mostramos el valor actual
        Console.WriteLine("El método se ha ejecutado " + contador + " veces.");
    }
}
