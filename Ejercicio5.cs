using System;

class Program
{
    static void Main()
    {
        CalcularEdad(); // Llamamos al método
    }

    static void CalcularEdad()
    {
        int anioNacimiento;
        int anioActual = DateTime.Now.Year; // Año actual

        // Pedir el año de nacimiento con validación
        while (true)
        {
            Console.Write("Ingresa tu año de nacimiento: ");
            string entrada = Console.ReadLine()??"";

            // Validar que sea número y esté entre 1 y el año actual
            if (int.TryParse(entrada, out anioNacimiento) &&
                anioNacimiento > 1901 &&
                anioNacimiento <= anioActual)
            {
                break; // Entrada válida
            }
            else
            {
                Console.WriteLine($"Por favor ingresa un año válido entre 1902 y {anioActual}.");
            }
        }

        // Calcular edad
        int edad = anioActual - anioNacimiento;

        // Mostrar resultado
        Console.WriteLine("Tu edad es: " + edad + " años.");
    }
}