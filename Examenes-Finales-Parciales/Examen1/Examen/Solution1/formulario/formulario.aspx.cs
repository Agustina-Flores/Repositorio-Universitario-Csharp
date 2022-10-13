using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace formulario
{
    public partial class formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                HtmlTableRow fila0 = new HtmlTableRow();
                fila0.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Apellido  : " + " " + getApellido()

                });

                HtmlTableRow fila1 = new HtmlTableRow();
                fila1.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Nombre : " + " " + getNombre()

                });

                HtmlTableRow fila2 = new HtmlTableRow();
                fila2.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Sexo : " + " " + getSexo()

                });

                HtmlTableRow fila3 = new HtmlTableRow();
                fila3.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Nacionalidad : " + " " + getNac()

                });

                HtmlTableRow fila4 = new HtmlTableRow();
                fila4.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Bloqueado : " + " " + getBloqueado()

                });

                HtmlTableRow fila5 = new HtmlTableRow();
                fila5.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Edad : " + " " + getEdad()

                });
                HtmlTableRow fila6 = new HtmlTableRow();
                fila6.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Antecedentes : " + " " + getAnt()

                });

                HtmlTable tabla = new HtmlTable();
                tabla.Controls.Add(fila0);
                tabla.Controls.Add(fila1);
                tabla.Controls.Add(fila2);
                tabla.Controls.Add(fila3);
                tabla.Controls.Add(fila4);
                tabla.Controls.Add(fila5);
                tabla.Controls.Add(fila6);
                div1.Controls.Add(tabla);
            }



        }

        public string getApellido()
        {
            string valor = txtapellido.Text;

            return valor;
        }

        public string getNombre()
        {
            string valor = txtnombre.Text;

            return valor;
        }
        public string getBloqueado()
        {
            string valor = "No";
            if (checkbox.Checked)
            {
                valor = "Si";
            }
            return valor;
        }

        public string getEdad()
        {
            string valor = txtedad.Text;

            return valor;
        }


        public string getNac()
        {
            string valor = DropDownList1.SelectedValue;
            ;
            return valor;
        }
        public string getAnt()
        {
            string valor = txtant.Text;

            return valor;
        }
        public string getSexo()
        {
            string valor = RadioButtonList1.Text;

            return valor;
        }
        protected void txtapellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 