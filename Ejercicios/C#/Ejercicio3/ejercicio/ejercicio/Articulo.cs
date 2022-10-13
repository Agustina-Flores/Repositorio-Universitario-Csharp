using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio
{
    class Articulo
    {
        private string codigo;
        private double stockTotal;
        private double stockMinimo;
        private Deposito deposito;
      
        public Articulo()
        {

        }
        public Articulo(string codigo, double stockTotal, double stockMinimo)
        {
            this.codigo = codigo;
            this.stockTotal = stockTotal;
            this.stockMinimo = stockMinimo;
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public double StockTotal
        {
            get { return stockTotal; }
            set { stockTotal = value; }
        }

        public double StockMinimo
        {
            get { return stockMinimo; }
            set { stockMinimo = value; }
        }
         
    }
}
