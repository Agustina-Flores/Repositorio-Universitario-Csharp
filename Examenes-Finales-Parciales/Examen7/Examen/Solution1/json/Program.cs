using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace json
{
    class Program
    {

        public static List<Auto> Autos { get; set; }


        public static void LeerJSONURL(string url)
        {
            var webRequest = WebRequest.Create(url);
            String archivoJSON = "";
            using (StreamReader streamReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                archivoJSON = streamReader.ReadToEnd();
            }
            if (archivoJSON != "")
            {
                Autos = JsonConvert.DeserializeObject<List<Auto>>(archivoJSON);
                Console.WriteLine("El auto mas caro es: " + Autos.Where(a => a.Precio == Autos.Max(a => a.Precio)).FirstOrDefault() + "\n");
                Console.WriteLine("El auto menos caro es: " + Autos.Where(a => a.Precio == Autos.Min(a => a.Precio)).FirstOrDefault() + "\n");
            }
        }
        static void Main(string[] args)
        {
            try
            {

                LeerJSONURL("http://179.43.113.170:8082/test/autos.json");


                foreach (Auto a in Autos)
                {
                    Console.WriteLine(a);
                }
                /*

                Autos.ForEach(a =>
                {
                    Console.WriteLine(a);
                   
                 });
                 */


            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);

            }
            finally
            {

                Console.WriteLine("Presione una tecla para salir.");
                Console.Read();
            }

        }

    }
}
