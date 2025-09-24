using System;

class Program
{
    static void Main(string[] args)
    {
        string contrasenaIngresada = "";

        // Repetir hasta que la contraseña cumpla todos los requisitos
        while (true)
        {
            Console.Write("Ingresa una contraseña : ");
            contrasenaIngresada = Console.ReadLine() ?? "";

            if (contrasenaIngresada == "")
            {
                Console.WriteLine("No ingresaste nada. Intenta de nuevo.");
                continue;
            }

            int resultadoValidacion = EsContrasenaValida(contrasenaIngresada);
            if (resultadoValidacion == 1)
            {
                Console.WriteLine("La contraseña es válida.");
                break; // salir del loop porque ya es válida
            }
            else
            {
                Console.WriteLine("La contraseña NO cumple todos los requisitos. Intenta de nuevo.");
                Console.WriteLine("Criterios faltantes:");
                if (VerificarLongitud(contrasenaIngresada) == 0) Console.WriteLine("- Longitud >= 8");
                if (VerificarMayuscula(contrasenaIngresada) == 0) Console.WriteLine("- Al menos una mayúscula");
                if (VerificarMinuscula(contrasenaIngresada) == 0) Console.WriteLine("- Al menos una minúscula");
                if (VerificarNumero(contrasenaIngresada) == 0) Console.WriteLine("- Al menos un número");
                if (VerificarEspecial(contrasenaIngresada) == 0) Console.WriteLine("- Al menos un carácter especial (!@#$%^&*)");

            }
        }
    }

    static int EsContrasenaValida(string contrasena)
    {
        int cumpleLongitud = VerificarLongitud(contrasena);
        int cumpleMayuscula = VerificarMayuscula(contrasena);
        int cumpleMinuscula = VerificarMinuscula(contrasena);
        int cumpleNumero = VerificarNumero(contrasena);
        int cumpleEspecial = VerificarEspecial(contrasena);

        if (cumpleLongitud == 1 && cumpleMayuscula == 1 && cumpleMinuscula == 1 && cumpleNumero == 1 && cumpleEspecial == 1)
            return 1;
        return 0;
    }

    static int VerificarLongitud(string contrasena)
    {
        if (contrasena.Length >= 8) return 1;
        return 0;
    }

    static int VerificarMayuscula(string contrasena)
    {
        for (int posicionCaracter = 0; posicionCaracter < contrasena.Length; posicionCaracter++)
        {
            char caracterActual = contrasena[posicionCaracter];
            if (caracterActual >= 'A' && caracterActual <= 'Z') return 1;
        }
        return 0;
    }

    static int VerificarMinuscula(string contrasena)
    {
        for (int posicionCaracter = 0; posicionCaracter < contrasena.Length; posicionCaracter++)
        {
            char caracterActual = contrasena[posicionCaracter];
            if (caracterActual >= 'a' && caracterActual <= 'z') return 1;
        }
        return 0;
    }

    static int VerificarNumero(string contrasena)
    {
        for (int posicionCaracter = 0; posicionCaracter < contrasena.Length; posicionCaracter++)
        {
            char caracterActual = contrasena[posicionCaracter];
            if (caracterActual >= '0' && caracterActual <= '9') return 1;
        }
        return 0;
    }

    static int VerificarEspecial(string contrasena)
    {
        string caracteresEspeciales = "!@#$%^&*";
        for (int posicionCaracter = 0; posicionCaracter < contrasena.Length; posicionCaracter++)
        {
            char caracterActual = contrasena[posicionCaracter];
            for (int posicionEspecial = 0; posicionEspecial < caracteresEspeciales.Length; posicionEspecial++)
            {
                if (caracterActual == caracteresEspeciales[posicionEspecial]) return 1;
            }
        }
        return 0;
    }
}