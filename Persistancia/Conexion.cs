using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Persistencia
{
    public class Conexion
    {
        private MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;Port=3306;database=Universidad;uid=root;pwd=1234;");

        public MySqlConnection AbrirConexion()
        {
            if (mySqlConnection.State == ConnectionState.Closed)
            {
                mySqlConnection.Open();
            }
            return mySqlConnection;
        }

        public MySqlConnection CerrarConexion()
        {
            if (mySqlConnection.State == ConnectionState.Open)
            {
                mySqlConnection.Close();
            }
            return mySqlConnection;
        }
    }
}
