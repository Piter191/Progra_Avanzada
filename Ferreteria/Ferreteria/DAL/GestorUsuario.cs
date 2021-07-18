using BlibliotecaBodega.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlibliotecaBodega.DAL
{
    public class GestorUsuario
    {
        private static List<Usuario> usuarios = new List<Usuario>();

        public static readonly TipoUsuario TIPOADM = new TipoUsuario()
        {
            nombreTipo = "Administrador",
            codigoTipo = "T01"
        };

        public static readonly TipoUsuario TIPOBOD = new TipoUsuario()
        {
            nombreTipo = "Bodeguero",
            codigoTipo = "T02"
        };

        public static readonly TipoUsuario TIPOUSU = new TipoUsuario()
        {
            nombreTipo = "Usuario",
            codigoTipo = "T03"
        };

        public void ingresar(Usuario usu)
        {
            usuarios.Add(usu);
        }

        public List<Usuario> mostrar()
        {
            return usuarios;
        }

        public void modificar(int indice, Usuario usu)
        {
            usuarios.Insert(indice, usu);
        }

        public void eliminar(Usuario usu)
        {
            usuarios.Remove(usu);
        }

       
    }
}
