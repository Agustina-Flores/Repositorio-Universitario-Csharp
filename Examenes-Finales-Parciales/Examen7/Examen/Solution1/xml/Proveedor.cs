using System;
using System.Collections.Generic;
using System.Text;

namespace xml
{
    class Proveedor
    {
        public String Id { get; set; }
        public String Codigo { get; set; }
        public String Cuit { get; set; }
        public String RazonSocial { get; set; }
        public String Telefono { get; set; }
        public String Domicilio { get; set; }
        public String Saldo { get; set; }

        public override string ToString()
        {
            return String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", Id, Codigo, Cuit, RazonSocial, Telefono, Domicilio, Saldo);
        }
    }
}
