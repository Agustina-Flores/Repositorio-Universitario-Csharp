using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebServiceCliente.ServiceReference1;
namespace WebServiceCliente
{
    public partial class WebForm : System.Web.UI.Page
    {
        int num1, num2, resultado;

        protected void btnSumar_Click(object sender, EventArgs e)
        {

            ServiceReference1.WebServiceSoapClient sumar = new ServiceReference1.WebServiceSoapClient();
            num1 = Convert.ToInt32(TextBox1.Text);
            num2 = Convert.ToInt32(TextBox2.Text);
            resultado = sumar.Sumar(num1, num2);
            Label4.Text = resultado.ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}