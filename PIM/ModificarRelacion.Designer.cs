namespace PIM
{
    partial class ModificarRelacion
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
            this.bRelaciones = new System.Windows.Forms.Button();
            this.bProductos = new System.Windows.Forms.Button();
            this.bAtributos = new System.Windows.Forms.Button();
            this.bCategorias = new System.Windows.Forms.Button();
            this.bDashboard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbProducto2 = new System.Windows.Forms.ListBox();
            this.lbProducto1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bVolver = new System.Windows.Forms.Button();
            this.bCuenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bRelaciones
            // 
            this.bRelaciones.Location = new System.Drawing.Point(852, 57);
            this.bRelaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bRelaciones.Name = "bRelaciones";
            this.bRelaciones.Size = new System.Drawing.Size(149, 58);
            this.bRelaciones.TabIndex = 42;
            this.bRelaciones.Text = "Relations";
            this.bRelaciones.UseVisualStyleBackColor = true;
            this.bRelaciones.Click += new System.EventHandler(this.bRelaciones_Click);
            // 
            // bProductos
            // 
            this.bProductos.Location = new System.Drawing.Point(335, 57);
            this.bProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bProductos.Name = "bProductos";
            this.bProductos.Size = new System.Drawing.Size(149, 58);
            this.bProductos.TabIndex = 41;
            this.bProductos.Text = "Products";
            this.bProductos.UseVisualStyleBackColor = true;
            this.bProductos.Click += new System.EventHandler(this.bProductos_Click);
            // 
            // bAtributos
            // 
            this.bAtributos.Location = new System.Drawing.Point(675, 57);
            this.bAtributos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAtributos.Name = "bAtributos";
            this.bAtributos.Size = new System.Drawing.Size(149, 58);
            this.bAtributos.TabIndex = 40;
            this.bAtributos.Text = "Attributes";
            this.bAtributos.UseVisualStyleBackColor = true;
            this.bAtributos.Click += new System.EventHandler(this.bAtributos_Click);
            // 
            // bCategorias
            // 
            this.bCategorias.Location = new System.Drawing.Point(507, 57);
            this.bCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCategorias.Name = "bCategorias";
            this.bCategorias.Size = new System.Drawing.Size(149, 58);
            this.bCategorias.TabIndex = 39;
            this.bCategorias.Text = "Categories";
            this.bCategorias.UseVisualStyleBackColor = true;
            this.bCategorias.Click += new System.EventHandler(this.bCategorias_Click);
            // 
            // bDashboard
            // 
            this.bDashboard.Location = new System.Drawing.Point(169, 57);
            this.bDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDashboard.Name = "bDashboard";
            this.bDashboard.Size = new System.Drawing.Size(149, 58);
            this.bDashboard.TabIndex = 38;
            this.bDashboard.Text = "Dashboard";
            this.bDashboard.UseVisualStyleBackColor = true;
            this.bDashboard.Click += new System.EventHandler(this.bDashboard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 60;
            this.label2.Text = "Name";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(81, 217);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(397, 22);
            this.tbNombre.TabIndex = 54;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 334);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 255);
            this.dataGridView1.TabIndex = 62;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Yellow;
            this.bAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bAdd.Location = new System.Drawing.Point(1229, 199);
            this.bAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(89, 31);
            this.bAdd.TabIndex = 68;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(700, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 67;
            this.label1.Text = "Select the products to relate";
            // 
            // lbProducto2
            // 
            this.lbProducto2.FormattingEnabled = true;
            this.lbProducto2.ItemHeight = 16;
            this.lbProducto2.Location = new System.Drawing.Point(1077, 246);
            this.lbProducto2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbProducto2.Name = "lbProducto2";
            this.lbProducto2.Size = new System.Drawing.Size(241, 228);
            this.lbProducto2.TabIndex = 66;
            // 
            // lbProducto1
            // 
            this.lbProducto1.FormattingEnabled = true;
            this.lbProducto1.ItemHeight = 16;
            this.lbProducto1.Location = new System.Drawing.Point(703, 246);
            this.lbProducto1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbProducto1.Name = "lbProducto1";
            this.lbProducto1.Size = new System.Drawing.Size(241, 228);
            this.lbProducto1.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 24);
            this.label3.TabIndex = 69;
            this.label3.Text = "Already related products";
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.Red;
            this.bVolver.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bVolver.Location = new System.Drawing.Point(1169, 531);
            this.bVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(149, 58);
            this.bVolver.TabIndex = 71;
            this.bVolver.Text = "Return";
            this.bVolver.UseVisualStyleBackColor = false;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bCuenta
            // 
            this.bCuenta.Location = new System.Drawing.Point(1139, 57);
            this.bCuenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCuenta.Name = "bCuenta";
            this.bCuenta.Size = new System.Drawing.Size(149, 58);
            this.bCuenta.TabIndex = 86;
            this.bCuenta.Text = "Account";
            this.bCuenta.UseVisualStyleBackColor = true;
            this.bCuenta.Click += new System.EventHandler(this.bCuenta_Click);
            // 
            // ModificarRelacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 633);
            this.Controls.Add(this.bCuenta);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbProducto2);
            this.Controls.Add(this.lbProducto1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.bRelaciones);
            this.Controls.Add(this.bProductos);
            this.Controls.Add(this.bAtributos);
            this.Controls.Add(this.bCategorias);
            this.Controls.Add(this.bDashboard);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModificarRelacion";
            this.Text = "ModificarRelacion";
            this.Load += new System.EventHandler(this.ModificarRelacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRelaciones;
        private System.Windows.Forms.Button bProductos;
        private System.Windows.Forms.Button bAtributos;
        private System.Windows.Forms.Button bCategorias;
        private System.Windows.Forms.Button bDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbProducto2;
        private System.Windows.Forms.ListBox lbProducto1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bCuenta;
    }
}