using System;
using System.Collections.Generic;
using System.Text;

namespace BlibliotecaBodega.DTO
{
    public class Familia
    {

        private string nombre;
        private int estado;

        public Familia(string nombre, int estado)
        {
            this.nombre = nombre;
            this.estado = estado;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Estado { get => estado; set => estado = value; }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
