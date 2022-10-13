using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Personadao
    {

        public MySqlConnection Conectar()
        {
            //Conexion
            //servidor a donde va a conectar
            string servidor = "localhost";
            string usuario = "root";
            string password = "";
            string baseDeDatos = "personas";
            string coneccion = "DataBase=" + baseDeDatos + "; Data Source="
            + servidor + ";User Id=" + usuario + ", Password=" + password + "";

            //conexion
            MySqlConnection conexionDb = new MySqlConnection(coneccion);
            //siempre hay que abrir la conexion
            conexionDb.Open();

            return conexionDb;
        }


        public List<Persona> obtenerlistadoPersonas()
        {
            //para llenar la lista con los datos de la base de datos
            List<Persona> lista = new List<Persona>();

            //consulta
            string consulta = "SELECT * FROM `persona` ORDER BY `nombreCompleto`";

            //comando que mandamos y le pasamos la consulta, para que traiga
            //los datos de la base de datos
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            MySqlDataReader lectura = comando.ExecuteReader();


            //recorre cada fila de la tabla en este caso es 1
            while (lectura.Read())
            {
                Persona persona = new Persona();
                //recorre cada columna
                persona.Dni = lectura.GetInt32("dni");
                persona.NombreCompleto = lectura.GetString("nombreCompleto");
                //como esta en la base de datos
                //agrego cliente a la lista
                lista.Add(persona);

            }
            comando.Connection.Close();

            return lista;
        }
        public void Guardar(Persona persona)
        {
            
                Insertar(persona);
            
            
        }
        private void Insertar(Persona persona)
        {
            //consulta
            string consulta = "INSERT INTO `persona` (`dni`, `nombreCompleto`) VALUES ( '" + persona.Dni + "', '" + persona.NombreCompleto + "')"; //el enter en el +
            //comando que mandamos y le pasamos la consulta, para que traiga
            //los datos de la base de datos
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            //Insert
            comando.ExecuteNonQuery();


            comando.Connection.Close();
        }
    }
}
