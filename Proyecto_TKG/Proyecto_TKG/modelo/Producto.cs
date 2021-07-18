using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TKG.modelo
{
    class Producto
    {
        private int idProducto;
        private string nombreProducto;
        private int costo;
        private int stock;
        private string estado;
        private string familia;

        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int Costo { get => costo; set => costo = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Familia { get => familia; set => familia = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }


        public Producto(int idProducto, string nombreProducto, int costo, int stock, string estado, string familia)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.costo = costo;
            this.stock = stock;
            this.estado = estado;
            this.familia = familia;
        }

    }
}
