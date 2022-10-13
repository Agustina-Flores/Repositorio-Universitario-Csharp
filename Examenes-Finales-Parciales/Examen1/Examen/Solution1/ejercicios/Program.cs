using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
          muestraCaracter();
           EjericioMetrosCuadrados();

           imprimir();
        }

        public static void muestraCaracter()
        {
            string cadena = "";
            do
            {
                Console.Write("Ingrese cadena de longitud mayor a 5 caracteres: ");
                cadena = Console.ReadLine();
            } while (cadena.Length <= 5);
            printVertical(cadena, 0);



        }

        public static void printVertical(string str, int ind)
        {
            Console.WriteLine(str[ind]);
            if (ind < (str.Length - 1))
            {
                ind++;
                printVertical(str, ind);

            }
        }

        private static void EjericioMetrosCuadrados()
        {
            Edificio edificio = new Edificio();
            Departamento d1 = new Departamento(40, 4, 50.60);
            Departamento d2 = new Departamento(35, 5, 34.56);

            List<Departamento> d = new List<Departamento>();
            d.Add(d1);
            d.Add(d2);
            edificio.setDepartamentos(d);

            foreach (Double a in edificio.totalMetrosCuadrados(null))

            {
                Console.WriteLine("Total metros cuadrados en caso de que el parámetro piso sea null: " + a);

            }

        }

        public static void imprimir()
        {
            int i = 0;
            int j = 0;
            int numeros = 0;
            int[,] arreglos = new int[5, 5];

            for (i = 0; i < 5; i++)
            {

                for (j = 0; j < 5; j++)
                {
                    Console.WriteLine("Ingresar numeros");
                    numeros = Int32.Parse(Console.ReadLine());
                    arreglos[i, j] = numeros;

                }
            }
            sumarFilas(arreglos);
            sumaColumnas(arreglos);
        }
        
        static void sumaColumnas(int[,] matriz)
        {
            Console.WriteLine("__________________");


            Console.WriteLine();

            for (int x = 0; x < matriz.GetLength(0); x++)
            {
                int suma = 0;
                for (int y = 0; y < matriz.GetLength(1); y++)
                {

                    suma += matriz[y, x];

                }
                Console.Write(suma + " ");
            }
            Console.WriteLine();
        }

        static void sumarFilas(int[,] matriz)
        {
            for (int y = 0; y < matriz.GetLength(0); y++)
            {
                int suma = 0;
                for (int x = 0; x < matriz.GetLength(1); x++)
                {
                    Console.Write(matriz[y, x] + " ");
                    suma += matriz[y, x];
                }
                Console.WriteLine(" =  " + suma);
            }

        }

    }

} 
