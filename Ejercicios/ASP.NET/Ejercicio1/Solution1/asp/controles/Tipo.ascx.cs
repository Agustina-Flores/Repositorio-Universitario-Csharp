using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.controles
{
    public partial class Tipo : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBoxFechaVencimiento.Enabled = RadioButtonList1.SelectedIndex == 0;
            TextBoxFechaVencimiento.Visible = RadioButtonList1.SelectedIndex == 0;

            RFVFechaVencimiento.Enabled = RadioButtonList1.SelectedIndex == 0;
        }
    }
}