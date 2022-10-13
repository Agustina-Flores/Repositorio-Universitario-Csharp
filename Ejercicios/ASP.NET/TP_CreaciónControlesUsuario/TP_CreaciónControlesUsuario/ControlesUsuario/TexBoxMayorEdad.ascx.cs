using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_CreaciónControlesUsuario.ControlesUsuario
{
    public partial class TexBoxMayorEdad : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (int.Parse(args.Value) >= 18)
            {
                args.IsValid=true;
            }else
            {
                args.IsValid = false;
            }
        }
    }
}