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
            Label2.Text = Session["Denominacion"].ToString();
            Label4.Text = Session["Rubro"].ToString();
            Label6.Text = Session["Tipo"].ToString();
            Label8.Text = Session["Stock Actual"].ToString();
            Label10.Text = Session["Categoria Venta"].ToString();
            Label12.Text = Session["Descripcion"].ToString();

        }
    }
}