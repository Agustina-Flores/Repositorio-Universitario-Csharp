using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
namespace xml
{
    public partial class EscribirXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CrearXml()
        {
            XDocument xml = new XDocument(
           // new XDeclaration("1.0", "utf-8", "yes"),
            new XElement("equipos",
            new XElement("equipo",
            new XAttribute("nombre", "Sacachispas"),
                new XElement("jugador",
                new XAttribute("puesto", "defensor"),
                     new XElement("numero", "2"),
                    new XElement("apellido", "Matons"),
                    new XElement("nombre", "Carlos")),
                new XElement("jugador",
                     new XAttribute("puesto", "delantero"),
                     new XElement("numero", "9"),
                    new XElement("apellido", "Lopez"),
                    new XElement("nombre", "Juan Carlos")) 
            )));
            xml.Save(@"C:\Users\Agustina\Downloads\datosxml\xmlequipo.xml");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            CrearXml();
            //Muestra alerta cuando se escribe el XML
            string script = "alert(\"XML Escrito exitosamente!\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);
        }
    }
}