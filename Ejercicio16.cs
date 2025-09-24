using System;

class Program
{
    // Variables globales
    static string[] listaUsuarios = new string[100];
    static int cantidadUsuariosRegistrados = 0;

    static void Main(string[] args)
    {
        int opcionMenu = -1;
        while (opcionMenu != 0)
        {
            Console.WriteLine("\n Menú Registro de Usuarios ");
            Console.WriteLine("1. Registrar usuario");
            Console.WriteLine("2. Validar usuario");
            Console.WriteLine("3. Mostrar usuarios");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");

            // Validacion menu
            if (!int.TryParse(Console.ReadLine(), out opcionMenu) || opcionMenu < 0 || opcionMenu > 3)
            {
                opcionMenu = -1;
            }

            //Ciclo Para Opcion elegida
            if (opcionMenu == 1)
            {
                RegistrarUsuario();
            }
            else if (opcionMenu == 2)
            {
                ValidarUsuario();
            }
            else if (opcionMenu == 3)
            {
                MostrarUsuarios();
            }
            else if (opcionMenu != 0)
            {
                Console.WriteLine("Opción inválida.");
            }
        }
    }

    // Registrar un usuario nuevo
    static void RegistrarUsuario()
    {
        Console.Write("Ingresa un nombre de usuario: ");
        string nombreUsuarioNuevo = Console.ReadLine()??"";

        if (nombreUsuarioNuevo == "")
        {
            Console.WriteLine("El nombre no puede estar vacío.");
            return;
        }

        // Validar si ya existe
        for (int indiceUsuario = 0; indiceUsuario < cantidadUsuariosRegistrados; indiceUsuario++)
        {
            if (listaUsuarios[indiceUsuario] == nombreUsuarioNuevo)
            {
                Console.WriteLine("Ese usuario ya está registrado.");
                return;
            }
        }

        if (cantidadUsuariosRegistrados < listaUsuarios.Length)
        {
            listaUsuarios[cantidadUsuariosRegistrados] = nombreUsuarioNuevo;
            cantidadUsuariosRegistrados++;
            Console.WriteLine("Usuario registrado con éxito.");
        }
        else
        {
            Console.WriteLine("No se pueden registrar más usuarios (límite alcanzado).");
        }
    }

    // Validar usuario
    static void ValidarUsuario()
    {
        Console.Write("Ingresa el nombre a validar: ");
        string nombreUsuarioBuscado = Console.ReadLine()??"";

        int usuarioEncontrado = 0;
        for (int indiceUsuario = 0; indiceUsuario < cantidadUsuariosRegistrados; indiceUsuario++)
        {
            if (listaUsuarios[indiceUsuario] == nombreUsuarioBuscado)
            {
                usuarioEncontrado = 1;
            }
        }

        if (usuarioEncontrado == 1)
        {
            Console.WriteLine("El usuario existe.");
        }
        else
        {
            Console.WriteLine("El usuario no existe.");
        }
    }

    // Mostrar todos los usuarios
    static void MostrarUsuarios()
    {
        Console.WriteLine("\nUsuarios registrados:");
        if (cantidadUsuariosRegistrados == 0)
        {
            Console.WriteLine("No hay usuarios registrados.");
        }
        else
        {
            for (int indiceUsuario = 0; indiceUsuario < cantidadUsuariosRegistrados; indiceUsuario++)
            {
                Console.WriteLine((indiceUsuario + 1) + ". " + listaUsuarios[indiceUsuario]);
            }
        }
    }
}