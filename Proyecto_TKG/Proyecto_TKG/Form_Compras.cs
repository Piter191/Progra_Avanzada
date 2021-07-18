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
    public partial class Form_Compras : Form
    {
        public Form_Compras()
        {
            InitializeComponent();
        }

        private void Form_Compras_Load(object sender, EventArgs e)
        {
            CargarFamiliasProductos();
            CargarProductos();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion_Sql cone = new Conexion_Sql();
            cone.conectar().Open();
            SqlCommand cmd = cone.conex.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Productos where idProducto='" + frmproductos.SelectedValue + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                frmid.Text = dr["idProducto"].ToString();
                frmprecio.Text = dr["costo"].ToString();
                frmstock.Text = dr["stock"].ToString();
                frmcategoria.Text = dr["familia"].ToString();
            }

            cone.conex.Close();
        }
        public void CargarProductos()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            Conexion_Sql cone = new Conexion_Sql();
            dt.Clear();
            string sql = "select * from Productos where estado='Activo'";
            SqlDataAdapter mda = new SqlDataAdapter();
            mda.SelectCommand = new SqlCommand(sql, cone.conectar());
            mda.Fill(dt);
            frmproductos.DisplayMember = "nombreProducto";
            frmproductos.ValueMember = "idProducto";
            frmproductos.DataSource = dt;
        }

        public void CargarFamiliasProductos()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            Conexion_Sql cone = new Conexion_Sql();
            dt.Clear();
            string sql = "select * from Familia_Productos where estadoFamiliaProductos=1";
            SqlDataAdapter mda = new SqlDataAdapter();
            mda.SelectCommand = new SqlCommand(sql, cone.conectar());
            mda.Fill(dt);
            frmcategoria.DisplayMember = "nombreFamiliaProductos";
            frmcategoria.ValueMember = "idFamiliaProductos";
            frmcategoria.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exportaraexcel(grilla_compras);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cod;

            cod = frmproductos.SelectedIndex;

            switch (cod)
            {
                case 0: frmfactura.Text = "0011"; break;
                case 1: frmfactura.Text = "0022"; break;
                default: frmfactura.Text = "0033"; break;
            }

            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(grilla_compras);

            file.Cells[0].Value = frmid.Text;
            file.Cells[1].Value = frmfactura.Text;
            file.Cells[2].Value = frmproductos.Text;
            file.Cells[3].Value = frmprecio.Text;
            file.Cells[4].Value = frmcantidad.Text;
            file.Cells[5].Value = (float.Parse(frmprecio.Text) * float.Parse(frmcantidad.Text)).ToString();

            grilla_compras.Rows.Add(file);

            limpiar();
            obtenerTotal();
        }

        public void limpiar()
        {
            frmid.Text = "";
            frmproductos.Text = "";
            frmprecio.Text = "";
            frmcategoria.Text = "";
            frmstock.Text = "";
            frmfactura.Text = "";
            frmcantidad.Value = 0;
        }

        public void obtenerTotal()
        {
            float costo = 0;
            int contador = 0;

            contador = grilla_compras.RowCount;


            for (int i = 0; i < contador; i++)
            {
                costo += float.Parse(grilla_compras.Rows[i].Cells[5].Value.ToString());
            }


            frmpagar.Text = costo.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rppta = MessageBox.Show("Desea eliminar el Producto?", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(rppta == DialogResult.Yes)
                {
                    grilla_compras.Rows.Remove(grilla_compras.CurrentRow);
                }
            }
            catch
            {
                
            }
            obtenerTotal();
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
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            CRUD_Compras compra = new CRUD_Compras();
            grilla_compras.DataSource = null;
            compra.filtrar(frmbuscar.Text);
            grilla_compras.DataSource = compra.dt;
        }
    }
}
