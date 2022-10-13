using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace read
{
    class Program
    {
        static void Main(string[] args)
        {
            escribirArchivo();
            leerArchivos();
        }

        public static void escribirArchivo()
        {
            string fileName = @"C:\Users\Agustina\Downloads\datosxml\archivos.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.Write("Carlos,Lopez,29118614,Salta#Jose,Sanchez,11045855,Cordoba#Luis,Perez,08654789,Misiones#Alberto,Tobares,15654258,Mendoza");
                }
               
            }
            catch (Exception exp)
            {
                Console.Write(exp.Message);
            }
        }

        public static void leerArchivos()
        {
            List<string> lista = new List<string>();
            string linea;
            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\Agustina\\Downloads\\datosxml\\archivos.txt");

                linea = sr.ReadLine();
                lista = linea.Replace("#", ",").Split(',').ToList();
                int n = 0;
                foreach (string item in lista)
                {
                    Console.Write(item + "\t");
                    n++;
                    if (n % 4 == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }

                while (linea != null)
                {
                    //Read the next line
                    linea = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
