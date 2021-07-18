using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TKG.modelo
{
    class CRUD_Compras
    {
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public void Ingresar(Compra com)
        {
            Conexion_Sql cone = new Conexion_Sql();
            cone.conectar().Open();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "INSERT INTO Compra (numeroFactura, fecha, hora, total) VALUES(@numeroFactura, @fecha, @hora, @total)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone.conex;
                cmd.Parameters.Add("@numeroFactura", SqlDbType.VarChar).Value = com.NumeroFactura;
                cmd.Parameters.Add("@fecha", SqlDbType.VarChar).Value = com.Fecha;
                cmd.Parameters.Add("@hora", SqlDbType.VarChar).Value = com.Hora;
                cmd.Parameters.Add("@total", SqlDbType.VarChar).Value = com.Total;
                cmd.ExecuteNonQuery();
                cone.conex.Close();
            }
        }

        public void filtrar(String buscar)
        {
            Conexion_Sql cone = new Conexion_Sql();
            dt.Clear();
            string sql = "select * from Compra where numeroFactura like ('%" + buscar + "%')";
            SqlDataAdapter mda = new SqlDataAdapter(sql, cone.conectar());
            mda.Fill(ds);
            dt = ds.Tables[0];
        }
    }
}
