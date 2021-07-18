using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TKG.modelo
{
    class Familia
    {
        private int idFamiliaProductos;
        private string nombreFamiliaProductos;
        private int estadoFamiliaProductos;

        public int IdFamiliaProductos { get => idFamiliaProductos; set => idFamiliaProductos = value; }
        public string NombreFamiliaProductos { get => nombreFamiliaProductos; set => nombreFamiliaProductos = value; }
        public int EstadoFamiliaProductos { get => estadoFamiliaProductos; set => estadoFamiliaProductos = value; }

        public Familia(int idFamiliaProductos, string nombreFamiliaProductos, int estadoFamiliaProductos)
        {
            this.idFamiliaProductos = idFamiliaProductos;
            this.nombreFamiliaProductos = nombreFamiliaProductos;
            this.estadoFamiliaProductos = estadoFamiliaProductos;
        }
    }
}
