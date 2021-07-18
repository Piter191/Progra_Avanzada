using Proyecto_TKG.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_TKG
{
    public partial class Form_Auditoria : Form
    {
        public Form_Auditoria()
        {
            InitializeComponent();
        }

        private void Form_Auditoria_Load(object sender, EventArgs e)
        {
            cargar_grilla();
        }

        public void cargar_grilla()
        {
            CRUD_Auditoria usuarios = new CRUD_Auditoria();
            grilla_auditora.DataSource = null;
            usuarios.mostrar();
            grilla_auditora.DataSource = usuarios.dt;
        }

        private void grilla_auditora_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void frmbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            CRUD_Auditoria auditoria = new CRUD_Auditoria();
            grilla_auditora.DataSource = null;
            auditoria.filtrar(frmbuscar.Text);
            grilla_auditora.DataSource = auditoria.dt;
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            exportaraexcel(grilla_auditora);
        }

        public void exportaraexcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new
           Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int IndiceColumna = 0;
            foreach (DataGridViewColumn col in tabla.Columns) // Columnas
            {
                IndiceColumna++;
                excel.Cells[1, IndiceColumna] = col.Name;
            }
            int IndeceFila = 0;
            foreach (DataGridViewRow row in tabla.Rows) // Filas
            {
                IndeceFila++;
                IndiceColumna = 0;
                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
