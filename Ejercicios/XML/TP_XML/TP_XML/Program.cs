using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace TP_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            creaXML();
            //crearXML_textWriter("ejemploXml.xml");
            //leerXML("miXML.xml");
            //leerXML_textReader("ejemploXml.xml");
        }

        static public void creaXML()
        {
            XDocument miXML = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("Empleados",
                    new XElement("listado",
                        new XElement("Empleado",
                             new XElement("ID", "4884"),
                             new XElement("nombreCompleto", "Rodriguez, Victor"),
                             new XElement("cuil", "20103180326"),
                             new XElement("sector",
                                new XAttribute("denominacion", "Gerencia Recursos Humanos"),
                                new XAttribute("id", "137"),
                                new XAttribute("valorSemaforo", "130.13"),
                                new XAttribute("colorSemaforo", "VERDE")),
                            new XElement("cupoAsignado", "1837.15"),
                            new XElement("cupoConsumido", "658.02")),
                        new XElement("Empleado",
                            new XElement("ID", "1225"),
                            new XElement("nombreCompleto", "Sanchez, Juan Ignacio"),
                            new XElement("cuil", "20271265817"),
                            new XElement("sector",
                                new XAttribute("denominacion", "Gerencia Operativa"),
                                new XAttribute("id", "44"),
                                new XAttribute("valorSemaforo", "130.13"),
                                new XAttribute("colorSemaforo", "ROJO")),
                            new XElement("cupoAsignado", "750.87"),
                            new XElement("cupoConsumido", "625.46"))),
                    new XElement("subsectores", "5"),
                    new XElement("totalCupoAsgignadoSector", "4217.21"),
                    new XElement("totalCupoConsumidoSector", "1405.88"),
                    new XElement("valorDial", "33.34")));
            miXML.Save(@"C:\Users\Agustina\Downloads\xmlejercicio\miXML.xml");
        }
