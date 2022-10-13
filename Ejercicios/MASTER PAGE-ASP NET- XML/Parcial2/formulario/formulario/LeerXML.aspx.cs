using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Xml;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace formulario
{
    public partial class LeerXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CrearXml()

        {
            XDocument miXML = new XDocument(
            new XDeclaration("1.0", "utf-8", "yes"),
            new XElement("sectores",
                new XElement("totalPages", "15"),
                new XElement("sector",
                        new XElement("codigo", "104"),
                        new XElement("denominacion", "Seccional 10: Lavalle"),
                        new XElement("ubicacion",
                        new XAttribute("localidad", "Bowen"),
                        new XElement("ubicacion", "Zona Sur")),
                        new XElement("fechaAlta", "15/06/2011"),
                   new XElement("encargado",
                   new XAttribute("existe", "SI"),
                        new XElement("apellido", "Perez"),
                        new XElement("nombre", "Alberto"),
                        new XElement("legajo", "60102"))),//Cierra permisos
                        new XElement("sector",
                        new XElement("codigo", "105"),
                        new XElement("denominacion", "Seccional 11: Junnin"),
                        new XElement("ubicacion",
                        new XAttribute("localidad", "Junin"),
                        new XElement("ubicacion", "Zona Este")),
                        new XElement("fechaAlta", "12/12/2012"),
                   new XElement("encargado",
                   new XAttribute("existe", "NO"))
            ))); //Cierra XDocument y result
            miXML.Save(@"C:\Users\Agustina\Downloads\datosxml\xmlsectoresencargado.xml");
        }



        public void leerXML()
        {
            // Create an XML reader for this file.
            using (XmlReader reader = XmlReader.Create("C:\\Users\\Agustina\\Downloads\\datosxml\\xmlsectoresencargado.xml"))
            {
                while (reader.Read())
                {
                    // Only detect start elements.
                    if (reader.IsStartElement())
                    {
                        // Get element name and switch on it.
                        switch (reader.Name)
                        {
                            case "sectores":
                                // Detect this element.
                                myDiv.InnerHtml = "Elementos Sectores.";
                                break;
                            case "totalPages":
                                // Detect this element.
                                myDiv.InnerHtml = myDiv.InnerText + "<br>Elemento Total Pages.";
                                // Next read will contain text.
                                if (reader.Read())
                                {
                                    myDiv.InnerHtml = myDiv.InnerText + "<br>   Valor: " + reader.Value.Trim();
                                }
                                break;
                            case "sector":
                                // Detect this element.
                                myDiv.InnerHtml = myDiv.InnerText + "<br>Elementos Sector.";
                                break;
                            case "codigo":
                                // Detect this article element.
                                myDiv.InnerHtml = myDiv.InnerText + "<br>Elemento codigo";
                                // Next read will contain text.
                                if (reader.Read())
                                {
                                    myDiv.InnerHtml = myDiv.InnerText + "<br>   Valor: " + reader.Value.Trim();
                                }
                                break;
                            case "denominacion":
                                // Detect this article element.
                                myDiv.InnerHtml = myDiv.InnerText + "<br>Elemento denominacion.";
                                // Next read will contain text.
                                if (reader.Read())
                                {
                                    myDiv.InnerHtml = myDiv.InnerText + "<br>   Valor: " + reader.Value.Trim();
                                }
                                break;
                            case "ubicacion":
                                // Detect this article element.
                                myDiv.InnerHtml = myDiv.InnerText + "<br>Elemento ubicacion.";
                                // Search for the attribute name on this current node.
                                string attribute = reader["localidad"];
                                if (attribute != null)
                                {
                                    myDiv.InnerHtml = myDiv.InnerText + "<br>   Atributo localidad: " + attribute;
                                }
                                // Next read will contain text.
                                if (reader.Read())
                                {
                                    myDiv.InnerHtml = myDiv.InnerText + "<br>   Valor: " + reader.Value.Trim();
                                }
                                break;
                            case "fechaAlta":
                                // Detect this article element.
                                myDiv.InnerHtml = myDiv.InnerText + "<br>Elemento fecha Alta.";
                                // Next read will contain text.
                                if (reader.Read())
                                {
                                    myDiv.InnerHtml = myDiv.InnerText + "<br>   Valor: " + reader.Value.Trim();
                                }
                                break;
                            case "encargado":
                                // Detect this article element.
                                myDiv.InnerHtml = myDiv.InnerText + "<br>Elemento encargado.";
                                // Search for the attribute name on this current node.
                                string attribute2 = reader["existe"];
                                if (attribute2 != null)
                                {
                                    myDiv.InnerHtml = myDiv.InnerText + "<br>   Atributo existe: " + attribute2;
                                }
                                break;
                            case "apellido":
                                // Detect this article element.
                                myDiv.InnerHtml = myDiv.InnerText + "<br>Elemento apellido.";
                                // Next read will contain text.
                                if (reader.Read())
                                {
                                    myDiv.InnerHtml = myDiv.InnerText + "<br>   Valor: " + reader.Value.Trim();
                                }
                                break;
                            case "nombre":
                                // Detect this article element.
                                myDiv.InnerHtml = myDiv.InnerText + "<br>Elemento nombre.";
                                // Next read will contain text.
                                if (reader.Read())
                                {
                                    myDiv.InnerHtml = myDiv.InnerText + "<br>   Valor: " + reader.Value.Trim();
                                }
                                break;
                            case "legajo":
                                // Detect this article element.
                                myDiv.InnerHtml = myDiv.InnerText + "<br>Elemento legajo.";
                                // Next read will contain text.
                                if (reader.Read())
                                {
                                    myDiv.InnerHtml = myDiv.InnerText + "<br>   Valor: " + reader.Value.Trim();
                                }
                                break;
                        }
                    }
                }
            }
        }

        protected void btnLeer_Click(object sender, EventArgs e)
        {
            CrearXml();
            leerXML();
        }
    }
}