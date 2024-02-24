using System;

namespace ProgramaSemana3
{
    class Programa3
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese tres números:");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int num3 = int.Parse(Console.ReadLine());

                int max = Math.Max(Math.Max(num1, num2), num3);
                Console.WriteLine($"El número mayor es: {max}");

                Console.WriteLine("Ingrese su edad:");
                int edad = int.Parse(Console.ReadLine());
                if (edad >= 18)
                {
                    Console.WriteLine("¡Bienvenido al club!");
                }
                else
                {
                    Console.WriteLine("Lo siento, debes ser mayor de 18 años para ingresar al club.");
                }

                Console.WriteLine("Ingrese el precio original del producto:");
                double precioOriginal = double.Parse(Console.ReadLine());
                double descuento = precioOriginal > 100 ? 0.10 : 0;
                double precioFinal = precioOriginal - (precioOriginal * descuento);
                Console.WriteLine($"El precio final es: {precioFinal:C}");

                Console.WriteLine("Ingrese su nombre de usuario:");
                string usuario = Console.ReadLine();
                Console.WriteLine("Ingrese su contraseña:");
                string contrasena = Console.ReadLine();
                if (usuario == "usuario" && contrasena == "contraseña")
                {
                    Console.WriteLine("Acceso concedido.");
                }
                else
                {
                    Console.WriteLine("Credenciales incorrectas. Acceso denegado.");
                }

                Console.WriteLine("Ingrese un número:");
                int numero = int.Parse(Console.ReadLine());
                string tipo = numero % 2 == 0 ? "par" : "impar";
                Console.WriteLine($"El número es {tipo}.");

                Console.WriteLine("Ingrese el monto del préstamo:");
                double montoPrestamo = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su edad:");
                int edadUsuario = int.Parse(Console.ReadLine());
                if (montoPrestamo < 5000 || edadUsuario > 60)
                {
                    Console.WriteLine("Préstamo aprobado.");
                }
                else
                {
                    Console.WriteLine("Préstamo rechazado.");
                }

                Console.WriteLine("Ingrese el tipo de figura (triángulo, cuadrado o círculo):");
                string tipoFigura = Console.ReadLine().ToLower();
                switch (tipoFigura)
                {
                    case "triángulo":
                        Console.WriteLine("Ingrese la base:");
                        double baseTriangulo = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la altura:");
                        double alturaTriangulo = double.Parse(Console.ReadLine());
                        double areaTriangulo = 0.5 * baseTriangulo * alturaTriangulo;
                        Console.WriteLine($"El área del triángulo es: {areaTriangulo}");
                        break;
                    default:
                        Console.WriteLine("Figura no reconocida.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