/*
        static public void crearXML_textWriter(String file_path)
        {
            XmlTextWriter writer=new XmlTextWriter(file_path, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();

            writer.WriteStartElement("Empleados");
                writer.WriteStartElement("listado");
                    writer.WriteStartElement("Empleado");
                        writer.WriteStartElement("id");
                        writer.WriteString("4884");
                        writer.WriteStartElement("nombreCompleto");
                        writer.WriteString("Rodriguez, Victor");
                        writer.WriteStartElement("cuil");
                        writer.WriteString("20103180326");
                        writer.WriteStartElement("sector");
                            writer.WriteAttributeString("denominacion","Gerencia Recursos Humanos");
                            writer.WriteAttributeString("id", "137");
                            writer.WriteAttributeString("valorSemaforo", "130.13");
                            writer.WriteAttributeString("colorSemaforo", "VERDE");
                        writer.WriteStartElement("cupoAsignado");
                        writer.WriteString("1837.15");
                        writer.WriteStartElement("cupoConsumido");
                        writer.WriteString("658.02");
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteStartElement("Empleado");
                        writer.WriteElementString("id","1225");
                        writer.WriteElementString("nombreCompleto", "Sanchez, Juan Ignacio");
                        writer.WriteElementString("cuil", "20271265817");
                        writer.WriteStartElement("sector");
                            writer.WriteAttributeString("denominacion", "Gerencia Operativa");
                            writer.WriteAttributeString("id", "44");
                            writer.WriteAttributeString("valorSemaforo", "130.13");
                            writer.WriteAttributeString("colorSemaforo", "ROJO");
                        writer.WriteElementString("cupoAsignado", "750.87");
                        writer.WriteElementString("cupoConsumido", "625.46");
                        writer.WriteEndElement();
                   writer.WriteEndElement();
                   writer.WriteElementString("subsectores", "5");
                   writer.WriteElementString("totalCupoAsignadoSector", "4217.21");
                   writer.WriteElementString("totalCupoConsumidoSector", "1405.88");
                   writer.WriteElementString("valorDial", "33.34");
            writer.WriteEndDocument();
        }

        static public void leerXML(String file_path)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(file_path);
            XmlNodeList empleados = doc.GetElementsByTagName("empleados");
            XmlNodeList lista = ((XmlElement)empleados[0]).GetElementsByTagName("listado");
            XmlNodeList listaEmpleados= ((XmlElement)lista[0]).GetElementsByTagName("empleado");
            foreach(XmlElement nodo in listaEmpleados)
            {
                int i = 0;
                XmlNodeList nId = nodo.GetElementsByTagName("id");
                XmlNodeList nNombreCompleto = nodo.GetElementsByTagName("nombreCompleto");
                XmlNodeList nCuil = nodo.GetElementsByTagName("cuil");
                XmlNodeList nSector = nodo.GetElementsByTagName("sector");
                string nDenominacion = nodo.GetAttribute("denominacion");
                string nIdD = nodo.GetAttribute("id");
                string nValorSemaforo = nodo.GetAttribute("valorSemaforo");
                string nColorSemaforo = nodo.GetAttribute("colorSemaforo");
                XmlNodeList nCupoAsignado = nodo.GetElementsByTagName("cupoAsignado");
                XmlNodeList nCupoConsumido = nodo.GetElementsByTagName("cupoConsumido");
                Console.WriteLine("Elemento nombre ..",
                    nNombreCompleto[i].InnerText,
                    nCuil[i].InnerText,
                    nSector[i].InnerText,
                    nDenominacion, nIdD, nValorSemaforo, nColorSemaforo,
                    nCupoAsignado[i].InnerText,
                    nCupoConsumido[i].InnerText);
                
            }
            XmlNodeList subsectores =( (XmlElement)empleados[0]).GetElementsByTagName("subsectores");
            XmlNodeList totalCupoAsignadoSector = ((XmlElement)empleados[0]).GetElementsByTagName("totalCupoAsignadoSector");
            XmlNodeList totalCupoConsumidoSector = ((XmlElement)empleados[0]).GetElementsByTagName("totalCupoConsumidoSector");
            XmlNodeList valorDial = ((XmlElement)empleados[0]).GetElementsByTagName("valorDial");
            Console.WriteLine(subsectores[0].InnerText,
                              totalCupoAsignadoSector[0].InnerText,
                              totalCupoConsumidoSector[0].InnerText,
                              valorDial[0].InnerText);
        }

        static public void leerXML_textReader(String file_path)
        {
            XmlReader doc = XmlReader.Create(file_path);
            while (doc.Read())
            {
                if (doc.IsStartElement())
                {
                    switch (doc.Name)
                    {
                        case "empleados":
                            Console.WriteLine("Start <empleados> element.");
                            break;
                        case "lista":
                            Console.WriteLine("Start <lista> element.");
                            break;
                        case "empleado":
                            Console.WriteLine("Start <empleado> element.");
                            break;
                        case "id":
                            Console.WriteLine("Start <id> element.");
                            if (doc.Read())
                            {
                                Console.WriteLine("text: " + doc.Value.Trim());
                            }
                            break;
                        case "nombreCompleto":
                            Console.WriteLine("Start <nombreCompleto> element.");
                            if (doc.Read())
                            {
                                Console.WriteLine("text: " + doc.Value.Trim());
                            }
                            break;
                        case "cuil":
                            Console.WriteLine("Start <cuil> element.");
                            if (doc.Read())
                            {
                                Console.WriteLine("text: " + doc.Value.Trim());
                            }
                            break;
                        case "sector":
                            Console.WriteLine("Start <sector> element.");
                            string attribute1 = doc["denominacion"];
                            string attribute2 = doc["id"];
                            string attribute3 = doc["valorSemaforo"];
                            string attribute4 = doc["colorSemaforo"];
                            if (attribute1 != null)
                            {
                                Console.WriteLine("denominacion"+attribute1);
                            }
                            if (attribute2 != null)
                            {
                                Console.WriteLine("id"+attribute2);
                            }
                            if (attribute3 != null)
                            {
                                Console.WriteLine("valorSemaforo"+attribute3);
                            }
                            if (attribute4 != null)
                            {
                                Console.WriteLine("colorSemaforo"+attribute4);
                            }
                            if (doc.Read())
                            {
                                Console.WriteLine("text: " + doc.Value.Trim());
                            }
                            break;
                        case "cupoAsignado":
                            Console.WriteLine("Start <cupoAsignado> element.");
                            if (doc.Read())
                            {
                                Console.WriteLine("text: " + doc.Value.Trim());
                            }
                            break;
                        case "cupoConsumido":
                            Console.WriteLine("Start <cupoConsumido> element.");
                            if (doc.Read())
                            {
                                Console.WriteLine("text: " + doc.Value.Trim());
                            }
                            break;
                        case "subsectores":
                            Console.WriteLine("Start <subsectores> element.");
                            if (doc.Read())
                            {
                                Console.WriteLine("text: " + doc.Value.Trim());
                            }
                            break;
                        case "totalCupoAsignadoSector":
                            Console.WriteLine("Start <totalCupoAsignadoSector> element.");
                            if (doc.Read())
                            {
                                Console.WriteLine("text: " + doc.Value.Trim());
                            }
                            break;
                        case "totalCupoConsumidoSector":
                            Console.WriteLine("Start <totalCupoConsumidoSector> element.");
                            if (doc.Read())
                            {
                                Console.WriteLine("text: " + doc.Value.Trim());
                            }
                            break;
                        case "valorDial":
                            Console.WriteLine("Start <valorDial> element.");
                            if (doc.Read())
                            {
                                Console.WriteLine("text: " + doc.Value.Trim());
                            }
                            break;
                    }
                }
            }
        }
*/
    }
}
