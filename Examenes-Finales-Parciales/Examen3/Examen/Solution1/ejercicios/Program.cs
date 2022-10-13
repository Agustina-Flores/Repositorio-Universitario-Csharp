using System;
using System.Collections.Generic;

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
             arreglo();
            recursion();
            objeto();
           
        }
        public static void recursion()
        {
            double p = 0;
            int numero = 0;
            int[] numeros = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese numero " + (i + 1));
                numero = Int32.Parse(Console.ReadLine());
                if (numero > 0)
                {
                    numeros[i] = numero;
                }
            }
            sumaRecursiva(numeros, numeros.Length - 1);

            Console.WriteLine("Suma: " + sumaRecursiva(numeros, numeros.Length - 1) + " promedio -> " + sumaRecursiva(numeros, numeros.Length - 1) / 10);


        }

        static int sumaRecursiva(int[] arreglo, int posicion)
        {
            int r;
            if (posicion == 0)
            {
                r = arreglo[0];
            }
            else
            {
                r = arreglo[posicion] + sumaRecursiva(arreglo, posicion - 1);


            }

            return r;
        }
        public static void objeto()
        {
            List<Articulo> articulos = new List<Articulo>();
            Articulo art1 = new Articulo("1", 200, 300);
            Articulo art2 = new Articulo("2", 100, 50);
            Articulo art3 = new Articulo("3", 100, 100);
            Deposito dep = new Deposito();

            articulos.Add(art1);
            articulos.Add(art2);
            articulos.Add(art3);
            dep.setArticulos(articulos);
            dep.artículosBajoStock();

            foreach (Articulo art in dep.artículosBajoStock())
            {
                Console.WriteLine("El codigo del Articulo cuyo stockTotal sea menor o igual al stockMinimo existente es: " + art.getCodigo());
            }
        }
        public static void arreglo()
        {
            int numeroUno = 0;
            int numeroDos = 0;
            Console.WriteLine("Ingrese un numero");
            numeroUno = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo numero");
            numeroDos = int.Parse(Console.ReadLine());
            matriz(numeroUno, numeroDos);
        }

        static void matriz(int n1, int n2)
        {
            string butaca = "";
            bool[,] numeros = new bool[n1, n2];

            string[,] butacas = new string[n1, n2];


            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {


                    Console.WriteLine("Ingrese Y si esta ocupado y N si no lo esta");
                    string opcion = Console.ReadLine();
                    if (opcion.ToLower().Equals("y"))
                    {
                        numeros[i, j] = true;
                    }
                    else if (opcion.ToLower().Equals("n"))
                    {
                        numeros[i, j] = false;
                    }


                }
                Console.WriteLine("\n");
            }
            Console.Write("Muestro :  \n");

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    if (numeros[i, j] == true)
                    {

                        Console.Write("OCUPADA \t");
                    }
                    else
                    {
                        Console.Write("DESOCUPADA \t");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
