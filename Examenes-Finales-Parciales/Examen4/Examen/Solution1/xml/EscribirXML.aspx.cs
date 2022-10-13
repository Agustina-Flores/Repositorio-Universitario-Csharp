using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace xml
{
    public partial class EscribirXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btntabla_Click(object sender, EventArgs e)
        {
            int filas = int.Parse(txtfilas.Text);
            int columnas = int.Parse(txtcolumnas.Text);
            XmlTextWriter writer;
            writer = new XmlTextWriter(@"C:\Users\Agustina\Downloads\C#\FinalesLab3Hechos\EJ21\Examen\Solution1\xml\archivos\table.xml", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();
            writer.WriteStartElement("table");

            for (int i = 1; i < filas + 1; i++)
            {
                writer.WriteStartElement("tr");
                for (int j = 1; j < columnas + 1; j++)
                {
                    writer.WriteElementString("td", i.ToString() + "-" + j.ToString());
                }
                writer.WriteEndElement();
            }

            writer.WriteEndDocument();
            writer.Close();
        }
    }
}