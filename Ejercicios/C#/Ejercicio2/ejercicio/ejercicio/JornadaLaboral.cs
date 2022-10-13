using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ejercicio
{
    public class JornadaLaboral
    {
        public  DateTime Fecha { get; set; }
        public int MinutosTrabajados { get; set; }
        public Empleado empleado { get; set; }


        public JornadaLaboral(DateTime f, int m)
        {
             this.Fecha = f;
            this.MinutosTrabajados = m;
             
        }
    
        public int getMinutosIngresados()
        {
            return this.MinutosTrabajados;
        }

        public DateTime getFecha()
        {
            return this.Fecha;
        }

        public void setFecha(DateTime Fecha)
        {
            this.Fecha = Fecha;
        } 

        public Empleado getEmpleado()
        {
            return this.empleado;
        }

        public void setEmpleado(Empleado empleado)
        {
            this.empleado = empleado;
        }


        public void setMinutosTrabajados(int MinutosTrabajados)
        {
            this.MinutosTrabajados = MinutosTrabajados;
        }

              
    }
}
