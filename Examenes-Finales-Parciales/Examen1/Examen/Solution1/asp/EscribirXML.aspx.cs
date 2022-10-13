using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
namespace asp
{
    public partial class EscribirXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CrearXml()
        {
            XDocument xml = new XDocument(
            new XDeclaration("1.0", "utf-8", "yes"),
            new XElement("rol",
            new XAttribute("id", "123"),
            new XAttribute("nombre", "Empleado"),
                new XElement("permisos",
                new XElement("permiso",
                    new XAttribute("tipo", "L"),
                    new XElement("id", "229"),
                    new XElement("nombre", "Reporte Asistencia")),
                new XElement("permiso",
                    new XAttribute("tipo", "LW"),
                    new XElement("id", "381"),
                    new XElement("nombre", "Administrar Novedad")),
                new XElement("permiso",
                    new XAttribute("tipo", "LW"),
                    new XElement("id", "402"),
                    new XElement("nombre", "Datos Personales"))
            )
            ));
            xml.Save(@"C:\Users\Agustina\Downloads\C#\FinalesLab3Hechos\EAb\Examen\Solution1\archivo\xml.xml");
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
 
 