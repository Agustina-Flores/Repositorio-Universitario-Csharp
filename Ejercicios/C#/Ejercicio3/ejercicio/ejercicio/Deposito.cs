using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio
{
 class Deposito
    {
        private string nombre;
        private string domicilio;

        private List<Articulo> articulos;
 
        
        public Deposito(string nombre, string domicilio)
        {
            this.nombre = nombre;
            this.domicilio = domicilio;
        }
        public List<Articulo> articulosBajoStock()
        {
            List<Articulo> articulosBajoStock = new List<Articulo>();

            foreach (Articulo a in articulos)
            {
                if (a.StockTotal <= a.StockMinimo)
                {
                    articulosBajoStock.Add(a);
                }
            }

            return articulosBajoStock;
        }
        public Deposito()
        {

        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        public List<Articulo> Articulo
        {
            get { return articulos; }
            set { articulos = value; }
        }
        
    }
}
