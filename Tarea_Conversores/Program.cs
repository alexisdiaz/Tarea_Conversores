using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tarea_Conversores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] categorias = {
                "Monedas",
                "Masa",
                "Volumen",
                "Longitud",
                "Almacenamiento",
                "Tiempo"
            };

            String[][] TipoDeConversores = new String[][]{

          new String[]{"Dolar", "Euro", "Quetzal", "Lempira", "Cordoba", "ColonSV", "ColonCR", "Yenes", "Rupias india", "Libras esterlinas"}, //Monedas
         new String[] {"Tonelada", "Kilogramo", "Gramo", "Miligramo", "Microgramo", "Tonelada larga", "Tonelada corta", "Stone", "Libra", "Onza"}, //Masa
          new string[] {"Metro Cubico", "Galón", "Cuarto", "Taza americana", "Onza Liquida", "Litro", "Mililitro", "Pulgada Cubica", "Pie Cubico"}, //Volumen
          new string[] {"Kilometro", "Metro", "Centimetro", "Milímetro", "Micrometro", "Nanometro", "Milla", "Yarda", "Pie", "Pulgada"} , //Longitud
          new string [] {"Bits", "Bytes", "Kilobytes", "Megabytes", "Gigabytes", "Terabytes", "Petabytes", "Exabytes", "Zettabytes", "Yottabytes"}, //Almacenamiento
           new string [] {"Nanosegundo", "Microsegundo", "Milisegundo", "Segundo", "Minuto", "Hora", "Dia", "Semana", "Mes", "Año" }, //Tiempo 

            };

            double[][] valores = {
                new double[] { 1, 0.90, 7.71, 24.68, 36.66, 8.71, 516.18, 145.31, 83.80, 0.77 }, //Valor Monedas
                new double [] {1, 1000, 1000000, 1000000000.00, 00, 0.984207,  1.10231, 157.473, 2204.62, 35274},//Masa
            new double [] {1, 264.172, 1056.69, 4166.67, 33814, 1000, 1000000, 61023.7, 35.3147}, //Volumen
            new double [] {1, 1000, 100000, 1000000, 0, 0, 0.621371, 1093.61, 3280.84, 39370.1},//Longitud
            new double [] {1, 0.125, 0.000125, 0.000000125, 0.00000000009313226, 0.000000000000000000091, 0.000000000000000000000000000888, 0.000000000000000000000000000000000868, 0.0000000000000000000000000000000000000000000848, 0.0000000000000000000000000000000000000000000000000000000000083}, //Almacenamiento
            new double [] {1, 0.001, 0.000001, 0.000000001, 0.00000000001666667, 0.00000000000027778, 0.00000000000001157407, 0.00000000000000165344, 0.00000000000000038056, 0.0000000000000000317098 } //tiempo
            };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Seleccione la unidad a convertir");
                for (int i = 0; i < categorias.Length; i++)
                {
                    Console.WriteLine($"{i}: {categorias[i]}");
                }

                int tipoConversor;

                while (true)
                {
                    Console.Write("\nIngrese el número de la conversion a realizar: ");
                    if (int.TryParse(Console.ReadLine(), out tipoConversor) && tipoConversor >= 0 && tipoConversor < TipoDeConversores.Length)
                    {
                        break;

                    }

                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                    }
                }
                Console.Clear();
                Console.WriteLine($"\nSeleccionaste la categoría: {categorias[tipoConversor]}");
                Console.WriteLine();
                Console.WriteLine("Seleccione la primera unidad:");
                for (int i = 0; i < TipoDeConversores[tipoConversor].Length; i++)
                {
                    Console.WriteLine($"{i}: {TipoDeConversores[tipoConversor][i]}");
                }

                int unidadOrigen;
                while (true)
                {
                    Console.Write("\nIngrese el número de la unidad a convertir: ");
                    if (int.TryParse(Console.ReadLine(), out unidadOrigen) && unidadOrigen >= 0 && unidadOrigen < TipoDeConversores[tipoConversor].Length)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                    }
                }

                Console.WriteLine("\nSeleccione la segunda unidad:");
                for (int i = 0; i < TipoDeConversores[tipoConversor].Length; i++)
                {
                    Console.WriteLine($"{i}: {TipoDeConversores[tipoConversor][i]}");
                }

                int unidadDestino;
                while (true)
                {
                    Console.Write("\nIngrese el número de la unidad a convertir: ");
                    if (int.TryParse(Console.ReadLine(), out unidadDestino) && unidadDestino >= 0 && unidadDestino < TipoDeConversores[tipoConversor].Length)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                    }
                }

                double cantidad;
                while (true)
                {
                    Console.Write("\nIngrese la cantidad a convertir: ");
                    if (double.TryParse(Console.ReadLine(), out cantidad) && cantidad >= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese una cantidad numérica válida.");
                    }
                }

                double resultado = (valores[tipoConversor][unidadDestino] / valores[tipoConversor][unidadOrigen]) * cantidad;
                Console.WriteLine($"\nResultado: {cantidad} {TipoDeConversores[tipoConversor][unidadOrigen]} equivalen a {Math.Round(resultado, 3)} {TipoDeConversores[tipoConversor][unidadDestino]}");

                Console.WriteLine("\n¿Desea realizar otra conversión? (s/n)");
                string continuar = Console.ReadLine().ToLower();
                if (continuar != "s")
                {
                    Console.WriteLine("\n");
                    break;
                }

            }

        }
    }
}

