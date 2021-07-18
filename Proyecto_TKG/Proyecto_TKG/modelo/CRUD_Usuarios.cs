using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TKG.modelo
{
    class CRUD_Usuarios
    {
        public bool Login(string usuario, string contraseña)
        {
            Conexion cone = new Conexion();
            cone.conectar().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.Connection = cone.con;
                cmd.CommandText = "select * from usuario where (rutUsuario=@usuario and clave=@clave) or (emailUsuario=@usuario and clave=@clave)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", contraseña);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void Ingresar(Usuarios prod)
        {
            Conexion cone = new Conexion();
            cone.conectar().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO usuario (nombreUsuario, emailUsuario, rutUsuario, usuario, clave, TipoUsuario_idTipoUsuario, estadoUsuario) VALUES(@nombreUsuario, @emailUsuario, @rutUsuario, @usuario, @clave, @TipoUsuario_idTipoUsuario, @estadoUsuario)";
            cmd.CommandType = CommandType.Text;
                cmd.Connection = cone.con;
                cmd.Parameters.Add("@nombreUsuario", MySqlDbType.VarChar).Value = prod.NombreUsuario;
                cmd.Parameters.Add("@emailUsuario", MySqlDbType.VarChar).Value = prod.EmailUsuario;
                cmd.Parameters.Add("@rutUsuario", MySqlDbType.VarChar).Value = prod.RutUsuario;
                cmd.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = prod.Usuario;
                cmd.Parameters.Add("@clave", MySqlDbType.VarChar).Value = prod.Clave;
                cmd.Parameters.Add("@TipoUsuario_idTipoUsuario", MySqlDbType.Int32).Value = prod.Tipo_Usuario;
                cmd.Parameters.Add("@estadoUsuario", MySqlDbType.Int32).Value = prod.EstadoUsuario;
                cmd.ExecuteNonQuery();
                cone.con.Close();
            }
        }

        public void Modificar(Usuarios prod)
        {
            Conexion cone = new Conexion();
            cone.conectar().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {

                cmd.CommandText = "UPDATE usuario SET nombreUsuario = @nombreUsuario, emailUsuario = @emailUsuario, rutUsuario = @rutUsuario, usuario = @usuario , clave = @clave, TipoUsuario_idTipoUsuario = @TipoUsuario_idTipoUsuario, estadoUsuario = @estadoUsuario WHERE usuario.idUsuario = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone.con;
                cmd.Parameters.Add("@nombreUsuario", MySqlDbType.VarChar).Value = prod.NombreUsuario;
                cmd.Parameters.Add("@emailUsuario", MySqlDbType.VarChar).Value = prod.EmailUsuario;
                cmd.Parameters.Add("@rutUsuario", MySqlDbType.VarChar).Value = prod.RutUsuario;
                cmd.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = prod.Usuario;
                cmd.Parameters.Add("@clave", MySqlDbType.VarChar).Value = prod.Clave;
                cmd.Parameters.Add("@TipoUsuario_idTipoUsuario", MySqlDbType.Int32).Value = prod.Tipo_Usuario;
                cmd.Parameters.Add("@estadoUsuario", MySqlDbType.Int32).Value = prod.EstadoUsuario;
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = prod.IdUsuario;
                cmd.ExecuteNonQuery();
                cone.con.Close();
            }
        }

        public void Eliminar(Usuarios prod)
        {
            Conexion cone = new Conexion();
            cone.conectar().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE usuario SET estadoUsuario = @estadoUsuario WHERE idUsuario = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone.con;
                cmd.Parameters.Add("@estadoUsuario", MySqlDbType.Int32).Value = 2;
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = prod.IdUsuario;
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
            string sql = "select * from usuario";
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, cone.conectar());
            mda.Fill(ds);
            dt = ds.Tables[0];
        }

        public void filtrar(String buscar)
        {
            Conexion cone = new Conexion();
            dt.Clear();
            string sql = "select * from usuario where nombreUsuario like ('%" + buscar + "%')";
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, cone.conectar());
            mda.Fill(ds);
            dt = ds.Tables[0];
        }

    }
}
