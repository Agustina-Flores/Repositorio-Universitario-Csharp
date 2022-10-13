using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.IO;
using Modelo;

namespace WebService.XML
{
    public class XMLPersona
    {
        public XmlWriter XmlWriter { get; set; }
        public string Escritorio = String.Format("{0}\\", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

        public XMLPersona()
        {

        }
        public XMLPersona(string nombreArchivo, Persona a)
        {
            try
            {
                //Procedemos a utilizar XmlDocument
                XmlDocument xmlDocument = new XmlDocument();

                /*
                    A futuro tiene la utilidad
                    de crear un nodo articulos si es nuevo
                    caso contrario agregar los elementos al final del nodo articulos existente.
                 */
                Boolean esNuevo = !File.Exists(String.Format("{0}./{1}.xml", Escritorio, nombreArchivo));

                if (esNuevo)
                {
                    /*
                       Agrega el nodo articulos al final de la raiz del xml
                       es decir va a ser futuro hermano de la etiqueta <xml/>
                    */
                    XmlWriter = XmlWriter.Create(String.Format("{0}./{1}.xml", Escritorio, nombreArchivo), new XmlWriterSettings() { Indent = true });
                    XmlWriter.WriteStartDocument();
                    XmlWriter.WriteStartElement("personas");
                    XmlWriter.WriteEndElement();
                    XmlWriter.WriteEndDocument();
                    XmlWriter.Close();
                }

                xmlDocument.Load(String.Format("{0}./{1}.xml", Escritorio, nombreArchivo));


                //Crear nuevo elemento <articulo/>
                XmlElement persona = xmlDocument.CreateElement("persona");
                XmlAttribute bloqueado = xmlDocument.CreateAttribute("bloqueado");
                bloqueado.InnerText = a.Bloqueado ? "SI" : "NO"; 
                persona.Attributes.Append(bloqueado);


                XmlElement dato = xmlDocument.CreateElement("datosPersonales");
                XmlAttribute sexo = xmlDocument.CreateAttribute("sexo");
                sexo.InnerText = a.Sexo;
               persona.AppendChild(dato);
                dato.Attributes.Append(sexo);

                XmlElement apellido = xmlDocument.CreateElement("apellido");
                apellido.InnerText = a.Apellido;
                persona.AppendChild(apellido);

                XmlElement nombre = xmlDocument.CreateElement("nombre");
                nombre.InnerText = a.Nombre;
                persona.AppendChild(nombre);

                XmlElement edad = xmlDocument.CreateElement("edad");
                edad.InnerText = a.Edad;
                persona.AppendChild(edad);

                XmlElement nac = xmlDocument.CreateElement("nacionalidad");
                nac.InnerText = a.Nacionalidad;
                persona.AppendChild(nac);
               

                XmlElement ant = xmlDocument.CreateElement("antecedentes");
                ant.InnerText = a.Antecedentes;
                persona.AppendChild(ant);

                


                //Aca va a decidir si crea un nuevo nodo o toma el existente.
                XmlNode personas = xmlDocument.FirstChild.NextSibling;

                //Agregar hijo <articulo/> nuevo a <articulos/>
                personas.AppendChild(persona);


                /*
                   Agrega el nodo articulos al final de la raiz del xml
                   Basandose en el hermano del nodo <xml/> reemplazamos el
                   hermano que esta al final es decir el nodo <articulos/>
                */
                xmlDocument.ReplaceChild(personas, xmlDocument.FirstChild.NextSibling);


                xmlDocument.Save(String.Format("{0}./{1}.xml", Escritorio, nombreArchivo));
            }
            //Si pasa algun inconveniente y no le encontramos vuelta es bueno tener que ver que dice la excepcion.
            catch (NullReferenceException e)
            {
                //Stack Trace nos va a indicar en que linea y que archivo se produjo la falla
                Console.WriteLine(e.StackTrace);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private List<Persona> cargarLista(XmlDocument xmlDocument)
        {
            List<Persona> personas = new List<Persona>();
            Persona p = new Persona();
            XmlNodeList personasXML = xmlDocument.FirstChild.NextSibling.ChildNodes;

            for (int i = 0; i < personasXML.Count; i++)
            {
                XmlNode personaXML = personasXML.Item(i);

                // personas.Add(new Persona()
                //{
               
                p.Bloqueado = personaXML.Attributes[0].InnerText != String.Empty;
                p.Sexo = personaXML.Attributes[0].InnerText;
                p.Apellido = personaXML.ChildNodes[1].InnerText;
                p.Nombre = personaXML.ChildNodes[2].InnerText;
                p.Edad = personaXML.ChildNodes[3].InnerText;
                p.Nacionalidad = personaXML.ChildNodes[4].InnerText;
                p.Antecedentes = personaXML.ChildNodes[5].InnerText;
                
            }

            personas.Add(p);
            return personas;
        }

        public string personasStringXML(string nombreArchivo)
        {
            XmlDocument xmlDocument = new XmlDocument();
            if (File.Exists(String.Format("{0}./{1}.xml", Escritorio, nombreArchivo)))
            {
                xmlDocument.Load(String.Format("{0}./{1}.xml", Escritorio, nombreArchivo));
            }
            else
            {
                return
                        "<? xml version=\"1.0\" encoding=\"UTF-8\" ?>\n" +
                        String.Format(
                            "<personas>{0}</personas>",
                            ""
                        );
            }

            List<Persona> personas = cargarLista(xmlDocument);

            string personasTXT = "";
            personas.ForEach(a =>
            {
                personasTXT += String.Format("{0}\n", a);
            });

            return
            "<? xml version=\"1.0\" encoding=\"UTF-8\" ?>\n" +
            String.Format(
                "<personas>\n{0}</personas>",
                personasTXT
            );
        }
        public List<Persona> leerXML(string nombreArchivo)
        {
            XmlDocument xmlDocument = new XmlDocument();

            if (File.Exists(String.Format("{0}./{1}.xml", Escritorio, nombreArchivo)))
            {
                xmlDocument.Load(String.Format("{0}./{1}.xml", Escritorio, nombreArchivo));
                return cargarLista(xmlDocument);
            }

            return new List<Persona>();
        }
    }
}