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
          new String[]{"Libra", "Kilogramos", "Gramos", "Toneladas", "Miligramos", "Microgramos", "Tonelada Larga", "Tonelada Corta", "Piedras", "Onza"}, //Masa
          new String[]{"Litro", "Galon USA", "Cuarto USA", "Pinta USA", "Taza USA", "Onza liquida USA", "Cucharada USA", "Cucharadita USA", "Metro Cubico", "Mililitro"}, //Volumen
          new String[]{"Metro", "Kilometro", "Centimetro", "Milimetro", "Micrometro", "Nanometro", "Milla", "Yarda", "Pie", "Pulgada"}, //Longitud
          new String[]{"Megabyte", "Gigabyte", "Terabyte", "Petabyte", "Kilobyte", "Byte", "Petabyte", "Terabyte", "Gigabyte", "Megabyte"}, //Almacenamiento
          new String[]{"Minutos", "Segundos", "Hora", "Dia", "Semana", "mes", "Año", "Decada", "Siglo", "Milisegundo"}, //Tiempo

            };

            double[][] valores = {
                new double[] { 1, 0.90, 7.71, 24.68, 36.66, 8.71, 516.18, 145.31, 83.80, 0.77 }, //Valor Monedas
                new double[] { 1, 0.453592, 453.592, 0.000453592, 453592, 453600000, 0.000446429, 0.0005, 0.0714286, 16 }, //Valor Masa
                new double[] { 1, 0.264172, 1.05669, 2.11338, 4.16667, 33.814, 67.628, 202.884, 0.001, 1000 }, //Valor Volumen
                new double[] { 1, 0.001, 100, 1000, 1000000, 1000000000, 0.000621371, 1.09361, 3.28084, 39.3701 }, //Valor Longitud
                new double[] { 1, 0.001, 0.000001, 0.000000001, 1000, 1000000, 0.000000001, 0.000001, 0.008, 8 }, //Valor Almacenamiento
                new double[] { 1, 60, 0.0166667, 0.000694444, 0.000099206, 0.000022831, 0.0000019026, 0.00000019026, 0.00000001903, 60000 }, //Valor Tiempo
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

