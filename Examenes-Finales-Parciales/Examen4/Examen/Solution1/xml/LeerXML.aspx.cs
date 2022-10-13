using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Xml;

namespace xml
{
    public partial class LeerXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            leerXML();
        }

        public void leerXML()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"C:\Users\Agustina\Downloads\C#\FinalesLab3Hechos\EJ21\Examen\Solution1\xml\archivos\table.xml");

            XmlElement tr = xDoc.DocumentElement;
            int contadorTR = tr.ChildNodes.Count;
            XmlNodeList td = xDoc.SelectNodes("/table/tr");
            int contadorTD = td.Count;

            div1.InnerText = contadorTR.ToString() + ", " + contadorTD.ToString();
            crearTabla(contadorTR, contadorTD);
        }

        public void crearTabla(int filas, int columnas)
        {
            HtmlTable tabla = new HtmlTable();
            for (int i = 1; i < filas + 1; i++)
            {
                HtmlTableRow fila = new HtmlTableRow();
                for (int j = 1; j < columnas + 1; j++)
                {
                    int valor = i + j;
                    fila.Controls.Add(new HtmlTableCell { InnerHtml = valor.ToString() });
                }
                tabla.Controls.Add(fila);
            }
            div1.Controls.Add(tabla);
        }
    }
}