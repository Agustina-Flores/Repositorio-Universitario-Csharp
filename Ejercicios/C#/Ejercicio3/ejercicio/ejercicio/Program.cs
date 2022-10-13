using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
             //objetos();

           // Thread t1 = new Thread(ejecutarHilo);
            // t1.Start();
            matriz();


        }
        static void objetos()
        {

            Deposito d1 = new Deposito("Martin", "Murialdo 22");
            Articulo a1 = new Articulo("100", 10, 10);  // codigo, stockTotal, stockMinimo
            Articulo a2 = new Articulo("101", 100, 10);
            Articulo a3 = new Articulo("102", 10, 20);
            List<Articulo> articulos = new List<Articulo>();
            articulos.Add(a1);
            articulos.Add(a2);
            articulos.Add(a3);
            d1.Articulo = articulos;

            foreach (Articulo a in d1.articulosBajoStock())
            {
                Console.WriteLine("El codigo del articulo con stock total menor o igual al stock minimo es: " + a.Codigo);
                // Console.WriteLine(a.Codigo);
                 
            }
            Console.ReadLine();
        }

        public static void ejecutarHilo()
        {
            while (true)
            {
                Console.WriteLine("HILO EJECUTADO 10");
                Thread.Sleep(10000);
            }
        }
        public static void matriz()
        {
            try
            {

                Console.Write("Ingrese el tamaño de la matriz: ");
                int tamaño = int.Parse(Console.ReadLine());
                if (validacionInput(tamaño) == true)
                {
                    mostrarMatriz(matriz(tamaño));
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }


              static bool validacionInput(int tamaño)
            {
                if (!(tamaño % 2 == 0) && tamaño >= 3)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("El  valor ingresado no es un numero entero impar mayor o igual a 3");
                    return false;
                }
            }

              static int[,] matriz(int tamaño)
            {
                int[,] numeros = new int[tamaño, tamaño];
                for (int i = 0; i < tamaño; i++)
                {
                    for (int j = 0; j < tamaño; j++)
                    {
                        if (i == (tamaño / 2) || j == (tamaño / 2))
                        {
                            numeros[i, j] = 1;
                        }
                        else
                        {
                            numeros[i, j] = 0;
                        }
                    }
                }
                return numeros;
            }

              static void mostrarMatriz(int[,] numeros)
            {
                for (int i = 0; i < numeros.GetLength(0); i++)
                {
                    for (int j = 0; j < numeros.GetLength(1); j++)
                    {
                        Console.Write(numeros[i, j] + "  ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
