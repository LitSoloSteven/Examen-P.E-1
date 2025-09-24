using System;

class Program
{
    // Variable global
    static double carritoTotal = 0;

    static void Main(string[] args)
    {
        int opcionMenu = -1;
        while (opcionMenu != 0)
        {
            Console.WriteLine("\n Menú Tienda en Línea ");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Eliminar producto");
            Console.WriteLine("3. Consultar total");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");

            string entradaMenu = Console.ReadLine()??"";
            if (!int.TryParse(entradaMenu, out opcionMenu))
            {
                Console.WriteLine("Debes ingresar un número válido de opción.");
                opcionMenu = -1;
                continue;
            }

            if (opcionMenu == 1)
            {
                AgregarProducto();
            }
            else if (opcionMenu == 2)
            {
                EliminarProducto();
            }
            else if (opcionMenu == 3)
            {
                ConsultarTotal();
            }
            else if (opcionMenu != 0)
            {
                Console.WriteLine("Opción inválida.");
            }
        }
    }

    static void AgregarProducto()
    {
        Console.Write("Ingresa el precio del producto: ");
        string entradaPrecio = Console.ReadLine()??"";
        double precioProductoIngresado;
        if (!double.TryParse(entradaPrecio, out precioProductoIngresado))
        {
            Console.WriteLine("Precio inválido. Debes ingresar un número.");
            return;
        }

        if (precioProductoIngresado <= 0)
        {
            Console.WriteLine("El precio debe ser mayor a 0.");
            return;
        }

        carritoTotal = carritoTotal + precioProductoIngresado;
        Console.WriteLine("Producto agregado. Total actual: " + carritoTotal);
    }

    static void EliminarProducto()
    {
        Console.Write("Ingresa el precio del producto a eliminar: ");
        string entradaPrecio = Console.ReadLine()??"";
        double precioProductoEliminado;
        if (!double.TryParse(entradaPrecio, out precioProductoEliminado))
        {
            Console.WriteLine("Precio inválido. Debes ingresar un número.");
            return;
        }

        if (precioProductoEliminado <= 0)
        {
            Console.WriteLine("El precio debe ser mayor a 0.");
            return;
        }

        if (precioProductoEliminado > carritoTotal)
        {
            Console.WriteLine("No puedes eliminar más de lo que hay en el carrito.");
            return;
        }

        carritoTotal = carritoTotal - precioProductoEliminado;
        Console.WriteLine("Producto eliminado. Total actual: " + carritoTotal);
    }

    static void ConsultarTotal()
    {
        Console.WriteLine("El total actual del carrito es: " + carritoTotal);
    }
}