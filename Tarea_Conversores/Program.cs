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
            string continuar = "s";
            while (continuar == "s")
            {
                Console.WriteLine();
                Console.WriteLine("*** MENU ***");
                Console.WriteLine("1. Conversor");
                Console.WriteLine("2. Impuestos");
                Console.WriteLine("3. Salir");
                Console.Write("Opcion: ");
                Console.WriteLine();
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();//Limpiar la consola.
                switch (opcion)
                {
                    case 1://if (opcion==1)
                        conversor();
                        break;
                    case 2://if (opcion==2)
                        impuesto();
                        break;
                    case 3://if (opcion==3)
                        continuar = "n";
                        break;
                    default://else
                        Console.WriteLine("opcion Incorrecta\n\n");
                        break;
                }
            }
        }
        static void conversor()
        {


            string[] categorias = {
    "Superficie",
};

            string[][] TipoDeConversores = new string[][]{
    new string[] {"Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tareas", "Manzana", "Hectareas" }
};

            double[][] valores = {
    new double [] {0.092903, 0.7, 0.836127, 1, 437.5, 7000, 10000},
};

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Seleccione la categoría de conversión:");
                for (int i = 0; i < categorias.Length; i++)
                {
                    Console.WriteLine($"{i}: {categorias[i]}");
                }

                int tipoConversor;
                while (true)
                {
                    Console.Write("\nIngrese el número de la categoría: ");
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
                Console.WriteLine("\nSeleccione la unidad de origen:");
                for (int i = 0; i < TipoDeConversores[tipoConversor].Length; i++)
                {
                    Console.WriteLine($"{i}: {TipoDeConversores[tipoConversor][i]}");
                }

                int unidadOrigen;
                while (true)
                {
                    Console.Write("\nIngrese el número de la unidad de origen: ");
                    if (int.TryParse(Console.ReadLine(), out unidadOrigen) && unidadOrigen >= 0 && unidadOrigen < TipoDeConversores[tipoConversor].Length)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                    }
                }

                Console.WriteLine("\nSeleccione la unidad de destino:");
                for (int i = 0; i < TipoDeConversores[tipoConversor].Length; i++)
                {
                    Console.WriteLine($"{i}: {TipoDeConversores[tipoConversor][i]}");
                }

                int unidadDestino;
                while (true)
                {
                    Console.Write("\nIngrese el número de la unidad de destino: ");
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
                    break;
                }
            }
        }



            static void impuesto()

        {


            double[,] tablaImpuestos = new double[,]

            {

            {0.01,   500,  1.5, 0}, //Tramo 1
                {500.01, 1000, 1.5, 3}, //Tramo 2
                {1000.01, 2000, 3, 3}, //Tramo 3
                {2000.01, 3000, 6, 3},//Tramo 4
                {3000.01, 6000, 9, 2},//Tramo 5
                {8000.01, 18000, 15,2 },//Tramo 6
                {18000.01, 30000, 39,2 },//Tramo 7
                {30000.01, 60000, 63,1 },//Tramo 8 
                {60000.01, 100000, 93,0.8 },//Tramo 9
                {100000.01, 200000, 125, 0.7},//Tramo 10
                {200000.01, 300000, 195, 0.6},//Tramo 11
                {300000.01, 400000, 255, 0.45},//Tramo 12
                 {400000.01, 500000, 300, 0.4},//Tramo 13
                  {500000.01, 1000000, 340, 0.30},//Tramo 14
                   {1000000.01, 99999999, 490, 0.18},//Tramo 15

            };





            Console.Write(" actividad económica: ");

            double monto = Convert.ToDouble(Console.ReadLine());



            double impuesto = 0.0;





            for (int i = 0; i < tablaImpuestos.GetLength(0); i++)

            {

                if (monto >= tablaImpuestos[i, 0] && monto <= tablaImpuestos[i, 1])

                {

                    double baseImponible = monto - tablaImpuestos[i, 0];

                    impuesto = (baseImponible / 1000 * tablaImpuestos[i, 3]) + tablaImpuestos[i, 2];

                    break;

                }

            }



            

            Console.WriteLine($"El impuesto a pagar es: ${impuesto:F2}");

        }

    }

}

