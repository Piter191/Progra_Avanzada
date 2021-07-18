using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TKG.modelo
{
    class CRUD_Familia
    {
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public void Ingresar(Familia fam)
        {
            Conexion_Sql cone = new Conexion_Sql();
            cone.conectar().Open();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "INSERT INTO Familia_Productos (nombreFamiliaProductos, estadoFamiliaProductos) VALUES(@nombreFamiliaProductos, @estadoFamiliaProductos)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone.conex;
                cmd.Parameters.Add("@nombreFamiliaProductos", SqlDbType.VarChar).Value = fam.NombreFamiliaProductos;
                cmd.Parameters.Add("@estadoFamiliaProductos", SqlDbType.Int).Value = fam.EstadoFamiliaProductos;
                cmd.ExecuteNonQuery();
                cone.conex.Close();
            }
        }
        public void Modificar(Familia fam)
        {
            Conexion_Sql cone = new Conexion_Sql();
            cone.conectar().Open();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "UPDATE Familia_Productos SET nombreFamiliaProductos = @nombreFamiliaProductos, estadoFamiliaProductos = @estadoFamiliaProductos WHERE idFamiliaProductos =@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone.conex;
                cmd.Parameters.Add("@nombreFamiliaProductos", SqlDbType.VarChar).Value = fam.NombreFamiliaProductos;
                cmd.Parameters.Add("@estadoFamiliaProductos", SqlDbType.Int).Value = fam.EstadoFamiliaProductos;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = fam.IdFamiliaProductos;
                cmd.ExecuteNonQuery();
                cone.conex.Close();
            }
        }

        public void Eliminar(Familia fam)
        {
            Conexion_Sql cone = new Conexion_Sql();
            cone.conectar().Open();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "UPDATE Familia_Productos SET estadoFamiliaProductos = @estadoFamiliaProductos WHERE idFamiliaProductos = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone.conex;
                cmd.Parameters.Add("@estadoFamiliaProductos", SqlDbType.VarChar).Value = 2;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = fam.IdFamiliaProductos;
                cmd.ExecuteNonQuery();
                cone.conex.Close();
            }
        }

        public void mostrar()
        {
            Conexion_Sql cone = new Conexion_Sql();
            dt.Clear();
            string sql = "select * from Familia_Productos";
            SqlDataAdapter mda = new SqlDataAdapter(sql, cone.conectar());
            mda.Fill(ds);
            dt = ds.Tables[0];
        }

        public void filtrar(String buscar)
        {
            Conexion_Sql cone = new Conexion_Sql();
            dt.Clear();
            string sql = "select * from Familia_Productos where nombreFamiliaProductos like ('%" + buscar + "%')";
            SqlDataAdapter mda = new SqlDataAdapter(sql, cone.conectar());
            mda.Fill(ds);
            dt = ds.Tables[0];
        }

    }
}
