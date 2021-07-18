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
    public partial class Form_Familia : Form
    {
        CRUD_Auditoria au = new CRUD_Auditoria();

        public Form_Familia()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form_Familia_Load(object sender, EventArgs e)
        {
            limpiar();
        }

        public void cargar_grilla()
        {
            CRUD_Familia familia = new CRUD_Familia ();
            grilla_familia.DataSource = null;
            familia.mostrar();
            grilla_familia.DataSource = familia.dt;
            totalregistros.Text = "Total de Registros (" + grilla_familia.RowCount.ToString() + ")";

            if (grilla_familia.RowCount > 0)
            {
                btnexportar.Enabled = true;
            }
            else
            {
                btnexportar.Enabled = false;
            }
        }

        public void limpiar()
        {
            frmnombre.Text = "";
            idoculto.Text = "";
            frmbuscar.Text = "";
            btningresar.Enabled = true;
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
            idoculto.Visible = false;
            btnexportar.Enabled = false;
            frm_estado.SelectedIndex = 0;
            frmnombre.Focus();
            cargar_grilla();
        }

        public Boolean validar()
        {
            Boolean sw = true;
            if (frmnombre.Text == "")
            {
                sw = false;
            }
            if (frm_estado.SelectedIndex.Equals(0))
            {
                sw = false;
            }
            return sw;
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                CRUD_Familia familia = new CRUD_Familia();
                Familia p = new Familia (0, frmnombre.Text, frm_estado.SelectedIndex);
                familia.Ingresar(p);
                DateTime dt = DateTime.Now;
                string strDate = dt.ToString("yyyy-MM-dd");
                string strHora = dt.ToString("HH:mm:ss");
                Auditoria auditor = new Auditoria(0, strDate, strHora, "Agregar Familia");
                au.Ingresar(auditor);
                limpiar();
            }
            else
            {
                MessageBox.Show("Campos en Blancos, no se puede Ingresar Familia del Producto");
            }

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                CRUD_Familia familia = new CRUD_Familia();
                Familia p = new Familia(int.Parse(idoculto.Text), frmnombre.Text, frm_estado.SelectedIndex);
                familia.Modificar(p);
                DateTime dt = DateTime.Now;
                string strDate = dt.ToString("yyyy-MM-dd");
                string strHora = dt.ToString("HH:mm:ss");
                Auditoria auditor = new Auditoria(0, strDate, strHora, "Modificar Familia");
                au.Ingresar(auditor);
                limpiar();
            }
            else
            {
                MessageBox.Show("Campos en Blancos, no se puede Ingresar La Familia del Producto");
            }

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult op = MessageBox.Show("¿Está seguro que desea eliminar el registro seleccionado ? ","Confirmación",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (op == DialogResult.Yes)
            {
                CRUD_Familia familia = new CRUD_Familia();
                Familia p = new Familia(int.Parse(idoculto.Text), frmnombre.Text, frm_estado.SelectedIndex);
                familia.Eliminar(p);
                DateTime dt = DateTime.Now;
                string strDate = dt.ToString("yyyy-MM-dd");
                string strHora = dt.ToString("HH:mm:ss");
                Auditoria auditor = new Auditoria(0, strDate, strHora, "Cambiar Estado a Inactivo");
                au.Ingresar(auditor);
                limpiar();
            }
            else
            {
                limpiar();
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void grilla_familia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridView ver = (DataGridView)sender;
                idoculto.Text = (grilla_familia.Rows[e.RowIndex].Cells[0].Value.ToString());
                frmnombre.Text = (grilla_familia.Rows[e.RowIndex].Cells[1].Value.ToString());
                frm_estado.SelectedItem =(grilla_familia.Rows[e.RowIndex].Cells[2].Value.ToString());
                btningresar.Enabled = false;
                btnmodificar.Enabled = true;
                btneliminar.Enabled = true;
            }
            catch (Exception exc)
            {
                exc.ToString();
            }

        }

        private void frmbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            CRUD_Familia familia = new CRUD_Familia();
            grilla_familia.DataSource = null;
            familia.filtrar(frmbuscar.Text);
            grilla_familia.DataSource = familia.dt;
            totalregistros.Text = "Total de Registros (" + grilla_familia.RowCount.ToString()+ ")";
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

        private void btnexportar_Click(object sender, EventArgs e)
        {
            exportaraexcel(grilla_familia);
        }
    }
}
