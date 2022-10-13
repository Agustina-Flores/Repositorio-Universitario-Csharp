using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN_2
{
    class Deposito
    {
        private String nombre;
        private String domicilio;
        private List<Articulo> articulos;

        public List<Articulo> articulosBajoStock(List<Articulo> articulos)
        {
            List<Articulo> articulosBS = new List<Articulo>();
            foreach (Articulo articulo in articulos)
            {
                if (articulo.StockTotal <= articulo.StockMinimo)
                {
                    articulosBS.Add(articulo);
                }

            }
            return articulosBS;
        }

    }
}
