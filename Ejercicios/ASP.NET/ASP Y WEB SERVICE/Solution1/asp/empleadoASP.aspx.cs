using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace asp
{
    public partial class empleadoASP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {


            if (Estudios.getText().Equals("Secundario Incompleto") && Delegacion.getText().Equals("Sede Central"))
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }

        }
        protected void btnguardar_Click(object sender, EventArgs e)
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
                    InnerHtml = "Dni: " + " " + getDni()

                });



                HtmlTableRow fila3 = new HtmlTableRow();
                fila3.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Tipo de Contrato : " + " " + getTipo()

                });

                HtmlTableRow fila4 = new HtmlTableRow();
                fila4.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Regimen Laboral: " + " " + getRegimen()

                });

                HtmlTableRow fila5 = new HtmlTableRow();
                fila5.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Delegacion: " + " " + getDelegacion()

                });

                HtmlTableRow fila6 = new HtmlTableRow();
                fila6.Controls.Add(new HtmlTableCell
                {
                    InnerHtml = "Estudios : " + " " + getEstudios()

                });
                HtmlTableRow fila7 = new HtmlTableRow();
                fila7.Controls.Add(new HtmlTableCell
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
                tabla.Controls.Add(fila6);
                tabla.Controls.Add(fila7);
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
        public string getDni()
        {
            TextBox codigo = (TextBox)Dni.FindControl("txtdni");
            string valor = codigo.Text;
            return valor;
        }

        public string getTipo()
        {
            DropDownList codigo = (DropDownList)TipoContrato.FindControl("DropDownList1");
            string valor = codigo.Text;
            return valor;
        }
        public string getRegimen()
        {

            string valor = DropDownList1.SelectedValue;
            return valor;
        }

        public string getDelegacion()
        {
            RadioButtonList codigo = (RadioButtonList)Delegacion.FindControl("radio");
            string valor = codigo.Text;
            return valor;
        }

        public string getEstudios()
        {
            CheckBoxList codigo = (CheckBoxList)Estudios.FindControl("cbEstudios");
            string valor = codigo.Text;
            return valor;
        }

        public string getDescripcion()
        {

            string valor = txtdes.Text;
            return valor;
        }

        protected void btnSesion_Click(object sender, EventArgs e)
        {
            Session["Apellido"] = txtapellido.Text;
            Session["Nombre"] =  txtnombre.Text;
            Session["Dni"] = ((TextBox)Dni.FindControl("txtdni")).Text;
            Session["Tipo Contrato"] = ((DropDownList)TipoContrato.FindControl("DropDownList1")).SelectedValue;
            Session["Regimen Laboral"] = DropDownList1.SelectedValue;
            Session["Delegacion"] = ((RadioButtonList)Delegacion.FindControl("radio")).Text;
            Session["Estudios"] = ((CheckBoxList)Estudios.FindControl("cbEstudios")).Text;
            Session["Descripcion"] = txtdes.Text;
            Page.Response.Redirect("resultadoASP.aspx");
        }
    }
    }
 
 
 