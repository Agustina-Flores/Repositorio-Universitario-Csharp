using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace formulario
{
    public partial class EscribiirXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void crearXml()
        {
            XDocument miXML = new XDocument(
       new XDeclaration("1.0", "utf-8", "yes"),
       new XElement("result",
       new XElement("mesAnio",
        new XAttribute("anio", "2018"),
        new XAttribute("mes", "10")),
           new XElement("permisos",
               new XElement("permiso",
                   new XAttribute("tipoPermiso", "Razones Particulares"),
                   new XElement("codigo", "229"),
                   new XElement("sector", "Forestales"),
                   new XElement("habilitado", "SI")),
              new XElement("permiso",
                   new XAttribute("tipoPermiso", "Gremial"),
                   new XElement("codigo", "381"),
                   new XElement("sector", "Alumbrado Publico - Mantenimiento"),
                   new XElement("habilitado", "NO"))
           ) //Cierra permisos
       )); //Cierra XDocument y result
            miXML.Save(@"C:\\Users\\Agustina\\Downloads\\datosxml\\xmlpermisoshabilitado.xml");
        }
        protected void btnEscribir_Click(object sender, EventArgs e)
        {
            crearXml();
            //Muestra alerta cuando se escribe el XML
            string script = "alert(\"XML Escrito exitosamente!\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);
        }
    }
}