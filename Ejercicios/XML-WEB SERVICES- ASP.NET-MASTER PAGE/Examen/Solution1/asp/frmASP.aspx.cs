using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using asp.ServiceReference1;
using Modelo;
using WebService;
using Persona = Modelo.Persona;

namespace asp
{
    public partial class frmASP : System.Web.UI.Page
    {
        public static List<Persona> Personas = new List<Persona>();

        protected void reloadElements(object sender, EventArgs e)
        {
            Personas.ForEach(a =>
            {
                TableRow tableRow = new TableRow();

                TableCell[] tableCells = new TableCell[]
                {
                    new TableCell(),
                    new TableCell(),
                    new TableCell(),
                    new TableCell(),
                    new TableCell(),
                    new TableCell(),
                    new TableCell()
                };

                tableCells[0].Text = a.Apellido;
                tableCells[1].Text = a.Nombre;
                tableCells[2].Text = a.Sexo;
                tableCells[3].Text = a.Nacionalidad;
                tableCells[4].Text = a.Bloqueado ? "SI" : "NO";                              
                tableCells[5].Text = a.Edad;                
                tableCells[6].Text = a.Antecedentes;

                foreach (TableCell tableCell in tableCells)
                {
                    tableRow.Cells.Add(tableCell);
                }

                TableDatos.Rows.Add(tableRow);
            });
        }

        protected void loadDatosXML(object sender, EventArgs e)
        {
            XMLWebService xMLWebService = new XMLWebService();
            datosxml.InnerText = xMLWebService.personasStringXML("personas");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            reloadElements(sender, e);
            loadDatosXML(sender, e);
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Personas.Add(
              new Persona()
              {
                  Bloqueado = CheckBox1.Checked,
                  Sexo = RadioButtonList1.SelectedValue,
                  Apellido = ((TextBox)NombreApellido.FindControl("txtapellido")).Text,
                  Nombre = ((TextBox)NombreApellido.FindControl("txtnombre")).Text,
                  Edad = ((TextBox)Edad.FindControl("txtedad")).Text,
                  Nacionalidad = ((DropDownList)Nacionalidad.FindControl("DropDownList1")).SelectedValue,
                  Antecedentes = txtant.Text,


              }
          );
             
            Page.Response.Redirect("frmASP.aspx");
        }

        protected void btnSesion_Click(object sender, EventArgs e)
        {
            Session["Bloqueado"] = CheckBox1.Checked;
            Session["Sexo"] = RadioButtonList1.SelectedValue;
            Session["Apellido"] = ((TextBox)NombreApellido.FindControl("txtapellido")).Text;
            Session["Nombre"] = ((TextBox)NombreApellido.FindControl("txtnombre")).Text;
            Session["Edad"] = ((TextBox)Edad.FindControl("txtedad")).Text;
            Session["Nacionalidad"] = ((DropDownList)Nacionalidad.FindControl("DropDownList1")).Text;
            Session["Antecedentes"] = txtant.Text;
            Page.Response.Redirect("DatosSesionXML.aspx");
        }
    }
}