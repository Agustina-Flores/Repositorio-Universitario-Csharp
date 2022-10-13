using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class GestionPersonas : Form
    {
        public GestionPersonas()
        {
            InitializeComponent();
        }

        private void listaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        { 
                Persona persona = new Persona();
                persona.Dni = Int32.Parse(textBox1.Text);
                persona.NombreCompleto = textBox2.Text;
                 
                //cliente.Nombre = "Rocio"; //lo estariamos mandando al metodo set y recibiria el valor modificado "Rocio"




                //en este caso si no esta vacio le vamos a poner el id al cliente
               
                Personadao baseDeDatos = new Personadao();

                //esta funcion Guardar() agrega o actualiza datos que estan en la base de datos
                //si le paso el id me lo va a modificar
                //si no le paso el id me lo va a insertar xq es una nueva fila
                baseDeDatos.Guardar(persona);
                actualizarLista();
                //agrego clientes a la lista

                //limpie listado
                //limpiarListado();
            

        }



        private void GestionPersonas_Load(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void actualizarLista()
        {
            //vemos si funciona la base de datos, va a la funcion conectar.
            //Creo objeto de la base de datos (ClienteDao)
            Personadao baseDeDatos = new Personadao();
            //lista con todos los clientes
            List<Persona> listaDeBaseDeDatos = baseDeDatos.obtenerlistadoPersonas();
            //limpia el lista visible, y lo recarga nuevamente con los de la base de datos
            listaPersonas.Items.Clear();


            //recorro todo lo que hay en la lista
            for (int i = 0; i < listaDeBaseDeDatos.Count; i++)
            {
                //guardamos la lista en una variable de tipo Cliente
                Persona persona = listaDeBaseDeDatos[i];
                //agregamos a la listaClientes
                listaPersonas.Items.Add(persona);
            }
        }
    }
}
