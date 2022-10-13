using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN_2
{
    class Articulo
    {
        private String codigo;
        private double stockTotal;
        private double stockMinimo;

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public double StockTotal
        {
            get
            {
                return stockTotal;
            }

            set
            {
                stockTotal = value;
            }
        }

        public double StockMinimo
        {
            get
            {
                return stockMinimo;
            }

            set
            {
                stockMinimo = value;
            }
        }

        
    }
}
