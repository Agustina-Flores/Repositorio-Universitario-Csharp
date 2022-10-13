using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios
{
    class Edificio
    {
        private string nombre;
        private string domicilio;
        private List<Departamento> departamentos = new List<Departamento>();

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

        public List<Departamento> getDepartamentos()
        {
            return this.departamentos;
        }

        public void setDepartamentos(List<Departamento> departamentos)
        {
            this.departamentos = departamentos;
        }
        public List<double> totalMetrosCuadrados(object piso)
        {

            List<double> metrosCuadrados = new List<double>();

            if (piso == null)
            {
                foreach (Departamento departamento in departamentos)
                {
                    double total = departamento.metrosCuadrados;
                    metrosCuadrados.Add(total);
                   

                }
            }


            return metrosCuadrados;
        }
    }
}
 