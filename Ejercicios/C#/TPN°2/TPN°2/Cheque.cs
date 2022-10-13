using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN_2
{
    class Cheque
    {
        private int nroInterno;
        private String banco;
        private double importe;
        private int numero;
        private String propietario;
        

        


        public void guardar(int nroInterno, String banco, double importe, int numero, String propietario)
        {
            this.nroInterno = nroInterno;
            this.banco = banco;
            this.importe = importe;
            this.numero = numero;
            this.propietario = propietario;
        }

        public void imprimir()
        {
            Console.WriteLine("Banco: " + this.banco);
            Console.WriteLine("Propietario: " + this.propietario);
            Console.WriteLine("Número: " + this.numero);
            Console.WriteLine("Importe: " + this.importe);
        }

        public void validarNroInterno() { }
    }
}
