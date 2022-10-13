using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp
{
    public partial class resultadoASP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["Apellido"].ToString();
            Label2.Text = Session["Nombre"].ToString();
            Label3.Text = Session["Dni"].ToString();
            Label7.Text = Session["Tipo Contrato"].ToString();
            Label4.Text = Session["Regimen Laboral"].ToString();
            Label5.Text = Session["Delegacion"].ToString();
            Label6.Text = Session["Estudios"].ToString();
            Label8.Text = Session["Descripcion"].ToString();
        }
    }
}