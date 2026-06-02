namespace SistemaNotasExcepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string nombre;
                double nota;

                Console.WriteLine(" SISTEMA DE NOTAS ESCUELITA ");

                Console.Write("Ingrese el nombre del estudiante: ");
                nombre = Console.ReadLine();

                if (nombre.Any(char.IsDigit))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("error: El nombre no puede contener números.");
                    Console.ResetColor();

                    Console.WriteLine("Presione una tecla para salir...jiiji");
                    Console.ReadKey();
                    return;
                }

                try
                {
                    Console.Write("Ingrese la nota: ");

                    nota = double.Parse(Console.ReadLine());

                    if (nota < 0 || nota > 100)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("error: La nota debe estar entre 0 y 100.");
                        Console.ResetColor();
                    }
                    else
                    {
                        string estado;

                        if (nota >= 70)
                        {
                            estado = "APROBADO";
                        }
                        else
                        {
                            estado = "REPROBADO";
                        }

                        Console.ForegroundColor = ConsoleColor.Cyan;

                        Console.WriteLine("\n==========================================");
                        Console.WriteLine("|           Resultado Final             |");
                        Console.WriteLine("==========================================");
                        Console.WriteLine("| Estudiante | " + nombre.PadRight(25) + "|");
                        Console.WriteLine("| Nota       | " + nota.ToString().PadRight(25) + "|");
                        Console.WriteLine("| Estado     | " + estado.PadRight(25) + "|");
                        Console.WriteLine("==========================================");

                        Console.ResetColor();
                    }
                }

                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Debe ingresar un número válido.");
                    Console.ResetColor();
                }

                // Captura cualquier otro error
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ocurrió un error inesperado: " + ex.Message);
                    Console.ResetColor();
                }

                // Siempre se ejecuta
                finally
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nProceso finalizado.");
                    Console.ResetColor();
                }

                Console.WriteLine("Presione una tecla para salir...");
                Console.ReadKey();
            }
        }
    }



