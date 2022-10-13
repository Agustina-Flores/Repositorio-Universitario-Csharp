using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios
{
    class Articulo
    {

        private string codigo;
        private double stockTotal;
        private double stockMinimo;
        private Deposito deposito;

        public Articulo(string codigo, double stockTotal, double stockMinimo)
        {
            this.codigo = codigo;
            this.stockTotal = stockTotal;
            this.stockMinimo = stockMinimo;
        }
        public string getCodigo()
        {
            return this.codigo;
        }

        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }

        public double getStockTotal()
        {
            return this.stockTotal;
        }

        public void setStockTotal(double stockTotal)
        {
            this.stockTotal = stockTotal;
        }


        public double getStockMinimo()
        {
            return this.stockMinimo;
        }

        public void setStockMinimo(double stockMinimo)
        {
            this.stockMinimo = stockMinimo;
        }
        public Deposito getDeposito()
        {
            return this.deposito;
        }

        public void setDeposito(Deposito deposito)
        {
            this.deposito = deposito;
        }
    }
}
 
