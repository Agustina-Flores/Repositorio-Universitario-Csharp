using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.controles
{
    public partial class Delegacion : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ValidarRadio(object source, ServerValidateEventArgs args)
        {
            if (radio.Items[0].Selected == false && radio.Items[1].Selected == false && radio.Items[2].Selected == false)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }
        public String getText()
        {
            return radio.SelectedItem.Text;
        }
    }
}