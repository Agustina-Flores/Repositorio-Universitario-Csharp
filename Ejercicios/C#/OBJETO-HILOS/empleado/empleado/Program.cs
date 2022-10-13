using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace empleado
{
    class Program
    {
        static void Main(string[] args)
        {
          //  operacionMat();
             objetos();
             
            arregloX();
            arreglo();
            // Thread t1 = new Thread(ejecutarHilo);
            //t1.Start();
        }

        public static void operacionMat()
        {
            while (true)
            {
                int a, b, c, d;
                string aux;
                Console.WriteLine("Ingrese 4 números enteros: ");
                Console.WriteLine("Número a: ");
                aux = Console.ReadLine();
                a = Int32.Parse(aux);
                Console.WriteLine("Número b: ");
                aux = Console.ReadLine();
                b = Int32.Parse(aux);
                Console.WriteLine("Número c: ");
                aux = Console.ReadLine();
                c = Int32.Parse(aux);
                Console.WriteLine("Número d: ");
                aux = Console.ReadLine();
                d = Int32.Parse(aux);

                int formula = (((a * a) + (b * b)) / c) - d;

                if (formula < 0)
                {
                    Console.WriteLine("El resultado de la formula no puede ser negativo. Inténtelo nuevamente.");
                    continue;
                }
                else if (formula > 10000)
                {
                    Console.WriteLine("“El resultado de la formula supera el máximo esperado. Inténtelo nuevamente.");
                    continue;
                }
                else
                {
                    Console.WriteLine("Resultado de la fórmula: {0}", formula);
                    break;
                }
            }

        }
        public static void objetos()
        {
            Empleado emp1 = new Empleado();
            Empleado emp2 = new Empleado();
            Sector sector1 = new Sector();

            emp1.setNombre("Lucas");
            emp1.setApellido("Perez");
            emp1.setCuit(2456788);

            emp2.setNombre("Juan");
            emp2.setApellido("Gomez");
            emp2.setCuit(2456788);

            List<Empleado> empleados = new List<Empleado>();
            empleados.Add(emp1);
            empleados.Add(emp2);

            sector1.setEmpleados(empleados);
            sector1.verificarDNIEmpleados();
        }
        public static void ejecutarHilo()
        {
            while (true)
            {
                Console.WriteLine("HILO EJECUTADO 5");
                Thread.Sleep(5000);
            }
        }

        public static void arregloX()
        {
            int filas, columnas, suma;
            string aux;

            Console.WriteLine("Ingrese el número de filas: ");
            aux = Console.ReadLine();
            filas = Int32.Parse(aux);
            Console.WriteLine("Ingrese el número de columnas: ");
            aux = Console.ReadLine();
            columnas = Int32.Parse(aux);

            int valor = (filas + columnas);
            string[,] matriz = new string[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    suma = (i + 1) + (j + 1);

                    if (valor == suma)
                    {
                        matriz[i, j] = "X";
                    }
                    else
                    {
                        matriz[i, j] = "0";
                    }
                }
            }
            Console.WriteLine("Matriz: \n");

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
 
        }
         //

         public static void arreglo()
        {
             
             
            try 
            {
                 
                Console.WriteLine("Ingrese el tamaño de la matriz");
                int tamanio = int.Parse(Console.ReadLine());
                if (validacionInput(tamanio) == true)
                {
                     matriz(tamanio);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }


            static bool validacionInput(int tamanio)
            {
               
                if (!(tamanio % 2 == 0) && tamanio >= 3)
                {
                    
                    return true;
                }
                else
                {
                    Console.WriteLine("El  valor ingresado no es un numero entero impar mayor o igual a 3");
                    return false;
                }
            }
            
         static void matriz(int tamanio)
            {
                int a = 0;
                int resultado = tamanio + tamanio;
                int[,] numeros = new int[tamanio, tamanio];

                for (int i = 0; i < tamanio; i++)
                {
                    for (int j = 0; j < tamanio; j++)
                    {
                        a = (i + 1) + (j + 1) + (i + j);

                        if (resultado == a)
                        {
                            numeros[i, j] = 1;
                        }
                        else
                        {
                            numeros[i, j] = 0;
                        }
                    }
                }

                Console.Write("Matriz:  \n");

                for (int i = 0; i < tamanio; i++)
                {
                    for (int j = 0; j < tamanio; j++)
                    {
                        Console.Write(numeros[i, j] + " ");
                    }
                    Console.WriteLine(" ");
                }
            }
     
        }
        }
        }
    
 