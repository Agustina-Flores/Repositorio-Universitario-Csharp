using System;
using System.Collections.Generic;

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
           cadena();
           recursion();
             arreglo();
           // objetos();
        }

        static string letra(string palabra, int index, int lenght)
        {
            string result = palabra.Substring(index, lenght);
            return result;
        }
        static void cadena()
        {
            int i = 0;
            int[] vocales = { 0, 0, 0, 0, 0 };
            Console.WriteLine("Ingresar cadena");
            string cadena = Console.ReadLine();
            for (int j = 0; j < cadena.Length; j++)
            {
                switch (letra(cadena.ToUpper(), j, 1))
                {
                    case "A":
                        vocales[0] += 1;
                        break;
                    case "E":
                        vocales[1] += 1;
                        break;
                    case "I":
                        vocales[2] += 1;
                        break;
                    case "O":
                        vocales[3] += 1;
                        break;
                    case "U":
                        vocales[4] += 1;
                        break;
                }
            }

            Console.WriteLine("La letra A aparece " + vocales[0] + "  veces ");
            Console.WriteLine("La letra E aparece " + vocales[1] + "  veces ");
            Console.WriteLine("La letra I aparece " + vocales[2] + "  veces ");
            Console.WriteLine("La letra O aparece " + vocales[3] + "  veces ");
            Console.WriteLine("La letra U aparece " + vocales[4] + "  veces ");


            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }

        static void recursion()
        {
            Console.WriteLine("Ingrese un numero");
            int numero = Int32.Parse(Console.ReadLine());
            int resultado = suma(numero);
            Console.WriteLine("Resultado : " + resultado);
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }

        static int suma(int n)
        {
            if (n != 0)
            {
                return suma(n / 10) + n % 10;
            }
            else
            {
                return 0;
            }
        }

        public static void arreglo()
        {
            int tamanio = 0;
            List<char> chars = new List<char>();
            //Console.Write(" ingrese tamaño arreglo");
            //tamanio = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.Write(" ingrese tamaño arreglo");
                tamanio = Convert.ToInt32(Console.ReadLine());

            } while (tamanio <= 0);


            int i = 0;
            do
            {
                Console.Write(" ingrese caracter");
                var charT = Convert.ToChar(Console.ReadLine());
                if (!chars.Contains(charT))
                {
                    chars.Add(charT);
                    i++;
                }

            } while (i < tamanio);


            ResolverArray(tamanio, chars.ToArray());
        }
        public static void ResolverArray(int tamanio, char[] valores)
        {

            int n = tamanio;
            int i;
            int j;
            int k;


            for (i = 1; i <= n; i++)
            {
                for (j = i, k = 1; k <= n; k++, j++)
                {
                    if (j > n)
                    {
                        for (j = 1; k <= n; k++, j++)
                        {
                            Console.Write(" {0:D}", valores[j - 1]);
                        }
                    }

                    else
                    {
                        Console.Write(" {0:D}", valores[j - 1]);
                    }
                }
                Console.Write("\n");
            }
        }

        static void objetos()
        {
            Empleado emp1 = new Empleado();
            JornadaLaboral jb1 = new JornadaLaboral(new DateTime(2020, 10, 10), 400);
            JornadaLaboral jb2 = new JornadaLaboral(new DateTime(2019, 4, 12), 480);
            List<JornadaLaboral> listaJornadasL = new List<JornadaLaboral>();
            listaJornadasL.Add(jb1);
            listaJornadasL.Add(jb2);
            emp1.setjornadasLaborales(listaJornadasL);
            var resultado = emp1.totalTrabajadoMes(4, 2019);          
            //var resultado = empleado.totalTrabajadoMes(2, 2019);

            Console.WriteLine("total minutos:  " + resultado);

            Console.WriteLine(string.Format("{0}:{1}", (resultado / 60), resultado));
        }

    }
}
 
