using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Persona
    {
        public bool Bloqueado { get; set; }
        public string Sexo { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }

        public string Edad { get; set; }
        public string Nacionalidad { get; set; }
        public string Antecedentes { get; set; }

        public override string ToString()
        {
            return String.Format(
                    "\t<persona bloqueado=\"{0}\">\n" +
                     "\t<datosPersonales sexo=\"{1}\">\n" +
                        "\t\t<apellido>{2}</apellido>\n" +
                        "\t\t<nombre>{3}</nombre>\n" +
                        "\t\t<edad>{4}</edad>\n" +
                        "\t\t<nacionalidad>{5}</nacionalidad>\n" +
                   "\t</datosPersonales>\n" +
                   "\t\t<antecedentes>{6}</antecedentes>\n" +
                    "\t</persona>",
                    Bloqueado,
                    Sexo,
                    Apellido,
                    Nombre,
                    Edad,
                    Nacionalidad,
                    Antecedentes
                );
        }
    }
}
