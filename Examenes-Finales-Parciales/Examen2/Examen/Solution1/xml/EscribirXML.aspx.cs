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
        protected void crearXml()
        {
            XDocument miXML = new XDocument(
       new XDeclaration("1.0", "utf-8", "yes"),
       new XElement("result",
           new XElement("permisos",
               new XElement("permiso",
                   new XAttribute("tipo", "Comision Diaria"),
                   new XElement("id", "229"),
                   new XElement("sector", "Forestales"),
                   new XElement("consejo", "NO POSEE")),
              new XElement("permiso",
                   new XAttribute("tipo", "Razones Particulares"),
                   new XElement("id", "381"),
                   new XElement("sector", "Alumbrado Publico - Mantenimiento"),
                   new XElement("consejo", "NO POSEE"))
           ) //Cierra permisos
       )); //Cierra XDocument y result
 miXML.Save(@"C:\\Users\\Agustina\\Downloads\\C#\\FinalesLab3Hechos\\EF\\Examen\\Solution1\\xml\\archivos\\xmlsector.xml");
        }
        protected void btnguardar_Click(object sender, EventArgs e)
        {
            crearXml();
            //Muestra alerta cuando se escribe el XML
            string script = "alert(\"XML Escrito exitosamente!\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);
        }
    }
}