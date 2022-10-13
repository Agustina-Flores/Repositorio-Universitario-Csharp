using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace xml
{
    class Program
    {
        //XmlReader nos permite leer Xml
        public static XmlReader XmlReader { get; set; }

        //StreamWriter  para escritura de archivos de texto
        public static StreamWriter StreamWriter { get; set; }

        public static List<Proveedor> Proveedores { get; set; }

        //contiene la ruta del xml
        public static string ubicacionArchivo(string archivo)
        {
            return String.Format("{0}\\..\\..\\..\\archivos\\{1}", Directory.GetCurrentDirectory(), archivo);
        }

        public static void lecturaXML(string nombreArchivo)
        {
            Proveedores = new List<Proveedor>();
            XmlReader = XmlReader.Create(ubicacionArchivo(nombreArchivo));
            while (XmlReader.Read())
            {
                //Se hace un read para ingresar al nodo
                if (XmlReader.IsStartElement())
                {
                    switch (XmlReader.Name)
                    {
                        case "Proveedor":
                            Proveedores.Add(new Proveedor());
                            break;
                        case "id":
                            XmlReader.Read();
                            Proveedores[Proveedores.Count - 1].Id = XmlReader.Value;
                            break;
                        case "codigo":
                            XmlReader.Read();
                            Proveedores[Proveedores.Count - 1].Codigo = XmlReader.Value;
                            break;
                        case "cuit":
                            XmlReader.Read();
                            Proveedores[Proveedores.Count - 1].Cuit = XmlReader.Value;
                            break;
                        case "razonSocial":
                            XmlReader.Read();
                            Proveedores[Proveedores.Count - 1].RazonSocial = XmlReader.Value;
                            break;

                        case "contacto":
                            XmlReader.ReadToFollowing("telefono");
                            XmlReader.Read();
                            Proveedores[Proveedores.Count - 1].Telefono = XmlReader.Value;
                            break;

                        case "domicilio":
                            XmlReader.ReadToFollowing("domicilio");
                            XmlReader.Read();
                            Proveedores[Proveedores.Count - 1].Domicilio = XmlReader.Value;
                            break;

                        case "saldo":
                            XmlReader.Read();
                            Proveedores[Proveedores.Count - 1].Saldo = XmlReader.Value;
                            break;

                    }
                }

            }

        }

        public static void grabarTxt(string archivo)
        {
            StreamWriter = new StreamWriter(ubicacionArchivo(archivo), true);
            StreamWriter.WriteLine("Id\tcodigo\tcuit\trazonSocial\ttelefono\tdomicilio\tsaldo");

            foreach (var p in Proveedores)
            {
                //imprimo en el txt
                StreamWriter.WriteLine(p);

                Console.WriteLine(p);
            }

        }

        static void Main(string[] args)
        {
            try
            {

                lecturaXML("proveedores.xml");
                grabarTxt("proveedores.txt");



            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(String.Format("No se encuentra el archivo {0}", e.FileName));
            }
            finally
            {

                XmlReader.Close();
                StreamWriter.Close();
                Console.WriteLine("Presione una tecla para salir.");
                Console.Read();
            }
        }
    }
}
