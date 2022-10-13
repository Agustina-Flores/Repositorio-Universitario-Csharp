﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace asp
{
    public partial class articuloASP : System.Web.UI.Page
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
                    InnerHtml = "Articulo : " + " " + getArticulo()

                });

                HtmlTableRow fila1 = new HtmlTableRow();
                fila1.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Codigo Barras : " + " " + getCodigo()

                });

                HtmlTableRow fila2 = new HtmlTableRow();
                fila2.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Porcentaje Descuento : " + " " + getPorcentaje()

                });



                HtmlTableRow fila3 = new HtmlTableRow();
                fila3.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Rubro : " + " " + getRubro()

                });

                HtmlTableRow fila4 = new HtmlTableRow();
                fila4.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Vencimiento: " + " " + getVencimiento()

                });

                HtmlTableRow fila5 = new HtmlTableRow();
                fila5.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Precio: " + " " + getPrecio()

                });
                HtmlTableRow fila6 = new HtmlTableRow();
                fila6.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "En Promocion: " + " " + getPromocion()

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

        public string getArticulo()
        {
            string valor = txtArticulo.Text;
            return valor;
        }

        public string getCodigo()
        {
            TextBox codigo = (TextBox)CodigoBarra.FindControl("txtcodigo");
            string valor = codigo.Text;
            return valor;
        }

        public string getPorcentaje()
        {
            string valor = txtporcentaje.Text;
            return valor;
        }

        public string getRubro()
        {
            DropDownList rubro = (DropDownList)Rubro.FindControl("DropDownList1");
            string valor = rubro.Text;
            return valor;
        }

        public string getVencimiento()
        {
            RadioButtonList ven = (RadioButtonList)Vencimiento.FindControl("RadioButtonList1");
            string valor = ven.Text;
            return valor;
        }

        public string getPrecio()
        {
            string valor = txtprecio.Text;
            return valor;
        }
        public string getPromocion()
        {
            string valor = "No";
            if(CheckBox1.Checked)
            {
                valor = "Si";
            }
            return valor;
        }
    }
}