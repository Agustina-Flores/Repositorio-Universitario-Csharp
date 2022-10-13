using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Data;
using System.Drawing;
using System.ComponentModel;
using System.Web;
 
 
namespace reader
{

    public static class StreamReaderSequence
    {
        public static IEnumerable<string> Lines(this StreamReader source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            string line;
            while ((line = source.ReadLine()) != null)
            {
                yield return line;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            escribirTxt();
            leerElementos();
           

        }
        private static void leerElementos()
        {

            var sr = new StreamReader("customers.txt");
            var xmlTree = new XStreamingElement("Customers",
                from line in sr.Lines()
                let items = line.Split('\t')
                    // where !line.StartsWith("#")
                    select new XElement("Customer",
                                   // new XAttribute("ID", items[0]),
                                   new XElement("CustomerID", items[0]),
                                   new XElement("CompanyName", items[1]),
                                   new XElement("ContactName", items[2]),
                                   new XElement("City", items[3]),
                                   new XElement("Region", items[4]),
                                   new XElement("Country", items[5]),
                                   new XElement("Phone", items[6])
                               )
            );
            Console.WriteLine(xmlTree);
            sr.Close();
        }

        private static void escribirTxt()
        {
            DataBaseManager dataBaseManager1 = new DataBaseManager();
            var customers = dataBaseManager1.selectCustomers();

            string result = "";

            foreach (var customer in customers)
            {

                result = result + customer.CustomerId + "\t" + customer.CompanyName + "\t" + customer.ContactName + "\t" + customer.City + "\t" + customer.Region + "\t" + customer.Country + "\t" + customer.Phone + "\n";
            }

            //escribir datoss en un archivo
            try
            {
                using (StreamWriter writer = new StreamWriter("customers.txt"))
                {
                    writer.Write(result);
                    Console.WriteLine("\n");
                }
            }
            catch (Exception ex)
            {

            }

          
            /*
            string pathFile = "customers.txt";
            string contentFile = String.Empty;

            try
            {
                if (File.Exists(pathFile))
                {
                    StreamReader sr = File.OpenText(pathFile);
                    contentFile = sr.ReadToEnd();
                    sr.Close();

                    // Print the content
                    Console.WriteLine(contentFile);
                }
                else
                {
                    // Print the message
                    Console.WriteLine("It was not possible to find the file {0}", pathFile);
                }
            }
            catch (Exception excp)
            {
                Console.WriteLine("Error:" + excp.ToString());
            }
            */
        }

    }
    }

 
 


