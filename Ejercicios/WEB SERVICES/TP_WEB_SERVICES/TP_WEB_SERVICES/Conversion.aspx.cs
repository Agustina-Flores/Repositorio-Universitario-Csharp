using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_WEB_SERVICES
{
    public partial class Conversion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Convert con = new Convert();
            txtResultado.Text = con.Convertir(double.Parse(txtN.Text), DropUnidad1.SelectedValue.ToString(), DropUnidad2.SelectedValue.ToString()).ToString();
        }
    }
}