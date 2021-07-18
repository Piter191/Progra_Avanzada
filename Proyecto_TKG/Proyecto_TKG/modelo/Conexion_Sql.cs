using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto_TKG.modelo
{
    class Conexion_Sql
    {
        public SqlConnection conex;
        public SqlConnection conectar()
        {
            string conecta = "Data Source=(localdb)\\Servidor;Initial Catalog=Proyecto_TKG; Integrated Security = true";
         conex = new SqlConnection(conecta);
            return conex;
        }
    }
}
