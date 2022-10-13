using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios
{
    class Deposito
    {

        private string domicilio;
        private string nombre;
        private List<Articulo> articulos;

        public List<Articulo> artículosBajoStock()
        {
            List<Articulo> artBajoStock = new List<Articulo>();
            foreach (Articulo a in articulos)
            {
                if (a.getStockTotal() <= a.getStockMinimo())
                {
                    artBajoStock.Add(a);
                }
            }

            return artBajoStock;
        }
        public string getDomicilio()
        {
            return this.domicilio;
        }

        public void setDomicilio(string domicilio)
        {
            this.domicilio = domicilio;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public List<Articulo> getArticulos()
        {
            return this.articulos;
        }

        public void setArticulos(List<Articulo> articulos)
        {
            this.articulos = articulos;
        }
    }
}
 
