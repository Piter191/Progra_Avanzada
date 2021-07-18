using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TKG.modelo
{
    class Compra
    {
        private int idCompra;
        private string numeroFactura;
        private string fecha;
        private string hora;
        private string total;

        public int IdCompra { get => idCompra; set => idCompra = value; }
        public string NumeroFactura { get => numeroFactura; set => numeroFactura = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Total { get => total; set => total = value; }

        public Compra(int idCompra, string numeroFactura, string fecha, string hora, string total)
        {
            this.idCompra = idCompra;
            this.numeroFactura = numeroFactura;
            this.fecha = fecha;
            this.hora = hora;
            this.total = total;
        }
    }
}
