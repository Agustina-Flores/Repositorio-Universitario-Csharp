using System;
using System.Collections.Generic;
using System.Text;

namespace json
{
    class Auto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Localidad { get; set; }
        public string Imagen { get; set; }
        public string Anio { get; set; }
        public string Precio { get; set; }
        public string Destacado { get; set; }

        public override string ToString()
        {
            return String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", Marca, Modelo, Localidad, Imagen, Anio, Precio, Destacado);

        }
    }
}
