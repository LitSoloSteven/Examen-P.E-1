using System;

class Program
{
    static void Main(string[] args)
    {
        int mesIngresado = LeerMes();
        int anioIngresado = LeerAnio();
        int diaIngresado = LeerDiaSegunMesYAnio(mesIngresado, anioIngresado);

        Console.WriteLine("Fecha aceptada: " + diaIngresado + "/" + mesIngresado + "/" + anioIngresado);
        Console.WriteLine("Año bisiesto: " + (EsBisiesto(anioIngresado) == 1 ? "sí" : "no"));
    }

    static int LeerMes()
    {
        int mesLeido;
        while (true)
        {
            Console.Write("Ingresa el mes (1-12): ");
            string entrada = Console.ReadLine()??"";
            if (!int.TryParse(entrada, out mesLeido))
            {
                Console.WriteLine("Mes inválido: debes ingresar un número entero.");
                continue;
            }
            if (mesLeido < 1 || mesLeido > 12)
            {
                Console.WriteLine("Mes inválido: el mes debe estar entre 1 y 12.");
                continue;
            }
            return mesLeido;
        }
    }

    static int LeerAnio()
    {
        int anioLeido;
        while (true)
        {
            Console.Write("Ingresa el año (≥ 1): ");
            string entrada = Console.ReadLine()??"";
            if (!int.TryParse(entrada, out anioLeido))
            {
                Console.WriteLine("Año inválido: debes ingresar un número entero.");
                continue;
            }
            if (anioLeido < 1)
            {
                Console.WriteLine("Año inválido: debe ser mayor o igual a 1.");
                continue;
            }
            return anioLeido;
        }
    }

    static int LeerDiaSegunMesYAnio(int mes, int anio)
    {
        int diaLeido;
        int maxDias = ObtenerMaxDiasDelMes(mes, anio);

        while (true)
        {
            Console.Write("Ingresa el día (1-" + maxDias + "): ");
            string entrada = Console.ReadLine()??"";
            if (!int.TryParse(entrada, out diaLeido))
            {
                Console.WriteLine("Día inválido: debes ingresar un número entero.");
                continue;
            }
            if (diaLeido < 1)
            {
                Console.WriteLine("Día inválido: debe ser ≥ 1.");
                continue;
            }
            if (diaLeido > maxDias)
            {
                Console.WriteLine("Día inválido: para " + mes + "/" + anio + " el máximo es " + maxDias + ".");
                continue;
            }

            return diaLeido;
        }
    }

    static int ObtenerMaxDiasDelMes(int mes, int anio)
    {
        int maxDias;
        if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            maxDias = 31;
        else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            maxDias = 30;
        else // mes == 2
            maxDias = (EsBisiesto(anio) == 1) ? 29 : 28;
        return maxDias;
    }

    static int EsBisiesto(int anio)
    {
        if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0)) return 1;
        return 0;
    }
}