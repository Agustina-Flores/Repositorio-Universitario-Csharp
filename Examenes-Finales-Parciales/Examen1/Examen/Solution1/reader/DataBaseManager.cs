using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace reader
{
    class DataBaseManager
    {
        public MySqlConnection Conectar()
        {
            //Conexion
            //servidor a donde va a conectar
            string servidor = "localhost";
            string usuario = "root";
            string password = "";
            string baseDeDatos = "northwind";
            string coneccion = "DataBase=" + baseDeDatos + "; Data Source="
            + servidor + ";User Id=" + usuario + ", Password=" + password + "";

            //conexion
            MySqlConnection conexionDb = new MySqlConnection(coneccion);
            //siempre hay que abrir la conexion
            conexionDb.Open();

            return conexionDb;
        }

        public List<Shippers> selectShippers()
        {
            List<Shippers> shippers = new List<Shippers>();
            string consulta = "SELECT * FROM `shippers`";

            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            MySqlDataReader lectura = comando.ExecuteReader();

            //recorre cada fila de la tabla en este caso es 1
            while (lectura.Read())
            {
                Shippers shipper = new Shippers();
                //recorre cada columna
                shipper.Id = lectura.GetString("ShipperID");
                shipper.CompanyName = lectura.GetString("CompanyName");
                shipper.Phone = lectura.GetString("Phone");

                //agrego cliente a la lista
                shippers.Add(shipper);

            }
            comando.Connection.Close();

            return shippers;

        }

    }
}
 