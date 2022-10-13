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
            Label1.Text = Session["Denominacion"].ToString();
            Label2.Text = Session["Rubro"].ToString();
            Label3.Text = Session["Tipo"].ToString();
            Label7.Text = Session["Fecha Vencimiento"].ToString();
            Label4.Text = Session["Stock Actual"].ToString();
            Label5.Text = Session["Categoria Venta"].ToString();
            Label6.Text = Session["Descripcion"].ToString();
        }
    }
}