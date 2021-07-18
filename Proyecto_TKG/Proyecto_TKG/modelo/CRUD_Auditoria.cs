using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TKG.modelo
{
    class CRUD_Auditoria
    {
        public void Ingresar(Auditoria prod)
        {
            Conexion cone = new Conexion();
            cone.conectar().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO Auditoria (fecha, hora, accion) VALUES(@fecha, @hora, @accion)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone.con;
                cmd.Parameters.Add("@fecha", MySqlDbType.VarChar).Value = prod.Fecha;
                cmd.Parameters.Add("@hora", MySqlDbType.VarChar).Value = prod.Hora;
                cmd.Parameters.Add("@accion", MySqlDbType.VarChar).Value = prod.Accion;
                cmd.ExecuteNonQuery();
                cone.con.Close();
            }
        }
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();
        public void mostrar()
        {
            Conexion cone = new Conexion();
            dt.Clear();
            string sql = "select * from Auditoria";
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, cone.conectar());
            mda.Fill(ds);
            dt = ds.Tables[0];
        }

        public void filtrar(String buscar)
        {
            Conexion cone = new Conexion();
            dt.Clear();
            string sql = "select * from Auditoria where accion like ('%" + buscar + "%')";
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, cone.conectar());
            mda.Fill(ds);
            dt = ds.Tables[0];
        }
    }
}
