using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios
{
    class JornadaLaboral
    {
        private DateTime Fecha { get; set; }
        private int MinutosTrabajados { get; set; }

        private Empleado empleado { get; set; }

        public JornadaLaboral(DateTime f, int m)
        {
            this.Fecha = f;
            this.MinutosTrabajados = m;

        }
        public DateTime getFecha()
        {
            return this.Fecha;
        }

        public void setFecha(DateTime Fecha)
        {
            this.Fecha = Fecha;
        }
        public void setMinutosTrabajados(int MinutosTrabajados)
        {
            this.MinutosTrabajados = MinutosTrabajados;
        }
        public int getMinutosTrabajados()
        {
            return this.MinutosTrabajados;
        }

        public void setEmpleado(Empleado empleado)
        {
            this.empleado = empleado;
        }

        public Empleado getEmpleado()
        {
            return this.empleado;
        }

        
    }
}
