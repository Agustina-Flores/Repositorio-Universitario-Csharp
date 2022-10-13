using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace reader
{
    class Program
    {

        static void Main(string[] args)
        {
            escribirTxt();
            leerElementos();
        }

        public static void escribirTxt()
        {

            DataBaseManager dataBaseManager1 = new DataBaseManager();
            var shippers = dataBaseManager1.selectShippers();

            string result = "";

            foreach (var shipper in shippers)
            {

                result = result + shipper.CompanyName + "-" + shipper.Phone + ";";
            }

            //escribir datoss en un archivo
            try
            {
                using (StreamWriter writer = new StreamWriter("shippers.txt"))
                {
                    writer.Write(result);
                    //Console.WriteLine("\n");
                }
            }
            catch (Exception ex)
            {

            }
        }

        public static void leerElementos()
        {
            List<string> lista = new List<string>();
            string linea;
            try
            {
                StreamReader sr = new StreamReader("shippers.txt"); //carpeta bin

                linea = sr.ReadLine();
                lista = linea.Replace("-", ";").Split(';').ToList();
                int n = 0;
                Console.Write("Nombre Compania\tTelefono \n");
                foreach (string item in lista)
                {
                    Console.Write(item + "\t");
                    n++;
                    if (n % 2 == 0)
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
