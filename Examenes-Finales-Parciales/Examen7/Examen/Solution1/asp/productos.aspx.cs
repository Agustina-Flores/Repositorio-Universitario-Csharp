using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace asp
{
    public partial class productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                HtmlTableRow fila0 = new HtmlTableRow();
                fila0.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Denominacion : " + " " + getDenominacion()

                });

                HtmlTableRow fila1 = new HtmlTableRow();
                fila1.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Rubro : " + " " + getRubro()

                });

                HtmlTableRow fila2 = new HtmlTableRow();
                fila2.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Tipo : " + " " + getTipo()

                });

                HtmlTableRow fila3 = new HtmlTableRow();
                fila3.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Stock Actual : " + " " + getStock()

                });

                HtmlTableRow fila4 = new HtmlTableRow();
                fila4.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Categoria Venta: " + " " + getCategoria()

                });

                HtmlTableRow fila5 = new HtmlTableRow();
                fila5.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Descripcion: " + " " + getDes()

                });
               

                HtmlTable tabla = new HtmlTable();
                tabla.Controls.Add(fila0);
                tabla.Controls.Add(fila1);
                tabla.Controls.Add(fila2);
                tabla.Controls.Add(fila3);
                tabla.Controls.Add(fila4);
                tabla.Controls.Add(fila5);
              
                div1.Controls.Add(tabla);
            }

        }

        public string getDenominacion()
        {

            string valor = txtden.Text;
            return valor;

        }

        public string getRubro()
        {

            DropDownList tipoc = (DropDownList)Rubro1.FindControl("DropDownList1");
            string valor = tipoc.Text;
            return valor;

        }

        public string getTipo()
        {
            RadioButtonList rl = (Tipo.FindControl("RadioButtonList1") as RadioButtonList);

            string tipo = String.Empty;
            string fechaVencimiento = String.Empty;

            if (rl.SelectedIndex == 0)
            {
                tipo = rl.SelectedValue;// Vencimiento
                fechaVencimiento = (Tipo.FindControl("TextBoxFechaVencimiento") as TextBox).Text;

            }
            else
            {
                tipo = rl.SelectedValue; //Sin Vencimiento
            }

            return tipo;
        }


        public string getStock()
        {

            string valor = txtstock.Text;
            return valor;

        }

        public string getCategoria()
        {
            CheckBoxList est = (CheckBoxList)CategoriaVenta.FindControl("CheckBoxList1");
            string valor = est.Text;
            return valor;
        }

        public string getDes()
        {

            string valor = txtdes.Text;
            return valor;

        }

        protected void btnSesion_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Session["Denominacion"] = txtden.Text;
                Session["Rubro"] = ((DropDownList)Rubro1.FindControl("DropDownList1")).Text;
                Session["Tipo"] = ((RadioButtonList)Tipo.FindControl("RadioButtonList1")).Text;
                Session["Fecha Vencimiento"] = ((TextBox)Tipo.FindControl("TextBoxFechaVencimiento")).Text;
                Session["Stock Actual"] = txtstock.Text;
                Session["Categoria Venta"] = ((CheckBoxList)CategoriaVenta.FindControl("CheckBoxList1")).Text;
                Session["Descripcion"] = txtdes.Text;
                Page.Response.Redirect("resultadoASP.aspx");
            }
        }
    }
}
 