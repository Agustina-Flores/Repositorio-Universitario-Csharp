using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace streamreader
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

        public List<Customers> selectCustomers()
        {
            List<Customers> customers = new List<Customers>();
            string consulta = "SELECT * FROM `customers`";

            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            MySqlDataReader lectura = comando.ExecuteReader();

            //recorre cada fila de la tabla en este caso es 1
            while (lectura.Read())
            {
                Customers customer = new Customers();
                //recorre cada columna
                customer.CustomerId = lectura.GetString("CustomerID");
                customer.CompanyName = lectura.GetString("CompanyName");
                customer.ContactName = lectura.GetString("ContactName");
                customer.City = lectura.GetString("City");
                customer.Region = lectura.GetString("Region");
                customer.Country = lectura.GetString("Country");
                customer.Phone = lectura.GetString("Phone");

                //agrego cliente a la lista
                customers.Add(customer);

            }
            comando.Connection.Close();

            return customers;

        }



    }
}

