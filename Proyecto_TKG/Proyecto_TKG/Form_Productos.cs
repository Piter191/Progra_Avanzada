using Proyecto_TKG.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_TKG
{
    public partial class Form_Productos : Form
    {
        CRUD_Auditoria au = new CRUD_Auditoria();

        public Form_Productos()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form_Productos_Load(object sender, EventArgs e)
        {
            CargarFamiliasProductos();
            limpiar();
        }

        public void cargar_grilla()
        {
            CRUD_Productos producto = new CRUD_Productos();
            grilla_productos.DataSource = null;
            producto.mostrar();
            grilla_productos.DataSource = producto.dt;
            totalregistros.Text = "Total de Registros (" + grilla_productos.RowCount.ToString() + ")";

            if (grilla_productos.RowCount > 0)
            {
                btn_Exportar.Enabled = true;
            }
            else
            {
                btn_Exportar.Enabled = false;
            }
        }

        public void CargarFamiliasProductos()
        {
            Conexion_Sql cone = new Conexion_Sql();
            string sql = "SELECT nombreFamiliaProductos FROM Familia_Productos WHERE estadoFamiliaProductos = 1";
            SqlCommand comando = new SqlCommand(sql, cone.conectar());
            cone.conex.Open();
            SqlDataReader items = comando.ExecuteReader();
            while (items.Read())
            {
                frmcategoria.Items.Add(items["nombreFamiliaProductos"].ToString());
            }
            cone.conex.Close();
        }

        public void limpiar()
        {
            frmnombre.Text = "";
            frmcosto.Text = "";
            frmstock.Text = "";
            idoculto.Text = "";
            frmbuscar.Text = "";
            btn_ingresar.Enabled = true;
            btn_modificar.Enabled = false;
            btn_eliminar.Enabled = false;
            idoculto.Visible = false;
            btn_Exportar.Enabled = false;
            frmestado.SelectedIndex = 0;
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
            if (frmcosto.Text == "")
            {
                sw = false;
            }
            if (frmstock.Text == "")
            {
                sw = false;
            }
            if (frmestado.SelectedIndex.Equals(0))
            {
                sw = false;
            }
            if (frmcategoria.Text == "")
            {
                sw = false;
            }
            return sw;
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                CRUD_Productos producto = new CRUD_Productos();
                Producto p = new Producto(0, frmnombre.Text, int.Parse(frmcosto.Text),int.Parse(frmstock.Text), frmestado.Text, frmcategoria.Text);
                producto.Ingresar(p);
                DateTime dt = DateTime.Now;
                string strDate = dt.ToString("yyyy-MM-dd");
                string strHora = dt.ToString("HH:mm:ss");
                Auditoria auditor = new Auditoria(0, strDate, strHora, "Agregar Producto");
                au.Ingresar(auditor);
                limpiar();
            }
            else
            {
                MessageBox.Show("Campos en Blancos, no se puede Ingresar Producto");
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                CRUD_Productos producto = new CRUD_Productos();
                Producto p = new Producto(int.Parse(idoculto.Text), frmnombre.Text,int.Parse(frmcosto.Text), int.Parse(frmstock.Text), frmestado.Text, frmcategoria.Text);
                producto.Modificar(p);
                DateTime dt = DateTime.Now;
                string strDate = dt.ToString("yyyy-MM-dd");
                string strHora = dt.ToString("HH:mm:ss");
                Auditoria auditor = new Auditoria(0, strDate, strHora, "Modificar Producto");
                au.Ingresar(auditor);
                limpiar();
            }
            else
            {
                MessageBox.Show("Campos en Blancos, no se puede Ingresar Producto");
            }

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult op = MessageBox.Show("¿Está seguro que desea eliminar el registro seleccionado ? ","Confirmación",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (op == DialogResult.Yes)
            {
                CRUD_Productos producto = new CRUD_Productos();
                Producto p = new Producto(int.Parse(idoculto.Text), frmnombre.Text,int.Parse(frmcosto.Text), int.Parse(frmstock.Text), frmestado.Text, frmcategoria.Text);
                producto.Eliminar(p);
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

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void grilla_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grilla_productos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridView ver = (DataGridView)sender;
                idoculto.Text = (grilla_productos.Rows[e.RowIndex].Cells[0].Value.ToString());
                frmnombre.Text = (grilla_productos.Rows[e.RowIndex].Cells[1].Value.ToString());
                frmcosto.Text = (grilla_productos.Rows[e.RowIndex].Cells[2].Value.ToString());
                frmstock.Text = (grilla_productos.Rows[e.RowIndex].Cells[3].Value.ToString());
                frmestado.SelectedItem =(grilla_productos.Rows[e.RowIndex].Cells[4].Value.ToString());
                frmcategoria.SelectedItem = (grilla_productos.Rows[e.RowIndex].Cells[5].Value.ToString());
                btn_ingresar.Enabled = false;
                btn_modificar.Enabled = true;
                btn_eliminar.Enabled = true;
            }
            catch (Exception exc)
            {
                exc.ToString();
            }
        }

        private void frmstock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void frmbuscar_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void frmbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            CRUD_Productos producto = new CRUD_Productos();
            grilla_productos.DataSource = null;
            producto.filtrar(frmbuscar.Text);
            grilla_productos.DataSource = producto.dt;
            totalregistros.Text = "Total de Registros (" + grilla_productos.RowCount.ToString()+ ")";
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

        private void btn_Exportar_Click(object sender, EventArgs e)
        {
            exportaraexcel(grilla_productos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //this.Close();
            //this.Hide();
        }

        private void frmcosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
