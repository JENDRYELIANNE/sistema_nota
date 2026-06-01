
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace sistema_nota
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
                string nombre;
                double nota;

                try
                {
                    Console.Write("Ingrese el nombre del estudiante: ");
                    nombre = Console.ReadLine() ?? "";

                    Console.Write("Ingrese la nota (0-100): ");
                    nota = double.Parse(Console.ReadLine() ?? "0");

                    if (nota < 0 || nota > 100)
                    {
                        Console.WriteLine("ERROR: La nota debe estar entre 0 y 100.");
                        return;
                    }

                    Console.WriteLine("\n===== RESULTADO =====");
                    Console.WriteLine("Estudiante: " + nombre);
                    Console.WriteLine("Nota: " + nota);

                    if (nota >= 70)
                        Console.WriteLine("Estado: APROBADO");
                    else
                        Console.WriteLine("Estado: REPROBADO");
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR: Solo se permiten números.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error inesperado: " + ex.Message);
                }
                finally
                {
                    Console.WriteLine("\nProceso finalizado.");
                }

                Console.ReadKey();
            }
        }
    }

 

