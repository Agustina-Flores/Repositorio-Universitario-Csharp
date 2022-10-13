using System.Collections.Generic;
using System.Web.Services;
using WebService.XML;
using Modelo;
using System.Web;

namespace WebService
{
    /// <summary>
    /// Summary description for XMLWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class XMLWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public void AddPersona(string nombrearchivo, Persona persona)
        {
            new XMLPersona(nombrearchivo, persona);
        }
        [WebMethod]
        public string personasStringXML(string nombreArchivo)
        {
            return new XMLPersona().personasStringXML(nombreArchivo);
        }

        [WebMethod]
        public List<Persona> leerXML(string nombreArchivo)
        {
            return new XMLPersona().leerXML(nombreArchivo);
        }
        [WebMethod]
        public string getPersonaXML()
        {
            return "<? xml version=\"1.0\" encoding=\"UTF-8\" ?>" +
             "<personas>" +
             "<persona bloqueado=\"NO\" >" +
             "<datosPersonales sexo=\"Masculino\" >" +
             "<apellido>Roldan</apellido >" +
             "<nombre>Carlos</nombre>" +
             "<edad>45</edad>" +
             "<nacionalidad>Argentina</nacionalidad>" +
             "</datosPersonales>" +
             "<antecedentes>Universitario Completo</antecedentes >" +
             "</persona>" +
             "</personas>";

        }
    }
}
