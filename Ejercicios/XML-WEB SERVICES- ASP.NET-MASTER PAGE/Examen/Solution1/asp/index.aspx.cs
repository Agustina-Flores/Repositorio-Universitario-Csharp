using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebService;

namespace asp
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XMLWebService xMLWebService = new XMLWebService();

            string personasTXT = "";
            xMLWebService.leerXML("personas").ForEach(a =>
            {
                personasTXT += String.Format(

                        "<div>" +
                            "<div>" +
                                "<b>Apellido: </b>" +
                                "<span>{0}</span>" +
                            "</div>" +
                            "<div>" +
                                "<b>Nombre: </b>" +
                                "<span>{1}</span>" +
                            "</div>" +

                        "<div>" +
                            "<b>Edad: </b>" +
                            "<span>{2}</span>" +
                        "</div>" +
                        "<div>" +
                            "<b>Nacionalidad: </b>" +
                            "<span>{3}</span>" +
                        "</div>" +
                        "<div>" +
                            "<b>Antecedentes: </b>" +
                            "<span>{4}</span>" +
                        "</div>" +
                        "<div>" +
                    "</div>",
                    a.Apellido,
                    a.Nombre,
                    a.Edad,
                    a.Nacionalidad,
                    a.Antecedentes

                );
            });

            personas.InnerHtml = personasTXT;
        }
    }
}