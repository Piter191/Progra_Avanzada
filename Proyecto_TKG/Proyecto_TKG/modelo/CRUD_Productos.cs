using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_TKG.modelo
{

    class CRUD_Productos
    {

        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public void Ingresar(Producto prod)
        {
            Conexion_Sql cone = new Conexion_Sql();
            cone.conectar().Open();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "INSERT INTO Productos (nombreProducto, costo, stock, estado, familia) VALUES(@nombreProducto, @costo, @stock, @estado, @familia)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone.conex;
                cmd.Parameters.Add("@nombreProducto", SqlDbType.VarChar).Value =prod.NombreProducto;
                cmd.Parameters.Add("@costo", SqlDbType.Int).Value = prod.Costo;
                cmd.Parameters.Add("@stock", SqlDbType.Int).Value = prod.Stock;
                cmd.Parameters.Add("@estado", SqlDbType.VarChar).Value = prod.Estado;
                cmd.Parameters.Add("@familia", SqlDbType.VarChar).Value = prod.Familia;
                cmd.ExecuteNonQuery();
                cone.conex.Close();
            }
        }

        public void Modificar(Producto prod)
        {
            Conexion_Sql cone = new Conexion_Sql();
            cone.conectar().Open();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "UPDATE Productos SET nombreProducto = @nombreProducto, costo = @costo, stock = @stock, estado = @estado, familia = @familia WHERE idProducto =@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone.conex;
                cmd.Parameters.Add("@nombreProducto", SqlDbType.VarChar).Value =prod.NombreProducto;
                cmd.Parameters.Add("@costo", SqlDbType.Int).Value = prod.Costo;
                cmd.Parameters.Add("@stock", SqlDbType.Int).Value = prod.Stock;
                cmd.Parameters.Add("@estado", SqlDbType.VarChar).Value = prod.Estado;
                cmd.Parameters.Add("@familia", SqlDbType.VarChar).Value = prod.Familia;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = prod.IdProducto;
                cmd.ExecuteNonQuery();
                cone.conex.Close();
            }
        }

        public void Eliminar(Producto prod)
        {
            Conexion_Sql cone = new Conexion_Sql();
            cone.conectar().Open();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "UPDATE Productos SET estado = @estado WHERE idProducto = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone.conex;
                cmd.Parameters.Add("@estado", SqlDbType.VarChar).Value = "Inactivo";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = prod.IdProducto;
                cmd.ExecuteNonQuery();
                cone.conex.Close();
            }
        }

        public void mostrar()
        {
            Conexion_Sql cone = new Conexion_Sql();
            dt.Clear();
            string sql = "select * from Productos";
            SqlDataAdapter mda = new SqlDataAdapter(sql, cone.conectar());
            mda.Fill(ds);
            dt = ds.Tables[0];
        }

        public void filtrar(String buscar)
        {
            Conexion_Sql cone = new Conexion_Sql();
            dt.Clear();
            string sql = "select * from Productos where nombreProducto like ('%" + buscar + "%')";
            SqlDataAdapter mda = new SqlDataAdapter(sql, cone.conectar());
            mda.Fill(ds);
            dt = ds.Tables[0];
        }

    }
}
