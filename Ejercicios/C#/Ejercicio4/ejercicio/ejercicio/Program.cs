using System;
using System.Collections.Generic;
using System.Linq;
namespace ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //valor();
            //objeto();
           //recursion();
            //matrices();
            //orden();
            matriz();
        }
        public static void valor()
        {
            int objetoCuenta = 96;
            int prefijoValor = --objetoCuenta;
            int sufijoValor = --objetoCuenta;
            objetoCuenta -= prefijoValor++ + sufijoValor++;
            Console.WriteLine("Objeto Cuenta " + objetoCuenta);
            Console.WriteLine("Prefijo Valor " + prefijoValor);
            Console.WriteLine("Sufijo Valor " + sufijoValor);
        }
        public static void orden()
        {
            string dato = "";           
            int numero = 0;
            List<string> datos = new List<string>();
            
          
            do
            {
        
                Console.WriteLine("Introduzca un numero  o 'x' para salir");
                dato = Console.ReadLine();
                if(dato == "x" || dato == "X")
                {
                    break;
                }
                else
                {
                    datos.Add(dato);
                }
                
            } while (!(dato == "x" || dato == "X"));
          
            List<int> numeros = datos.ConvertAll(int.Parse);
            numeros.Sort();
            Console.WriteLine("Orden Ascendente: ");
            foreach (int g in numeros)
                { 
                    Console.WriteLine(g);
                }

            numeros.Reverse();
            Console.WriteLine("Orden Descendente: ");
            foreach (int f in numeros)
            { 
                Console.WriteLine(f);
            }

        }
        public static void matrices()
        {
            int[] pares = { 2, 4, 6, 8, 10 };
            int[] impares = { 1, 3, 5, 7, 9 };
            int[] numeros = new int[10];
            numeros = pares.Concat(impares).ToArray();
            Array.Sort(numeros);
            Console.WriteLine("Numeros ordenados: ");
            foreach (int i in numeros)
            {
                Console.Write(i + " ");
                Console.WriteLine('\n');
            }
                 

        }
        public static void recursion()
        {
            Console.WriteLine("Ingrese un numero");
            int n = Int32.Parse(Console.ReadLine());
            divisionRecursiva(n);
        }
        static void divisionRecursiva(int numero)
        {
            int resul = numero / 2;
            
            if(resul < 1)
            {
                return;
            }
            Console.WriteLine("Valores calculados: " + resul);
            divisionRecursiva(resul);
        }
        public static void matriz()
        {
            Console.Write("Ingrese el tamaño de la matriz: ");
            int tamaño = int.Parse(Console.ReadLine());

            matriz(tamaño);

        }

        public static void objeto()
        {
            string opcion = "";
            Alumno a1 = new Alumno("Lucas");
            Alumno a2 = new Alumno("Martin");
            List<Nota> notascargadas = new List<Nota>();
       
             
                do
            {
                  
                Console.WriteLine("Ingrese nota");
                  double nota = Double.Parse(Console.ReadLine());
                Nota n = new Nota();
                n.valor = nota;
                notascargadas.Add(n);
              
                Console.WriteLine("Desea cargar otra nota.Ingrese Si para continuar con la carga o presione otra tecla para salir");
                opcion = Console.ReadLine();

                    // break;
                 
            } while ((opcion == "si" || opcion == "SI" || opcion == "Si"));

             
            a1.setNotas(notascargadas);
             
            Console.WriteLine("Maxima Nota: " + a1.getMaximaNota());
            Console.WriteLine("Promedio : " + a1.PromedioNota());
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

                        if (resultado == a || i==j)
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
