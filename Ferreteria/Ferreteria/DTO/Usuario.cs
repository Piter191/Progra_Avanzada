using System;
using System.Collections.Generic;
using System.Text;

namespace BlibliotecaBodega.DTO
{

    public struct TipoUsuario
    {
        public string nombreTipo { get; set; }
        public string codigoTipo { get; set; }

    }

    public class Usuario
    {
        private string rut;
        private string nombre;
        private string appaterno;
        private string apmaterno;
        private string usu;
        private string clave;
        private int estado;

        public Usuario(string rut, string nombre, string appaterno, string apmaterno, string usu, string clave, int estado)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.appaterno = appaterno;
            this.apmaterno = apmaterno;
            this.usu = usu;
            this.clave = clave;
            this.estado = estado;
        }

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Appaterno { get => appaterno; set => appaterno = value; }
        public string Apmaterno { get => apmaterno; set => apmaterno = value; }
        public string Usu { get => usu; set => usu = value; }
        public string Clave { get => clave; set => clave = value; }
        public int Estado { get => estado; set => estado = value; }

        public TipoUsuario TipoUsuario { get; set; }

        public override string ToString()
        {
            return this.rut+" "+this.nombre+" "+this.appaterno+ " "+this.apmaterno;
        }
    }
}
