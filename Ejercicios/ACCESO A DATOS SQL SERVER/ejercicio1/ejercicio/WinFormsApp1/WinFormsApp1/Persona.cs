using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Persona
    { 
        private int dni;
        private string nombreCompleto;


        public int Dni
        {
            //al hacer un get se trae informacion de la variable
            //al hacer un set se modifica la informacion de esa variable 
            get { return dni; }
            set { dni = value; }
        }

        public string NombreCompleto
        {
            //al hacer un get se trae informacion de la variable
            //al hacer un set se modifica la informacion de esa variable 
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }

        public string DatosCompletos
        {
            get { return dni + " " + nombreCompleto; }
        }

        //Para que se vean todos los datos por su nombre y no GestionClientes
        public override string ToString()
        {
            return DatosCompletos;
        }
    }
}
