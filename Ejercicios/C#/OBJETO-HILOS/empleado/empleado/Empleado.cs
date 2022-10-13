using System;
using System.Collections.Generic;
using System.Text;

namespace empleado
{
    class Empleado
    {
         
        private string nombre;
        private string apellido;
        private long cuit;
        private Sector sector;

        public string getNombre()
        {
            return this.nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getApellido()
        {
            return this.apellido;
        }

        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public long getCuit()
        {
            return this.cuit;
        }

        public void setCuit(long cuit)
        {
            this.cuit = cuit;
        }

        public Sector getSector()
        {
            return this.sector;
        }

        public void setSector(Sector sector)
        {
            this.sector = sector;
        }

         
    }
}
