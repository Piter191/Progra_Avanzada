
using System;

namespace Proyecto_TKG
{
    partial class Form_Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Compras));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.frmid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.frmstock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.frmproductos = new System.Windows.Forms.ComboBox();
            this.frmprecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.frmcantidad = new System.Windows.Forms.NumericUpDown();
            this.frmcategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.frmpagar = new System.Windows.Forms.TextBox();
            this.labeltotal = new System.Windows.Forms.Label();
            this.frmbuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grilla_compras = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.frmfactura = new System.Windows.Forms.TextBox();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmcantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_compras)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.frmid);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.frmstock);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.frmproductos);
            this.groupBox1.Controls.Add(this.frmprecio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.frmcantidad);
            this.groupBox1.Controls.Add(this.frmcategoria);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compras";
            // 
            // frmid
            // 
            this.frmid.Enabled = false;
            this.frmid.Location = new System.Drawing.Point(20, 145);
            this.frmid.Name = "frmid";
            this.frmid.Size = new System.Drawing.Size(72, 20);
            this.frmid.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "ID";
            // 
            // frmstock
            // 
            this.frmstock.Enabled = false;
            this.frmstock.Location = new System.Drawing.Point(374, 145);
            this.frmstock.Name = "frmstock";
            this.frmstock.Size = new System.Drawing.Size(100, 20);
            this.frmstock.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(400, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Stock";
            // 
            // frmproductos
            // 
            this.frmproductos.FormattingEnabled = true;
            this.frmproductos.Location = new System.Drawing.Point(6, 69);
            this.frmproductos.Name = "frmproductos";
            this.frmproductos.Size = new System.Drawing.Size(121, 21);
            this.frmproductos.TabIndex = 7;
            this.frmproductos.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // frmprecio
            // 
            this.frmprecio.Enabled = false;
            this.frmprecio.Location = new System.Drawing.Point(182, 145);
            this.frmprecio.Name = "frmprecio";
            this.frmprecio.Size = new System.Drawing.Size(121, 20);
            this.frmprecio.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(214, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio";
            // 
            // frmcantidad
            // 
            this.frmcantidad.Location = new System.Drawing.Point(365, 70);
            this.frmcantidad.Name = "frmcantidad";
            this.frmcantidad.Size = new System.Drawing.Size(120, 20);
            this.frmcantidad.TabIndex = 4;
            // 
            // frmcategoria
            // 
            this.frmcategoria.Enabled = false;
            this.frmcategoria.FormattingEnabled = true;
            this.frmcategoria.Location = new System.Drawing.Point(182, 70);
            this.frmcategoria.Name = "frmcategoria";
            this.frmcategoria.Size = new System.Drawing.Size(121, 21);
            this.frmcategoria.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.frmfactura);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.frmpagar);
            this.groupBox2.Controls.Add(this.labeltotal);
            this.groupBox2.Controls.Add(this.frmbuscar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.grilla_compras);
            this.groupBox2.Location = new System.Drawing.Point(12, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 246);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // frmpagar
            // 
            this.frmpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmpagar.Location = new System.Drawing.Point(138, 215);
            this.frmpagar.Name = "frmpagar";
            this.frmpagar.Size = new System.Drawing.Size(123, 24);
            this.frmpagar.TabIndex = 4;
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotal.Location = new System.Drawing.Point(16, 219);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(116, 20);
            this.labeltotal.TabIndex = 3;
            this.labeltotal.Text = "Total a Pagar";
            // 
            // frmbuscar
            // 
            this.frmbuscar.Location = new System.Drawing.Point(52, 22);
            this.frmbuscar.Name = "frmbuscar";
            this.frmbuscar.Size = new System.Drawing.Size(100, 20);
            this.frmbuscar.TabIndex = 2;
            this.frmbuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Buscar";
            // 
            // grilla_compras
            // 
            this.grilla_compras.AllowUserToAddRows = false;
            this.grilla_compras.AllowUserToDeleteRows = false;
            this.grilla_compras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grilla_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_compras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.grilla_compras.Location = new System.Drawing.Point(6, 59);
            this.grilla_compras.Name = "grilla_compras";
            this.grilla_compras.ReadOnly = true;
            this.grilla_compras.Size = new System.Drawing.Size(764, 150);
            this.grilla_compras.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(630, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(630, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(630, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = "Guardar y Comprar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(630, 486);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 42);
            this.button4.TabIndex = 5;
            this.button4.Text = "Regresar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nª Factura";
            // 
            // frmfactura
            // 
            this.frmfactura.Location = new System.Drawing.Point(591, 26);
            this.frmfactura.Name = "frmfactura";
            this.frmfactura.Size = new System.Drawing.Size(100, 20);
            this.frmfactura.TabIndex = 6;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Codigo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Producto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Precio";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Form_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(797, 532);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form_Compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Compras";
            this.Load += new System.EventHandler(this.Form_Compras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmcantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_compras)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox frmid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox frmstock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox frmproductos;
        private System.Windows.Forms.TextBox frmprecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown frmcantidad;
        private System.Windows.Forms.ComboBox frmcategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox frmbuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grilla_compras;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.TextBox frmpagar;
        private System.Windows.Forms.TextBox frmfactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}