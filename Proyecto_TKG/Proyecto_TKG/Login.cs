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
    public partial class Login : Form
    {

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
        public void LimpiarCampos()
        {
            frmusuario.Text = "";
            frmclave.Text = "";
            frmusuario.Focus();
        }

        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validar())
        {

                frmusuario.Text.Trim().ToUpper();
                CRUD_Usuarios usuario = new CRUD_Usuarios();
                if (usuario.Login(frmusuario.Text, GetMD5Hash(frmclave.Text)))
                {
                    Menu login = new Menu();
                    login.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Porfavor ingrese todos los datos solicitados");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //this.Close();
            //this.Hide();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public Boolean validar()
        {
            Boolean sw = true;
            if (frmusuario.Text == "")
            {
                sw = false;
            }
            if (frmclave.Text == "")
            {
                sw = false;
            }
            return sw;
        }

        private void frmclave_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
