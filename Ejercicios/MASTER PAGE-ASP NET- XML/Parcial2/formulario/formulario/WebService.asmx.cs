using formulario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
 using System.IO;
using System.Text;
 using System.Threading.Tasks;
using System.Xml;

namespace formulario
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        //Persona persona = new Persona();
       

        /*[WebMethod]
       /*
       public Persona[] CrearXml()
       {
           Persona[] personas = new Persona[]
           {
               new Persona()
               {
                  bloqueado="NO",
                   sexo = "M",
                   apellido = "ROLDAN",
                   nombre = "CARLOS",
                   edad = "45",
                   nacionalidad = "Argentino",
                   antecedentes = "Universitario Completo"
               }

           };
           return personas;
       }

       public string getPersonaXML()
       {
           return "<personas><persona bloqueado =”NO”><datosPersonales sexo =”M”><apellido>ROLDAN</apellido><nombre>CARLOS</nombre><edad>45</edad><nacionalidad>Argentino</nacionalidad><datosPersonales><antecedentes>UniversitarioCompleto</antecedentes></persona></personas>";
       }
       */
        [WebMethod]
        public void AddPersona(string nombrearchivo, Persona persona )
        {
            new XMLPersona(nombrearchivo, persona);
        }

        [WebMethod]
        public void AddPersona(string nombrearchivo, List<Persona> personas)
        {
            new XMLPersona(nombrearchivo, personas);
        }
        /*
        public string toString()
        {
            return String.Format(
                    "\t<persona bloqueado=\"{0}\">\n" +
                    "\t<datosPersonales sexo=\"{1}\">\n" +
                        "\t\t<apellido>{2}</apellido>\n" +
                        "\t\t<nombre>{3}</nombre>\n" +
                        "\t\t<edad>{4}</edad>\n" +
                        "\t\t<nacionalidad>{5}</nacionalidad>\n" +
                        "\t\t<antecedentes>{6}</antecedentes>\n" +
                    "\t</personas>",
                    
                   
                        persona.bloqueado="NO",
                        persona.sexo="M",
                        persona.apellido="ROLDAN",
                       persona.nombre="CARLOS",
                        persona.edad="45",
                        persona.nacionalidad="Argentino",
                        persona.antecedentes ="Universitario Completo"
                   

                );
             
        }
        */




    }
}
