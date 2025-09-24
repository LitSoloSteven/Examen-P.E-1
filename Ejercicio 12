using System;

public class CajeroAutomatico
{
    private double saldo;

    public CajeroAutomatico()
    {
        saldo = 0;
    }

    public double ObtenerCantidadValidada()
    {
        double cantidad;
        while (true)
        {
            Console.Write("Introduce una cantidad: ");
            string entrada = Console.ReadLine();

            if (double.TryParse(entrada, out cantidad) && cantidad >= 0)
            {
                return cantidad;
            }
            else
            {
                Console.WriteLine("Entrada no valida. Por favor, introduce una cantidad numerica positiva.");
            }
        }
    }

    public void DepositarDinero(double cantidad)
    {
        saldo += cantidad;
        Console.WriteLine($"Deposito exitoso. Tu nuevo saldo es: {saldo:C}");
    }

    public void RetirarDinero(double cantidad)
    {
        if (cantidad <= saldo)
        {
            saldo -= cantidad;
            Console.WriteLine($"Retiro exitoso. Tu nuevo saldo es: {saldo:C}");
        }
        else
        {
            Console.WriteLine("Fondos insuficientes. No puedes retirar esa cantidad.");
        }
    }

    public void ConsultarSaldo()
    {
        Console.WriteLine($"Tu saldo actual es: {saldo:C}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        CajeroAutomatico miCajero = new CajeroAutomatico();
        int opcion;

        do
        {
            Console.WriteLine("\n--- Cajero Automatico ---");
            Console.WriteLine("1. Depositar dinero");
            Console.WriteLine("2. Retirar dinero");
            Console.WriteLine("3. Consultar saldo");
            Console.WriteLine("4. Salir");
            Console.Write("Selecciona una opcion: ");
            
            string entrada = Console.ReadLine();
            
            if (int.TryParse(entrada, out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.Write("Cantidad a depositar: ");
                        double deposito = miCajero.ObtenerCantidadValidada();
                        miCajero.DepositarDinero(deposito);
                        break;
                    case 2:
                        Console.Write("Cantidad a retirar: ");
                        double retiro = miCajero.ObtenerCantidadValidada();
                        miCajero.RetirarDinero(retiro);
                        break;
                    case 3:
                        miCajero.ConsultarSaldo();
                        break;
                    case 4:
                        Console.WriteLine("Gracias por usar el cajero automatico. ¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida. Por favor, selecciona una opcion del 1 al 4.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no valida. Por favor, introduce un numero.");
            }
        } while (opcion != 4);

        Console.ReadKey();
    }
}
