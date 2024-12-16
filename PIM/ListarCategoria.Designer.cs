namespace PIM
{
    partial class ListarCategoria
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
            this.bCrearProducto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bAtributos = new System.Windows.Forms.Button();
            this.bCategorias = new System.Windows.Forms.Button();
            this.bProductos = new System.Windows.Forms.Button();
            this.bDashboard = new System.Windows.Forms.Button();
            this.bRelaciones = new System.Windows.Forms.Button();
            this.bCuenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bCrearProducto
            // 
            this.bCrearProducto.Location = new System.Drawing.Point(948, 261);
            this.bCrearProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCrearProducto.Name = "bCrearProducto";
            this.bCrearProducto.Size = new System.Drawing.Size(255, 58);
            this.bCrearProducto.TabIndex = 39;
            this.bCrearProducto.Text = "Create Category";
            this.bCrearProducto.UseVisualStyleBackColor = true;
            this.bCrearProducto.Click += new System.EventHandler(this.bCrearProducto_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(180, 204);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(640, 222);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bAtributos
            // 
            this.bAtributos.Location = new System.Drawing.Point(725, 54);
            this.bAtributos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAtributos.Name = "bAtributos";
            this.bAtributos.Size = new System.Drawing.Size(149, 58);
            this.bAtributos.TabIndex = 37;
            this.bAtributos.Text = "Attributes";
            this.bAtributos.UseVisualStyleBackColor = true;
            this.bAtributos.Click += new System.EventHandler(this.bAtributos_Click);
            // 
            // bCategorias
            // 
            this.bCategorias.Location = new System.Drawing.Point(547, 54);
            this.bCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCategorias.Name = "bCategorias";
            this.bCategorias.Size = new System.Drawing.Size(149, 58);
            this.bCategorias.TabIndex = 36;
            this.bCategorias.Text = "Categories";
            this.bCategorias.UseVisualStyleBackColor = true;
            this.bCategorias.Click += new System.EventHandler(this.bCategorias_Click);
            // 
            // bProductos
            // 
            this.bProductos.Location = new System.Drawing.Point(373, 54);
            this.bProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bProductos.Name = "bProductos";
            this.bProductos.Size = new System.Drawing.Size(149, 58);
            this.bProductos.TabIndex = 35;
            this.bProductos.Text = "Products";
            this.bProductos.UseVisualStyleBackColor = true;
            this.bProductos.Click += new System.EventHandler(this.bProductos_Click);
            // 
            // bDashboard
            // 
            this.bDashboard.Location = new System.Drawing.Point(209, 54);
            this.bDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDashboard.Name = "bDashboard";
            this.bDashboard.Size = new System.Drawing.Size(149, 58);
            this.bDashboard.TabIndex = 34;
            this.bDashboard.Text = "Dashboard";
            this.bDashboard.UseVisualStyleBackColor = true;
            this.bDashboard.Click += new System.EventHandler(this.bDashboard_Click);
            // 
            // bRelaciones
            // 
            this.bRelaciones.Location = new System.Drawing.Point(905, 54);
            this.bRelaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bRelaciones.Name = "bRelaciones";
            this.bRelaciones.Size = new System.Drawing.Size(149, 58);
            this.bRelaciones.TabIndex = 49;
            this.bRelaciones.Text = "Relations";
            this.bRelaciones.UseVisualStyleBackColor = true;
            this.bRelaciones.Click += new System.EventHandler(this.bRelaciones_Click);
            // 
            // bCuenta
            // 
            this.bCuenta.Location = new System.Drawing.Point(1175, 54);
            this.bCuenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCuenta.Name = "bCuenta";
            this.bCuenta.Size = new System.Drawing.Size(149, 58);
            this.bCuenta.TabIndex = 86;
            this.bCuenta.Text = "Account";
            this.bCuenta.UseVisualStyleBackColor = true;
            this.bCuenta.Click += new System.EventHandler(this.bCuenta_Click);
            // 
            // ListarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 633);
            this.Controls.Add(this.bCuenta);
            this.Controls.Add(this.bRelaciones);
            this.Controls.Add(this.bCrearProducto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bAtributos);
            this.Controls.Add(this.bCategorias);
            this.Controls.Add(this.bProductos);
            this.Controls.Add(this.bDashboard);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListarCategoria";
            this.Text = "ListarCategoria";
            this.Load += new System.EventHandler(this.ListarCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCrearProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bAtributos;
        private System.Windows.Forms.Button bCategorias;
        private System.Windows.Forms.Button bProductos;
        private System.Windows.Forms.Button bDashboard;
        private System.Windows.Forms.Button bRelaciones;
        private System.Windows.Forms.Button bCuenta;
    }
}