using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;
using WebService;

namespace asp
{
    public partial class DatosSesionXML : System.Web.UI.Page
    {
        protected void loadDatosXML(object sender, EventArgs e)
        {
            XMLWebService xMLWebService = new XMLWebService();
            datosxml.InnerText = xMLWebService.personasStringXML("personas");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Persona a = new Persona()
                {
                    Apellido = Session["Apellido"].ToString(),
                    Nombre = Session["Nombre"].ToString(),
                    Sexo = Session["Sexo"].ToString(),
                    Nacionalidad = Session["Nacionalidad"].ToString(),
                    Bloqueado = Session["Bloqueado"].Equals("SI"),                   
                    Edad = Session["Edad"].ToString(),
                    Antecedentes = Session["Antecedentes"].ToString()

                };
                XMLWebService xMLWebService = new XMLWebService();
                xMLWebService.AddPersona("personas", a);

            }
            catch (Exception)
            {

            }


            loadDatosXML(sender, e);
        }
    }
}