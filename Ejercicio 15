using System;

class CalculadoraCientifica
{
    static double ultimoResultado = 0;

    static void Sumar(double a, double b)
    {
        double resultado = a + b;
        ultimoResultado = resultado;
        Console.WriteLine($"Resultado de la suma: {resultado}");
    }

    static void Restar(double a, double b)
    {
        double resultado = a - b;
        ultimoResultado = resultado;
        Console.WriteLine($"Resultado de la resta: {resultado}");
    }

    static void Multiplicar(double a, double b)
    {
        double resultado = a * b;
        ultimoResultado = resultado;
        Console.WriteLine($"Resultado de la multiplicacion: {resultado}");
    }

    static void Dividir(double a, double b)
    {
        if (b != 0)
        {
            double resultado = a / b;
            ultimoResultado = resultado;
            Console.WriteLine($"Resultado de la division: {resultado}");
        }
        else
        {
            Console.WriteLine("Error: Division entre cero.");
        }
    }

    static void Potencia(double baseNum, double exponente)
    {
        double resultado = Math.Pow(baseNum, exponente);
        ultimoResultado = resultado;
        Console.WriteLine($"Resultado de la potencia: {resultado}");
    }

    static void RaizCuadrada(double numero)
    {
        if (numero >= 0)
        {
            double resultado = Math.Sqrt(numero);
            ultimoResultado = resultado;
            Console.WriteLine($"Resultado de la raiz cuadrada: {resultado}");
        }
        else
        {
            Console.WriteLine("Error: No se puede calcular la raiz de un numero negativo.");
        }
    }

    // Metodo para obtener una entrada numerica valida del usuario
    static double ObtenerEntradaValida(string mensaje)
    {
        double numero;
        string entrada;
        do
        {
            Console.Write(mensaje);
            entrada = Console.ReadLine();
            // TryParse intenta convertir la entrada. Si falla, el bucle continua.
        } while (!double.TryParse(entrada, out numero));
        
        return numero;
    }

    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- CALCULADORA CIENTIFICA ---");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Potencia");
            Console.WriteLine("6. Raiz cuadrada");
            Console.WriteLine("7. Mostrar ultimo resultado");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opcion: ");

            // Se valida la entrada de la opcion del menu
            string entradaOpcion = Console.ReadLine();
            if (!int.TryParse(entradaOpcion, out opcion))
            {
                opcion = -1; // Asigna un valor no valido para que caiga en el default del switch
            }

            switch (opcion)
            {
                case 1:
                    double a1 = ObtenerEntradaValida("Ingresa el primer numero: ");
                    double b1 = ObtenerEntradaValida("Ingresa el segundo numero: ");
                    Sumar(a1, b1);
                    break;

                case 2:
                    double a2 = ObtenerEntradaValida("Ingresa el primer numero: ");
                    double b2 = ObtenerEntradaValida("Ingresa el segundo numero: ");
                    Restar(a2, b2);
                    break;

                case 3:
                    double a3 = ObtenerEntradaValida("Ingresa el primer numero: ");
                    double b3 = ObtenerEntradaValida("Ingresa el segundo numero: ");
                    Multiplicar(a3, b3);
                    break;

                case 4:
                    double a4 = ObtenerEntradaValida("Ingresa el primer numero: ");
                    double b4 = ObtenerEntradaValida("Ingresa el segundo numero: ");
                    Dividir(a4, b4);
                    break;

                case 5:
                    double baseNum = ObtenerEntradaValida("Ingresa la base: ");
                    double exponente = ObtenerEntradaValida("Ingresa el exponente: ");
                    Potencia(baseNum, exponente);
                    break;

                case 6:
                    double num = ObtenerEntradaValida("Ingresa el numero: ");
                    RaizCuadrada(num);
                    break;

                case 7:
                    Console.WriteLine($"Ultimo resultado almacenado: {ultimoResultado}");
                    break;

                case 0:
                    Console.WriteLine("Saliendo de la calculadora...");
                    break;

                default:
                    Console.WriteLine("Opcion invalida. Intenta de nuevo.");
                    break;
            }

        } while (opcion != 0);
    }
}
