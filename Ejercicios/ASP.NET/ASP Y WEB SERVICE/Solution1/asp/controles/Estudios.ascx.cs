using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.controles
{
    public partial class Estudios : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ValidarCheckBox(object source, ServerValidateEventArgs args)
        {
            if (cbEstudios.Items[0].Selected == false && cbEstudios.Items[1].Selected == false && cbEstudios.Items[2].Selected == false && cbEstudios.Items[3].Selected == false)
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
            return cbEstudios.SelectedItem.Text;
        }
    }
}