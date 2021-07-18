using Proyecto_TKG.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_TKG
{
    public partial class Form_Usuarios : Form
    {
        CRUD_Auditoria au = new CRUD_Auditoria();

        public static String GetMD5Hash(String input)
        {
            MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            String hash = s.ToString();
            return hash;
        }
        public Form_Usuarios()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            limpiar();
        }

        public void cargar_grilla()
        {
            CRUD_Usuarios usuarios = new CRUD_Usuarios();
            grilla_usuarios.DataSource = null;
            usuarios.mostrar();
            grilla_usuarios.DataSource = usuarios.dt;
            totalregistros.Text = "Total de Registros (" + grilla_usuarios.RowCount.ToString() + ")";

            if (grilla_usuarios.RowCount > 0)
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
            frmemail.Text = "";
            frmrut.Text = "";
            frmusuario.Text = "";
            frmclave.Text = "";
            idoculto.Text = "";
            frmbuscar.Text = "";
            btn_ingresar.Enabled = true;
            btn_modificar.Enabled = false;
            btn_eliminar.Enabled = false;
            idoculto.Visible = false;
            btnexportar.Enabled = false;
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
            if (frmemail.Text == "")
            {
                sw = false;
            }
            if (frmrut.Text == "")
            {
                sw = false;
            }
            if (frmusuario.Text == "")
            {
                sw = false;
            }
            if (frmclave.Text == "")
            {
                sw = false;
            }
            if (frmestado.SelectedIndex.Equals(0))
            {
                sw = false;
            }
            return sw;
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                CRUD_Usuarios usuario = new CRUD_Usuarios();
                Usuarios p = new Usuarios(0, frmnombre.Text, frmemail.Text, frmrut.Text, frmusuario.Text, GetMD5Hash(frmclave.Text), 1, frmestado.SelectedIndex);
                usuario.Ingresar(p);
                DateTime dt = DateTime.Now;
                string strDate = dt.ToString("yyyy-MM-dd");
                string strHora = dt.ToString("HH:mm:ss");
                Auditoria auditor = new Auditoria(0, strDate, strHora, "Agregar Usuario");
                au.Ingresar(auditor);
                limpiar();
            }
            else
            {
                MessageBox.Show("Campos en Blancos, no se puede Ingresar el Usuario");
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                CRUD_Usuarios usuario = new CRUD_Usuarios();
                Usuarios p = new Usuarios(int.Parse(idoculto.Text), frmnombre.Text, frmemail.Text, frmrut.Text, frmusuario.Text, frmclave.Text, 1, frmestado.SelectedIndex);
                usuario.Modificar(p);
                DateTime dt = DateTime.Now;
                string strDate = dt.ToString("yyyy-MM-dd");
                string strHora = dt.ToString("HH:mm:ss");
                Auditoria auditor = new Auditoria(0, strDate, strHora, "Modificar Usuario");
                au.Ingresar(auditor);
                limpiar();
            }
            else
            {
                MessageBox.Show("Campos en Blancos, no se puede Ingresar el Usuario");
            }

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult op = MessageBox.Show("¿Está seguro que desea eliminar el registro seleccionado ? ","Confirmación",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (op == DialogResult.Yes)
            {
                CRUD_Usuarios usuario = new CRUD_Usuarios();
                Usuarios p = new Usuarios(int.Parse(idoculto.Text), frmnombre.Text, frmemail.Text, frmrut.Text, frmusuario.Text, frmclave.Text,1, frmestado.SelectedIndex); ;
                usuario.Eliminar(p);
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

        private void grilla_usuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridView ver = (DataGridView)sender;
                idoculto.Text = (grilla_usuarios.Rows[e.RowIndex].Cells[0].Value.ToString());
                frmnombre.Text = (grilla_usuarios.Rows[e.RowIndex].Cells[1].Value.ToString());
                frmemail.Text = (grilla_usuarios.Rows[e.RowIndex].Cells[2].Value.ToString());
                frmrut.Text = (grilla_usuarios.Rows[e.RowIndex].Cells[3].Value.ToString());
                frmusuario.Text = (grilla_usuarios.Rows[e.RowIndex].Cells[4].Value.ToString());
                frmestado.SelectedItem =(grilla_usuarios.Rows[e.RowIndex].Cells[5].Value.ToString());
                btn_ingresar.Enabled = false;
                btn_modificar.Enabled = true;
                btn_eliminar.Enabled = true;
            }
            catch (Exception exc)
            {
                exc.ToString();
            }
        }

        private void frmrut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void frmbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            CRUD_Usuarios usuario = new CRUD_Usuarios();
            grilla_usuarios.DataSource = null;
            usuario.filtrar(frmbuscar.Text);
            grilla_usuarios.DataSource = usuario.dt;
            totalregistros.Text = "Total de Registros (" + grilla_usuarios.RowCount.ToString() + ")";
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            exportaraexcel(grilla_usuarios);
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

        private void brnregresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //this.Close();
            //this.Hide();
        }
    }
}
