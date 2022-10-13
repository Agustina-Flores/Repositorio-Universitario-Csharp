using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace formulario
{
    public class XMLPersona
    {
        public XmlWriter XmlWriter { get; set; }
        public XMLPersona()
        {

        }



        public XMLPersona(string nombreArchivo, List<Persona> personas)
        {

            XmlWriter = XmlWriter.Create("data.xml");
            XmlWriter.WriteStartDocument();
            XmlWriter.WriteStartElement("personas");
            personas.ForEach(a =>
            {
                XmlWriter.WriteStartElement("persona");
                XmlWriter.WriteAttributeString("bloqueado", a.bloqueado);

                XmlWriter.WriteStartElement("datosPersonales");
                XmlWriter.WriteAttributeString("sexo", a.sexo);

                XmlWriter.WriteStartElement("apellido");
                XmlWriter.WriteValue(a.apellido);
                XmlWriter.WriteEndElement();

                XmlWriter.WriteStartElement("nombre");
                XmlWriter.WriteValue(a.edad);
                XmlWriter.WriteEndElement();

                XmlWriter.WriteStartElement("nacionalidad");
                XmlWriter.WriteValue(a.nacionalidad);
                XmlWriter.WriteEndElement();

                XmlWriter.WriteStartElement("antecedente");
                XmlWriter.WriteValue(a.antecedentes);
                XmlWriter.WriteEndElement();

            });
            XmlWriter.WriteEndElement();
            XmlWriter.WriteEndDocument();
            XmlWriter.Close();
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
                //Boolean esNuevo = !File.Exists(String.Format("{0}./{1}.xml", Escritorio, nombreArchivo));
                /*
                if (esNuevo)
                {
                    /*
                       Agrega el nodo articulos al final de la raiz del xml
                       es decir va a ser futuro hermano de la etiqueta <xml/>
                    */
                // XmlWriter = XmlWriter.Create(String.Format("{0}./{1}.xml", Escritorio, nombreArchivo), new XmlWriterSettings() { Indent = true });
                // XmlWriter.WriteStartDocument();
                // XmlWriter.WriteStartElement("articulos");
                // XmlWriter.WriteEndElement();
                // XmlWriter.WriteEndDocument();
                // XmlWriter.Close();
                //}

                xmlDocument.Load("data.xml");


                //Crear nuevo elemento <articulo/>
                XmlElement persona = xmlDocument.CreateElement("persona");
                XmlAttribute bloqueado = xmlDocument.CreateAttribute("bloqueado");
                bloqueado.InnerText = a.bloqueado;
                persona.Attributes.Append(bloqueado);

                XmlElement datos = xmlDocument.CreateElement("datosPersonales");
                XmlAttribute sexo = xmlDocument.CreateAttribute("sexo");
                sexo.InnerText = a.sexo;
                persona.Attributes.Append(sexo);

                XmlElement apellido = xmlDocument.CreateElement("apellido");
                apellido.InnerText = a.apellido;
                persona.AppendChild(apellido);

                XmlElement nombre = xmlDocument.CreateElement("nombre");
                nombre.InnerText = a.nombre;
                persona.AppendChild(nombre);

                XmlElement edad = xmlDocument.CreateElement("edad");
                edad.InnerText = a.edad;
                persona.AppendChild(edad);

                XmlElement nacionalidad = xmlDocument.CreateElement("nacionalidad");
                nacionalidad.InnerText = a.nacionalidad;
                persona.AppendChild(nacionalidad);

                XmlElement antecedentes = xmlDocument.CreateElement("antecedentes");
                antecedentes.InnerText = a.antecedentes;
                persona.AppendChild(antecedentes);


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


                xmlDocument.Save("@C:\\Users\\Agustina\\Downloads\\datosxml");
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
    }
}