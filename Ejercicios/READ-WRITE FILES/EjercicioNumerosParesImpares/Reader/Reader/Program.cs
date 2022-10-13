using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reader
{
    class Program
    {
        static void Main(string[] args)
        {
            string ubicacionTXT = @"C:\Users\Agustina\Downloads\datosxml\numeros.txt";
            List<int> numeros = ingresoNumeros();
            escribirTXT(numeros, ubicacionTXT);
            leerTXT(ubicacionTXT);
        }
        public static List<int> ingresoNumeros()
        {
            List<int> numeros = new List<int>();
            int nro;
            bool bandera = true;

            try
            {
                do
                {
                    Console.Write("INGRESE UN NRO: ");
                    nro = int.Parse(Console.ReadLine());

                    if (nro != 0)
                    {
                        numeros.Add(nro);
                    }
                    else
                    {
                        bandera = false;
                    }

                } while (bandera == true);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return numeros;
        }
        public static void escribirTXT(List<int> numeros, string ubicacionTXT)
        {
            try
            {
                if (numeros != null)
                {
                    using (StreamWriter sw = new StreamWriter(ubicacionTXT, append: true))
                    {
                        for (int i = 0; i < numeros.Count; i++)
                        {
                            sw.Write(numeros[i] + "-");   // escribo el txt separando cada columna con tabulaciones 
                        }
                        sw.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void leerTXT(string ubicacionTXT)
        {
           string[] filas;
            int i = 0;
            

            try
            {

                using (StreamReader sr = new StreamReader(ubicacionTXT))
                {
                    List<int> numerosPares = new List<int>();
                    List<int> numerosImpares = new List<int>();
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                      
                        filas = linea.Split('-');
                        filas = filas.Take(filas.Length - 1).ToArray();

                        foreach (string numero in filas)
                        {

                            if (Int32.Parse(numero) % 2 == 0)
                            {
                                numerosPares.Add(Int32.Parse(numero));
                                numerosPares.Sort();
                            }
                            else
                            {
                                numerosImpares.Add(Int32.Parse(numero));
                                numerosImpares.Sort();
                            }


                        }
                        Console.WriteLine("\n");
                        Console.WriteLine("Impares:\n");
                        foreach (int impares in numerosImpares)
                        {
                           
                            Console.Write(impares + ", ");
                        }
                        Console.WriteLine("\n");
                        Console.WriteLine("Pares:\n");
                        foreach (int par in numerosPares)
                        {
                            Console.Write(par + ", ");
                        }


                    }

                     

                }


            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }

      
    }
}
