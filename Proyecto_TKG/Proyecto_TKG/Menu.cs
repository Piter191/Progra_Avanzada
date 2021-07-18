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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Productos login = new Form_Productos();
            login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Usuarios login = new Form_Usuarios();
            login.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Familia login = new Form_Familia();
            login.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_Compras login = new Form_Compras();
            login.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_Auditoria login = new Form_Auditoria();
            login.ShowDialog();
        }
    }
    }
