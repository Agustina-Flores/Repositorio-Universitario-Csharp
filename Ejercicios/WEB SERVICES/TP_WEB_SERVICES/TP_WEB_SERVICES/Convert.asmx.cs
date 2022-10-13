using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TP_WEB_SERVICES
{
    /// <summary>
    /// Summary description for Convert
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Convert : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public double Convertir(double n1, String u1, String u2)
        {
            double nConvertido = 0;
            if (u1.Equals("kilometro"))
            {
                if (u2.Equals("kilometro"))
                {
                    nConvertido = n1;
                }else if (u2.Equals("metro"))
                {
                    nConvertido = n1 * 1000;
                }else if (u2.Equals("decimetro"))
                {
                    nConvertido = n1 * 10000;
                }else if (u2.Equals("centimetro"))
                {
                    nConvertido = n1 * 100000;
                }else if (u2.Equals("milimetro"))
                {
                    nConvertido = n1 * 1000000;
                }else if (u2.Equals("micrometro"))
                {
                    nConvertido = n1 * 1000000000;
                }
            }else if (u1.Equals("micrometro"))
            {
                if (u2.Equals("kilometro"))
                {
                    nConvertido = n1 * 0.000000001;
                }else if (u2.Equals("metro"))
                {
                    nConvertido = n1 * 0.000001;
                }else if (u2.Equals("decimetro"))
                {
                    nConvertido = n1 * 0.00001;
                }else if (u2.Equals("centimetro"))
                {
                    nConvertido = n1 * 0.0001;
                }else if (u2.Equals("milimetro"))
                {
                    nConvertido = n1 * 0.001;
                }else if (u2.Equals("micrometro"))
                {
                    nConvertido = n1;
                }
            }
            return nConvertido;
        }
    }
}
