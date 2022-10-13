using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios
{
    class Departamento
    {
        public int piso { get; set; }
        public int numero { get; set; }
        public double metrosCuadrados { get; set; }
        public Edificio edificio { get; set; }

        public Departamento(int piso, int numero, double metrosCuadrados)
        {
            this.piso = piso;
            this.numero = numero;
            this.metrosCuadrados = metrosCuadrados;
        }
    }
}
