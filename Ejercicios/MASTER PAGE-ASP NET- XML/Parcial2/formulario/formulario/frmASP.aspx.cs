using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace formulario
{
    public partial class frmASP : System.Web.UI.Page
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
                    InnerHtml = "Apellido : " + " " + getApellido()

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
                    InnerHtml = "Bloqueado: " + " " + getBloqueado()

                });

                HtmlTableRow fila5 = new HtmlTableRow();
                fila5.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Edad: " + " " + getEdad()

                });
                HtmlTableRow fila6 = new HtmlTableRow();
                fila6.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Antecedentes: " + " " + getAnt()

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
            TextBox apellido = (TextBox)Apellido1.FindControl("txtapellido");
            string valor = apellido.Text;
            return valor;
        }

        public string getNombre()

        {
            TextBox nombre = (TextBox)Nombre1.FindControl("txtnombre");
            string valor = nombre.Text;
            return valor;
        }

        public string getSexo()
        {
            RadioButtonList sex = (RadioButtonList)Sexo1.FindControl("RadioButtonList1");
            string valor = sex.SelectedValue;
            return valor;
        }


        public string getNac()
        {
            DropDownList nac = (DropDownList)Nacionalidad1.FindControl("DropDownList1");
            string valor = nac.SelectedValue;
            return valor;
        }

        public string getBloqueado()
        {
            string valor = "No";
            if (CheckBox.Checked)
            {
                valor = "Si";
            }
            return valor;

        }


        public string getEdad()
        {
            TextBox edad = (TextBox)Edad1.FindControl("txtedad");
            string valor = edad.Text;
            return valor;

        }

        public string getAnt()
        {
            TextBox ant = (TextBox)Antecedentes1.FindControl("txtante");
            string valor = ant.Text;
            return valor;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["Apellido"] = ((TextBox)Apellido1.FindControl("txtapellido")).Text;
            Session["Nombre"] = ((TextBox)Nombre1.FindControl("txtnombre")).Text;
            Session["Sexo"] = ((RadioButtonList)Sexo1.FindControl("RadioButtonList1")).Text;
            Session["Nacionalidad"] = ((DropDownList)Nacionalidad1.FindControl("DropDownList1")).Text;
            string bloq;
            if (CheckBox.Checked)
            {
                bloq = "Si";
            }
            else
            {
                bloq = "No";
            }
            Session["Bloqueado"] = bloq;
            Session["Edad"] = ((TextBox)Edad1.FindControl("txtedad")).Text;
            Session["Antecedentes"] = ((TextBox)Antecedentes1.FindControl("txtante")).Text;
            Page.Response.Redirect("DatosSesion.aspx");
        }
    }

}