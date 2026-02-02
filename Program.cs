using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("     CALCULADORA .NET 10");
            Console.WriteLine("====================================");
            Console.WriteLine();

            bool continuar = true;

            while (continuar)
            {
                try
                {
                    // Solicitar primer número
                    Console.Write("Ingrese el primer número entero: ");
                    string? input1 = Console.ReadLine();
                    if (!int.TryParse(input1, out int numero1))
                    {
                        Console.WriteLine("Error: Debe ingresar un número entero válido.");
                        Console.WriteLine();
                        continue;
                    }

                    // Solicitar segundo número
                    Console.Write("Ingrese el segundo número entero: ");
                    string? input2 = Console.ReadLine();
                    if (!int.TryParse(input2, out int numero2))
                    {
                        Console.WriteLine("Error: Debe ingresar un número entero válido.");
                        Console.WriteLine();
                        continue;
                    }

                    // Solicitar operación
                    Console.WriteLine();
                    Console.WriteLine("Seleccione la operación:");
                    Console.WriteLine("1. Suma (+)");
                    Console.WriteLine("2. Resta (-)");
                    Console.WriteLine("3. Multiplicación (*)");
                    Console.Write("Ingrese su opción (1-3): ");
                    string? operacion = Console.ReadLine();

                    int resultado = 0;
                    string simbolo = "";
                    bool operacionValida = true;

                    switch (operacion)
                    {
                        case "1":
                            resultado = numero1 + numero2;
                            simbolo = "+";
                            break;
                        case "2":
                            resultado = numero1 - numero2;
                            simbolo = "-";
                            break;
                        case "3":
                            resultado = numero1 * numero2;
                            simbolo = "*";
                            break;
                        default:
                            Console.WriteLine("Error: Opción no válida.");
                            operacionValida = false;
                            break;
                    }

                    if (operacionValida)
                    {
                        Console.WriteLine();
                        Console.WriteLine("====================================");
                        Console.WriteLine($"  RESULTADO: {numero1} {simbolo} {numero2} = {resultado}");
                        Console.WriteLine("====================================");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.WriteLine();
                Console.Write("¿Desea realizar otra operación? (S/N): ");
                string? respuesta = Console.ReadLine()?.ToUpper();
                continuar = respuesta == "S" || respuesta == "SI" || respuesta == "SÍ";
                Console.WriteLine();
            }

            Console.WriteLine("¡Gracias por usar la calculadora!");
        }
    }
}
