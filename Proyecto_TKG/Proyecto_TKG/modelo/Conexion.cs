using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Proyecto_TKG.modelo
{
    class Conexion
    {
        public MySqlConnection con;
        public MySqlConnection conectar()
        {
            string host = "localhost";
            string db = "mydb";
            string user = "root";
            string clave = " ";
            string conecta = "server = " + host + "; user id = " + user + "; database = " + db + "; password = " + clave;
            con = new MySqlConnection(conecta);
            return con;
        }
    }
}
