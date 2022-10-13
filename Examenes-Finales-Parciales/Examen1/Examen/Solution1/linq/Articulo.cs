using System;
using System.Collections.Generic;
using System.Text;

namespace linq
{
    class Articulo
    {
        private long id;
        private string nombre;
        private long codigoBarra;
        private long stock;
        private string origen;
        private double precio;
        private string marca;

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public long CodigoBarra { get => codigoBarra; set => codigoBarra = value; }
        public long Stock { get => stock; set => stock = value; }
        public string Origen { get => origen; set => origen = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Marca { get => marca; set => marca = value; }
        /*
         public override string ToString()
         {
             return String.Format("Id: {0} - Nombre: {1} - CodigoBarra: {2} - Stock: {3} - Origen: {4}- Precio: {5} - Marca: {6}", Id, Nombre, CodigoBarra, Stock, Origen, Precio, Marca);
         }
         */
    }
}
