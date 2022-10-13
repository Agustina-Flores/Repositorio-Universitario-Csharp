using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace formulario
{
    public partial class DatosSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["Apellido"].ToString();
            Label2.Text = Session["Nombre"].ToString();
            Label3.Text = Session["Sexo"].ToString();
            Label4.Text = Session["Nacionalidad"].ToString();
            Label5.Text = Session["Bloqueado"].ToString();
            Label6.Text = Session["Edad"].ToString();
            Label7.Text = Session["Antecedentes"].ToString();
          
        }
    }
}