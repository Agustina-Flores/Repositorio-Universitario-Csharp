using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            //Guardar.Enabled = true;
            //this.Guardar.Visible = true;//false
            this.Sesion.Enabled = false;
          this.Sesion.Visible = false;//true
            Response.Redirect("empleadoASP.aspx");
        }

        protected void SesionButton_Click(object sender, EventArgs e)
        {
            // Sesion.Enabled = true;
            //this.Sesion.Visible = true; //false
            this.Guardar.Enabled = false;
          this.Guardar.Visible = false; //true
            Response.Redirect("resultadoASP.aspx");
        }
    }
}