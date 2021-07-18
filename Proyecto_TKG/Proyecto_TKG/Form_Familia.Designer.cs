
namespace Proyecto_TKG
{
    partial class Form_Familia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Familia));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.frm_estado = new System.Windows.Forms.ComboBox();
            this.frmnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btningresar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnexportar = new System.Windows.Forms.Button();
            this.totalregistros = new System.Windows.Forms.Label();
            this.frmbuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grilla_familia = new System.Windows.Forms.DataGridView();
            this.idoculto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_familia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.frm_estado);
            this.groupBox1.Controls.Add(this.frmnombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Familia de Productos";
            // 
            // frm_estado
            // 
            this.frm_estado.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frm_estado.FormattingEnabled = true;
            this.frm_estado.Items.AddRange(new object[] {
            "Seleccionar",
            "Activo",
            "Inactivo"});
            this.frm_estado.Location = new System.Drawing.Point(451, 70);
            this.frm_estado.Name = "frm_estado";
            this.frm_estado.Size = new System.Drawing.Size(121, 27);
            this.frm_estado.TabIndex = 3;
            // 
            // frmnombre
            // 
            this.frmnombre.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmnombre.Location = new System.Drawing.Point(22, 72);
            this.frmnombre.Name = "frmnombre";
            this.frmnombre.Size = new System.Drawing.Size(311, 27);
            this.frmnombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(384, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Familia de Productos:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.btnlimpiar);
            this.groupBox2.Controls.Add(this.btneliminar);
            this.groupBox2.Controls.Add(this.btnmodificar);
            this.groupBox2.Controls.Add(this.btningresar);
            this.groupBox2.Location = new System.Drawing.Point(641, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 417);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(44, 362);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 38);
            this.button5.TabIndex = 4;
            this.button5.Text = "Volver";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.Image")));
            this.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlimpiar.Location = new System.Drawing.Point(34, 248);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(145, 45);
            this.btnlimpiar.TabIndex = 3;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(34, 178);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(145, 41);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodificar.Location = new System.Drawing.Point(34, 108);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(145, 40);
            this.btnmodificar.TabIndex = 1;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btningresar
            // 
            this.btningresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresar.Image = ((System.Drawing.Image)(resources.GetObject("btningresar.Image")));
            this.btningresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btningresar.Location = new System.Drawing.Point(34, 31);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(145, 46);
            this.btningresar.TabIndex = 0;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnexportar);
            this.groupBox3.Controls.Add(this.totalregistros);
            this.groupBox3.Controls.Add(this.frmbuscar);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.grilla_familia);
            this.groupBox3.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(12, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(594, 273);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado Familia De Productos";
            // 
            // btnexportar
            // 
            this.btnexportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnexportar.Image = ((System.Drawing.Image)(resources.GetObject("btnexportar.Image")));
            this.btnexportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexportar.Location = new System.Drawing.Point(427, 23);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(145, 41);
            this.btnexportar.TabIndex = 5;
            this.btnexportar.Text = "Exportar";
            this.btnexportar.UseVisualStyleBackColor = true;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // totalregistros
            // 
            this.totalregistros.AutoSize = true;
            this.totalregistros.Location = new System.Drawing.Point(19, 250);
            this.totalregistros.Name = "totalregistros";
            this.totalregistros.Size = new System.Drawing.Size(63, 16);
            this.totalregistros.TabIndex = 7;
            this.totalregistros.Text = "label4";
            // 
            // frmbuscar
            // 
            this.frmbuscar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmbuscar.Location = new System.Drawing.Point(79, 32);
            this.frmbuscar.Name = "frmbuscar";
            this.frmbuscar.Size = new System.Drawing.Size(142, 27);
            this.frmbuscar.TabIndex = 5;
            this.frmbuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmbuscar_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(18, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Buscar:";
            // 
            // grilla_familia
            // 
            this.grilla_familia.AllowUserToAddRows = false;
            this.grilla_familia.AllowUserToDeleteRows = false;
            this.grilla_familia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grilla_familia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_familia.Location = new System.Drawing.Point(6, 75);
            this.grilla_familia.Name = "grilla_familia";
            this.grilla_familia.ReadOnly = true;
            this.grilla_familia.Size = new System.Drawing.Size(566, 162);
            this.grilla_familia.TabIndex = 0;
            this.grilla_familia.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grilla_familia_CellMouseClick);
            // 
            // idoculto
            // 
            this.idoculto.Location = new System.Drawing.Point(530, 17);
            this.idoculto.Name = "idoculto";
            this.idoculto.Size = new System.Drawing.Size(70, 20);
            this.idoculto.TabIndex = 6;
            // 
            // Form_Familia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(870, 494);
            this.ControlBox = false;
            this.Controls.Add(this.idoculto);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form_Familia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Familia de Productos";
            this.Load += new System.EventHandler(this.Form_Familia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_familia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox frm_estado;
        private System.Windows.Forms.TextBox frmnombre;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.TextBox frmbuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grilla_familia;
        private System.Windows.Forms.TextBox idoculto;
        private System.Windows.Forms.Label totalregistros;
        private System.Windows.Forms.Button btnexportar;
    }
}