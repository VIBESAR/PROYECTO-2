using System;

namespace Programasemana3_Switch
{
    class Programa3
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("1. Convertir un Número de Letra a Número");
                Console.WriteLine("2. Mostrar el Día de la Semana a partir de un Número");
                Console.WriteLine("3. Calcular el Importe a Pagar por un Servicio");
                Console.WriteLine("4. Mostrar un Mensaje de Bienvenida en Diferentes Idiomas");
                Console.WriteLine("5. Evaluar la Calificación de un Examen");
                Console.Write("Seleccione una opción (1-5): ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese un número en letra (uno, dos, tres, cuatro, cinco): ");
                        string letra = Console.ReadLine().ToLower();
                        int numero = 0;
                        switch (letra)
                        {
                            case "uno":
                                numero = 1;
                                break;
                            case "dos":
                                numero = 2;
                                break;
                            case "tres":
                                numero = 3;
                                break;
                            case "cuatro":
                                numero = 4;
                                break;
                            case "cinco":
                                numero = 5;
                                break;
                            default:
                                Console.WriteLine("Letra no válida. Intente nuevamente con uno de los valores permitidos.");
                                break;
                        }
                        Console.WriteLine($"El número en dígito es: {numero}");
                        break;

                    case 2:
                        Console.Write("Ingrese un número del 1 al 7: ");
                        int dia = int.Parse(Console.ReadLine());
                        switch (dia)
                        {
                            case 1:
                                Console.WriteLine("Lunes");
                                break;
                            case 2:
                                Console.WriteLine("Martes");
                                break;
                            case 3:
                                Console.WriteLine("Miércoles");
                                break;
                            case 4:
                                Console.WriteLine("Jueves");
                                break;
                            case 5:
                                Console.WriteLine("Viernes");
                                break;
                            case 6:
                                Console.WriteLine("Sábado");
                                break;
                            case 7:
                                Console.WriteLine("Domingo");
                                break;
                            default:
                                Console.WriteLine("Día no válido.");
                                break;
                        }
                        break;

                    case 3:
                        Console.Write("Seleccione un servicio:\n1. Lavado de auto\n2. Cambio de aceite\n3. Revisión mecánica\n");
                        int opcionServicio = int.Parse(Console.ReadLine());
                        double importe = 0;
                        switch (opcionServicio)
                        {
                            case 1:
                                importe = 50;
                                break;
                            case 2:
                                importe = 30;
                                break;
                            case 3:
                                importe = 80;
                                break;
                            default:
                                Console.WriteLine("Opción no válida. Seleccione un servicio válido.");
                                break;
                        }
                        Console.WriteLine($"El importe a pagar es: {importe:C}");
                        break;

                    case 4:
                        Console.Write("Seleccione un idioma (español, inglés, francés): ");
                        string idioma = Console.ReadLine().ToLower();
                        switch (idioma)
                        {
                            case "español":
                                Console.WriteLine("¡Bienvenido!");
                                break;
                            case "inglés":
                                Console.WriteLine("Welcome!");
                                break;
                            case "francés":
                                Console.WriteLine("Bienvenue !");
                                break;
                            default:
                                Console.WriteLine("Idioma no reconocido.");
                                break;
                        }
                        break;

                    case 5:
                        Console.Write("Ingrese la calificación del examen: ");
                        double calificacion = double.Parse(Console.ReadLine());
                        if (calificacion >= 90)
                            Console.WriteLine("Sobresaliente");
                        else if (calificacion >= 80)
                            Console.WriteLine("Notable");
                        else if (calificacion >= 70)
                            Console.WriteLine("Aprobatoria");
                        else if (calificacion >= 60)
                            Console.WriteLine("No aprobatoria");
                        else
                            Console.WriteLine("Calificación no válida. Intente nuevamente con un valor entre 0 y 100.");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Seleccione una opción del 1 al 5.");
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
