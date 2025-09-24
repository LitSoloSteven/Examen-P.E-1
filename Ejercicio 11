using System;

public class Inventario
{
    private int totalProductos;

    public Inventario()
    {
        totalProductos = 0;
    }

    public int ObtenerCantidadValidada()
    {
        int cantidad;
        while (true)
        {
            Console.Write("Introduce la cantidad: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out cantidad) && cantidad >= 0)
            {
                return cantidad;
            }
            else
            {
                Console.WriteLine("Entrada no valida. Por favor, introduce un numero entero positivo.");
            }
        }
    }

    public void AgregarProductos(int cantidad)
    {
        totalProductos += cantidad;
        Console.WriteLine($"Se agregaron {cantidad} productos.");
        ConsultarInventario();
    }

    public void RetirarProductos(int cantidad)
    {
        if (cantidad <= totalProductos)
        {
            totalProductos -= cantidad;
            Console.WriteLine($"Se retiraron {cantidad} productos.");
            ConsultarInventario();
        }
        else
        {
            Console.WriteLine("Error: No hay suficientes productos en el inventario.");
            ConsultarInventario();
        }
    }

    public void ConsultarInventario()
    {
        Console.WriteLine($"Inventario actual: {totalProductos} productos.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Inventario miInventario = new Inventario();
        int opcion;

        do
        {
            Console.WriteLine("\n--- Sistema de Inventario ---");
            Console.WriteLine("1. Agregar productos");
            Console.WriteLine("2. Retirar productos");
            Console.WriteLine("3. Consultar inventario");
            Console.WriteLine("4. Salir");
            Console.Write("Selecciona una opcion: ");

            string entrada = Console.ReadLine();
            
            if (int.TryParse(entrada, out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        int agregar = miInventario.ObtenerCantidadValidada();
                        miInventario.AgregarProductos(agregar);
                        break;
                    case 2:
                        int retirar = miInventario.ObtenerCantidadValidada();
                        miInventario.RetirarProductos(retirar);
                        break;
                    case 3:
                        miInventario.ConsultarInventario();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del sistema de inventario.");
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
