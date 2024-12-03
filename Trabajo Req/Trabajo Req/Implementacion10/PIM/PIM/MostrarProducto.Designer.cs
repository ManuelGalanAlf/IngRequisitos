namespace PIM
{
    partial class MostrarProducto
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bProductos = new System.Windows.Forms.Button();
            this.bAtributos = new System.Windows.Forms.Button();
            this.bCategorias = new System.Windows.Forms.Button();
            this.bDashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tGtin = new System.Windows.Forms.TextBox();
            this.tSKU = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(61, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 56);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bProductos
            // 
            this.bProductos.Location = new System.Drawing.Point(263, 34);
            this.bProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bProductos.Name = "bProductos";
            this.bProductos.Size = new System.Drawing.Size(149, 58);
            this.bProductos.TabIndex = 27;
            this.bProductos.Text = "Productos";
            this.bProductos.UseVisualStyleBackColor = true;
            this.bProductos.Click += new System.EventHandler(this.bProductos_Click);
            // 
            // bAtributos
            // 
            this.bAtributos.Location = new System.Drawing.Point(602, 34);
            this.bAtributos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAtributos.Name = "bAtributos";
            this.bAtributos.Size = new System.Drawing.Size(149, 58);
            this.bAtributos.TabIndex = 26;
            this.bAtributos.Text = "Atributos";
            this.bAtributos.UseVisualStyleBackColor = true;
            this.bAtributos.Click += new System.EventHandler(this.bAtributos_Click);
            // 
            // bCategorias
            // 
            this.bCategorias.Location = new System.Drawing.Point(433, 34);
            this.bCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCategorias.Name = "bCategorias";
            this.bCategorias.Size = new System.Drawing.Size(149, 58);
            this.bCategorias.TabIndex = 25;
            this.bCategorias.Text = "Categorias";
            this.bCategorias.UseVisualStyleBackColor = true;
            this.bCategorias.Click += new System.EventHandler(this.bCategorias_Click);
            // 
            // bDashboard
            // 
            this.bDashboard.Location = new System.Drawing.Point(96, 34);
            this.bDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDashboard.Name = "bDashboard";
            this.bDashboard.Size = new System.Drawing.Size(149, 58);
            this.bDashboard.TabIndex = 24;
            this.bDashboard.Text = "Dashboard";
            this.bDashboard.UseVisualStyleBackColor = true;
            this.bDashboard.Click += new System.EventHandler(this.bDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Thumbnail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Categorias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Atributos";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(433, 397);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(390, 84);
            this.listBox1.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "GTIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "SKU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Nombre";
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(64, 155);
            this.tNombre.Name = "tNombre";
            this.tNombre.ReadOnly = true;
            this.tNombre.Size = new System.Drawing.Size(164, 22);
            this.tNombre.TabIndex = 36;
            // 
            // tGtin
            // 
            this.tGtin.Location = new System.Drawing.Point(64, 363);
            this.tGtin.Name = "tGtin";
            this.tGtin.ReadOnly = true;
            this.tGtin.Size = new System.Drawing.Size(164, 22);
            this.tGtin.TabIndex = 37;
            // 
            // tSKU
            // 
            this.tSKU.Location = new System.Drawing.Point(64, 437);
            this.tSKU.Name = "tSKU";
            this.tSKU.ReadOnly = true;
            this.tSKU.Size = new System.Drawing.Size(164, 22);
            this.tSKU.TabIndex = 38;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(433, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(390, 150);
            this.dataGridView1.TabIndex = 39;
            // 
            // bEliminar
            // 
            this.bEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bEliminar.ForeColor = System.Drawing.Color.White;
            this.bEliminar.Location = new System.Drawing.Point(1175, 534);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(170, 60);
            this.bEliminar.TabIndex = 40;
            this.bEliminar.Text = "ELIMINAR";
            this.bEliminar.UseVisualStyleBackColor = false;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bModificar
            // 
            this.bModificar.BackColor = System.Drawing.Color.Yellow;
            this.bModificar.ForeColor = System.Drawing.Color.Black;
            this.bModificar.Location = new System.Drawing.Point(955, 534);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(170, 60);
            this.bModificar.TabIndex = 41;
            this.bModificar.Text = "MODIFICAR";
            this.bModificar.UseVisualStyleBackColor = false;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // MostrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 633);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tSKU);
            this.Controls.Add(this.tGtin);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bProductos);
            this.Controls.Add(this.bAtributos);
            this.Controls.Add(this.bCategorias);
            this.Controls.Add(this.bDashboard);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MostrarProducto";
            this.Text = "MostrarProducto";
            this.Load += new System.EventHandler(this.MostrarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bProductos;
        private System.Windows.Forms.Button bAtributos;
        private System.Windows.Forms.Button bCategorias;
        private System.Windows.Forms.Button bDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tGtin;
        private System.Windows.Forms.TextBox tSKU;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bModificar;
    }
}