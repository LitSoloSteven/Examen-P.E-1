using System;

class Program
{
    // Variable global: controla si la sesión está iniciada o no
    static bool sesionIniciada = false;

    static void Main()
    {
        Console.WriteLine(" Simulación de inicio de sesión ");

        // Pedir contraseña al usuario
        Console.Write("Escribe la contraseña: ");
        string password = Console.ReadLine();

        // Validar que no esté vacío
        if (string.IsNullOrWhiteSpace(password))
        {
            Console.WriteLine("Error: no puedes dejar la contraseña vacía.");
        }
        // Validar si es la correcta
        else if (password == "1234") // contraseña definida
        {
            sesionIniciada = true; // se cambia a true
            Console.WriteLine(" Sesión iniciada correctamente.");
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta.");
        }

        // Mostrar el estado final de la sesión
        Console.WriteLine($"Estado de la sesión: {sesionIniciada}");
    }
}
