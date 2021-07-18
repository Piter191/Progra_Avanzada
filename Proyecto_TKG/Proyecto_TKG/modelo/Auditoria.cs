using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TKG.modelo
{
    class Auditoria
    {
        private int idAuditor;
        private string fecha;
        private string hora;
        private string accion;

        public int IdAuditor { get => idAuditor; set => idAuditor = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Accion { get => accion; set => accion = value; }

        public Auditoria(int idAuditor, string fecha, string hora, string accion)
        {
            this.idAuditor = idAuditor;
            this.fecha = fecha;
            this.hora = hora;
            this.accion = accion;
        }
    }
}
