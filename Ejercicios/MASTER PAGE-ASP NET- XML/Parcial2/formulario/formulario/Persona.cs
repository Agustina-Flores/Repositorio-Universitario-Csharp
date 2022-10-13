using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 
using System.Text;
using System.Threading.Tasks;
namespace formulario
{
    public class Persona
    {
         
            public string bloqueado { get; set; }
            public string sexo { get; set; }
            public string apellido { get; set; }
            public string nombre { get; set; }
            public string edad { get; set; }
            public string nacionalidad { get; set; }
            public string antecedentes { get; set; }

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


                         bloqueado = "NO",
                         sexo = "M",
                         apellido = "ROLDAN",
                       nombre = "CARLOS",
                          edad = "45",
                         nacionalidad = "Argentino",
                         antecedentes = "Universitario Completo"


                );

        }
    }
}