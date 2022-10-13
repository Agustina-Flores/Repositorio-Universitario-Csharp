using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios
{
    class JornadaLaboral
    {
        private DateTime Fecha { get; set; }
        private int minutosTrabajados { get; set; }

        private Empleado empleado { get; set; }

        public JornadaLaboral(DateTime Fecha, int minutosTrabajados)
        {
            this.Fecha = Fecha;
            this.minutosTrabajados = minutosTrabajados;
        }
        public Empleado getEmpleado()
        {
            return this.empleado;
        }

        public void setEmpleado(Empleado empleado)
        {
            this.empleado = empleado;
        }
        public DateTime getFecha()
        {
            return this.Fecha;
        }

        public void setfecha(DateTime Fecha)
        {
            this.Fecha = Fecha;
        }


        public int getMinutosTrabajados()
        {
            return this.minutosTrabajados;
        }

        public void setminutosTrabajados(int minutosTrabajados)
        {
            this.minutosTrabajados = minutosTrabajados;
        }
    }
}
