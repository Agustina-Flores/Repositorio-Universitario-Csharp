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
                    InnerHtml = "Categoria Venta : " + " " + getCategoriaVenta()

                });

                HtmlTableRow fila5 = new HtmlTableRow();
                fila5.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Descripcion : " + " " + getDescripcion()

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
            string articulo = txtdeno.Text;
            return articulo;
        }

        public string getRubro()
        {
            DropDownList rubro = (DropDownList)Rubro.FindControl("DropDownList1");
            string valor = rubro.Text;
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
            string stock = txtstock.Text;
            return stock;
        }
        public string getCategoriaVenta()
        {
            CheckBoxList t = (CheckBoxList)CategoriaVenta.FindControl("CheckBoxList1");
            string valor = t.Text;
            return valor;
        }
        public string getDescripcion()
        {
            string des = txtdes.Text;
            return des;
        }

        protected void btnSesion_Click(object sender, EventArgs e)
        {
            
            Session["Denominacion"] = txtdeno.Text;
            Session["Rubro"] = ((DropDownList)Rubro.FindControl("DropDownList1")).SelectedValue;
            Session["Tipo"] = ((RadioButtonList)Tipo.FindControl("RadioButtonList1")).SelectedValue;
            Session["Stock Actual"] = txtstock.Text;
            Session["Categoria Venta"] = ((CheckBoxList)Tipo.FindControl("CheckBoxList1")).SelectedValue;
            Session["Descripcion"] = txtdes.Text;
            
            
            Page.Response.Redirect("resultadoASP.aspx");
        }
    }
}