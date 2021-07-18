using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TKG.modelo
{
    class Usuarios
    {
        private int idUsuario;
        private string nombreUsuario;
        private string emailUsuario;
        private string rutUsuario;
        private string usuario;
        private string clave;
        private int tipo_Usuario;
        private int estadoUsuario;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string EmailUsuario { get => emailUsuario; set => emailUsuario = value; }
        public string RutUsuario { get => rutUsuario; set => rutUsuario = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Clave { get => clave; set => clave = value; }

        public int Tipo_Usuario { get => tipo_Usuario; set => tipo_Usuario = value; }

        public int EstadoUsuario { get => estadoUsuario; set => estadoUsuario = value; }

        public Usuarios(int idUsuario, string nombreUsuario, string emailUsuario, string rutUsuario, string usuario, string clave, int tipo_Usuario, int estadoUsuario)
        {
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.emailUsuario = emailUsuario;
            this.rutUsuario = rutUsuario;
            this.usuario = usuario;
            this.clave = clave;
            this.tipo_Usuario = tipo_Usuario;
            this.estadoUsuario = estadoUsuario;
        }

    }

}
