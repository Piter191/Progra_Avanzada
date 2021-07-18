
namespace Proyecto_TKG
{
    partial class Form_Usuarios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Usuarios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.frmtipoUsuario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.frmclave = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.frmusuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.frmestado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.frmrut = new System.Windows.Forms.TextBox();
            this.frmemail = new System.Windows.Forms.TextBox();
            this.frmnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grilla_usuarios = new System.Windows.Forms.DataGridView();
            this.totalregistros = new System.Windows.Forms.Label();
            this.btnexportar = new System.Windows.Forms.Button();
            this.frmbuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.idoculto = new System.Windows.Forms.TextBox();
            this.brnregresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.frmtipoUsuario);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.frmclave);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.frmusuario);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.frmestado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.frmrut);
            this.groupBox1.Controls.Add(this.frmemail);
            this.groupBox1.Controls.Add(this.frmnombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(26, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Antecedentes del Usuario";
            // 
            // frmtipoUsuario
            // 
            this.frmtipoUsuario.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmtipoUsuario.FormattingEnabled = true;
            this.frmtipoUsuario.Items.AddRange(new object[] {
            "Seleccionar:",
            "Administrador",
            "Despachador"});
            this.frmtipoUsuario.Location = new System.Drawing.Point(798, 55);
            this.frmtipoUsuario.Name = "frmtipoUsuario";
            this.frmtipoUsuario.Size = new System.Drawing.Size(121, 25);
            this.frmtipoUsuario.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(679, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo Usuario :";
            // 
            // frmclave
            // 
            this.frmclave.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmclave.Location = new System.Drawing.Point(780, 115);
            this.frmclave.Name = "frmclave";
            this.frmclave.Size = new System.Drawing.Size(135, 25);
            this.frmclave.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(707, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Clave :";
            // 
            // frmusuario
            // 
            this.frmusuario.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmusuario.Location = new System.Drawing.Point(306, 114);
            this.frmusuario.Name = "frmusuario";
            this.frmusuario.Size = new System.Drawing.Size(135, 25);
            this.frmusuario.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(223, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Usuario :";
            // 
            // frmestado
            // 
            this.frmestado.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmestado.FormattingEnabled = true;
            this.frmestado.Items.AddRange(new object[] {
            "Seleccionar:",
            "Activo",
            "Inactivo"});
            this.frmestado.Location = new System.Drawing.Point(565, 114);
            this.frmestado.Name = "frmestado";
            this.frmestado.Size = new System.Drawing.Size(121, 25);
            this.frmestado.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(492, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estado:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmrut
            // 
            this.frmrut.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmrut.Location = new System.Drawing.Point(56, 114);
            this.frmrut.Name = "frmrut";
            this.frmrut.Size = new System.Drawing.Size(135, 25);
            this.frmrut.TabIndex = 5;
            this.frmrut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmrut_KeyPress);
            // 
            // frmemail
            // 
            this.frmemail.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmemail.Location = new System.Drawing.Point(433, 52);
            this.frmemail.Name = "frmemail";
            this.frmemail.Size = new System.Drawing.Size(237, 25);
            this.frmemail.TabIndex = 4;
            // 
            // frmnombre
            // 
            this.frmnombre.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmnombre.Location = new System.Drawing.Point(87, 52);
            this.frmnombre.Name = "frmnombre";
            this.frmnombre.Size = new System.Drawing.Size(264, 25);
            this.frmnombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rut :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(367, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(11, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_limpiar);
            this.groupBox2.Controls.Add(this.btn_eliminar);
            this.groupBox2.Controls.Add(this.btn_modificar);
            this.groupBox2.Controls.Add(this.btn_ingresar);
            this.groupBox2.Location = new System.Drawing.Point(26, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(932, 98);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.Image")));
            this.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpiar.Location = new System.Drawing.Point(710, 34);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(164, 37);
            this.btn_limpiar.TabIndex = 3;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(485, 34);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(164, 37);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificar.Image")));
            this.btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificar.Location = new System.Drawing.Point(250, 34);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(164, 37);
            this.btn_modificar.TabIndex = 1;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_ingresar.Image")));
            this.btn_ingresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ingresar.Location = new System.Drawing.Point(25, 34);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(164, 37);
            this.btn_ingresar.TabIndex = 0;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grilla_usuarios);
            this.groupBox3.Controls.Add(this.totalregistros);
            this.groupBox3.Controls.Add(this.btnexportar);
            this.groupBox3.Controls.Add(this.frmbuscar);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(26, 374);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(932, 265);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado Usuarios";
            // 
            // grilla_usuarios
            // 
            this.grilla_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grilla_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_usuarios.Location = new System.Drawing.Point(25, 63);
            this.grilla_usuarios.Name = "grilla_usuarios";
            this.grilla_usuarios.Size = new System.Drawing.Size(890, 163);
            this.grilla_usuarios.TabIndex = 10;
            this.grilla_usuarios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grilla_usuarios_CellMouseClick);
            // 
            // totalregistros
            // 
            this.totalregistros.AutoSize = true;
            this.totalregistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalregistros.ForeColor = System.Drawing.SystemColors.Desktop;
            this.totalregistros.Location = new System.Drawing.Point(22, 244);
            this.totalregistros.Name = "totalregistros";
            this.totalregistros.Size = new System.Drawing.Size(46, 18);
            this.totalregistros.TabIndex = 9;
            this.totalregistros.Text = "label6";
            // 
            // btnexportar
            // 
            this.btnexportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnexportar.Image = ((System.Drawing.Image)(resources.GetObject("btnexportar.Image")));
            this.btnexportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexportar.Location = new System.Drawing.Point(728, 21);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(146, 34);
            this.btnexportar.TabIndex = 4;
            this.btnexportar.Text = "Exportar";
            this.btnexportar.UseVisualStyleBackColor = true;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // frmbuscar
            // 
            this.frmbuscar.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmbuscar.Location = new System.Drawing.Point(90, 30);
            this.frmbuscar.Name = "frmbuscar";
            this.frmbuscar.Size = new System.Drawing.Size(99, 25);
            this.frmbuscar.TabIndex = 8;
            this.frmbuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmbuscar_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(22, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Buscar:";
            // 
            // idoculto
            // 
            this.idoculto.Location = new System.Drawing.Point(761, 23);
            this.idoculto.Name = "idoculto";
            this.idoculto.Size = new System.Drawing.Size(71, 20);
            this.idoculto.TabIndex = 8;
            // 
            // brnregresar
            // 
            this.brnregresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnregresar.Image = ((System.Drawing.Image)(resources.GetObject("brnregresar.Image")));
            this.brnregresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnregresar.Location = new System.Drawing.Point(396, 12);
            this.brnregresar.Name = "brnregresar";
            this.brnregresar.Size = new System.Drawing.Size(164, 37);
            this.brnregresar.TabIndex = 4;
            this.brnregresar.Text = "Regresar";
            this.brnregresar.UseVisualStyleBackColor = true;
            this.brnregresar.Click += new System.EventHandler(this.brnregresar_Click);
            // 
            // Form_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(970, 651);
            this.Controls.Add(this.brnregresar);
            this.Controls.Add(this.idoculto);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MaximizeBox = false;
            this.Name = "Form_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor De Usuario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox frmrut;
        private System.Windows.Forms.TextBox frmemail;
        private System.Windows.Forms.TextBox frmnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox frmestado;
        private System.Windows.Forms.Button btnexportar;
        private System.Windows.Forms.TextBox frmbuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idoculto;
        private System.Windows.Forms.DataGridView grilla_usuarios;
        private System.Windows.Forms.Label totalregistros;
        private System.Windows.Forms.TextBox frmclave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox frmusuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox frmtipoUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button brnregresar;
    }
}

