using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios
{
    class Empleado
    {

        private string nombreCompleto { get; set; }
        private List<JornadaLaboral> jornadasLaborales = new List<JornadaLaboral>();

       public int totalTrabajadoMes(int mes,int anio)
        {
            int total = 0;
            foreach(JornadaLaboral jornada in jornadasLaborales)
            {
                if (jornada.getFecha().Year == anio && jornada.getFecha().Month == mes)
                {
                    total = total + jornada.getMinutosTrabajados();
                }
            }
            return total;
        }
        public string getnombreCompleto()
        {
            return this.nombreCompleto;
        }

        public void setnombreCompleto(string nombreCompleto)
        {
            this.nombreCompleto = nombreCompleto;
        }

        public List<JornadaLaboral> getjornadaLaborales()
        { 
            return this.jornadasLaborales;
        }

        public void setjornadasLaborales(List<JornadaLaboral>jornadasLaborales)
        {
            this.jornadasLaborales = jornadasLaborales;
        }
    }
}
