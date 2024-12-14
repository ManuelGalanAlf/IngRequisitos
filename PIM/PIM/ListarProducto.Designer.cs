namespace PIM
{
    partial class ListarProducto
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
            this.bProductos = new System.Windows.Forms.Button();
            this.bCrearProducto = new System.Windows.Forms.Button();
            this.bAtributos = new System.Windows.Forms.Button();
            this.bCategorias = new System.Windows.Forms.Button();
            this.bDashboard = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bRelaciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bProductos
            // 
            this.bProductos.Location = new System.Drawing.Point(271, 91);
            this.bProductos.Margin = new System.Windows.Forms.Padding(2);
            this.bProductos.Name = "bProductos";
            this.bProductos.Size = new System.Drawing.Size(112, 47);
            this.bProductos.TabIndex = 30;
            this.bProductos.Text = "Productos";
            this.bProductos.UseVisualStyleBackColor = true;
            this.bProductos.Click += new System.EventHandler(this.bProductos_Click);
            // 
            // bCrearProducto
            // 
            this.bCrearProducto.Location = new System.Drawing.Point(728, 232);
            this.bCrearProducto.Margin = new System.Windows.Forms.Padding(2);
            this.bCrearProducto.Name = "bCrearProducto";
            this.bCrearProducto.Size = new System.Drawing.Size(191, 47);
            this.bCrearProducto.TabIndex = 29;
            this.bCrearProducto.Text = "Crear Producto";
            this.bCrearProducto.UseVisualStyleBackColor = true;
            this.bCrearProducto.Click += new System.EventHandler(this.bCrearProducto_Click);
            // 
            // bAtributos
            // 
            this.bAtributos.Location = new System.Drawing.Point(526, 91);
            this.bAtributos.Margin = new System.Windows.Forms.Padding(2);
            this.bAtributos.Name = "bAtributos";
            this.bAtributos.Size = new System.Drawing.Size(112, 47);
            this.bAtributos.TabIndex = 28;
            this.bAtributos.Text = "Atributos";
            this.bAtributos.UseVisualStyleBackColor = true;
            this.bAtributos.Click += new System.EventHandler(this.bAtributos_Click);
            // 
            // bCategorias
            // 
            this.bCategorias.Location = new System.Drawing.Point(399, 91);
            this.bCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.bCategorias.Name = "bCategorias";
            this.bCategorias.Size = new System.Drawing.Size(112, 47);
            this.bCategorias.TabIndex = 27;
            this.bCategorias.Text = "Categorias";
            this.bCategorias.UseVisualStyleBackColor = true;
            this.bCategorias.Click += new System.EventHandler(this.bCategorias_Click);
            // 
            // bDashboard
            // 
            this.bDashboard.Location = new System.Drawing.Point(146, 91);
            this.bDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.bDashboard.Name = "bDashboard";
            this.bDashboard.Size = new System.Drawing.Size(112, 47);
            this.bDashboard.TabIndex = 26;
            this.bDashboard.Text = "Dashboard";
            this.bDashboard.UseVisualStyleBackColor = true;
            this.bDashboard.Click += new System.EventHandler(this.bDashboard_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(137, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(501, 185);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // bRelaciones
            // 
            this.bRelaciones.Location = new System.Drawing.Point(657, 91);
            this.bRelaciones.Margin = new System.Windows.Forms.Padding(2);
            this.bRelaciones.Name = "bRelaciones";
            this.bRelaciones.Size = new System.Drawing.Size(112, 47);
            this.bRelaciones.TabIndex = 49;
            this.bRelaciones.Text = "Relaciones";
            this.bRelaciones.UseVisualStyleBackColor = true;
            this.bRelaciones.Click += new System.EventHandler(this.bRelaciones_Click);
            // 
            // ListarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 514);
            this.Controls.Add(this.bRelaciones);
            this.Controls.Add(this.bProductos);
            this.Controls.Add(this.bCrearProducto);
            this.Controls.Add(this.bAtributos);
            this.Controls.Add(this.bCategorias);
            this.Controls.Add(this.bDashboard);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListarProducto";
            this.Text = "ListarProducto";
            this.Load += new System.EventHandler(this.ListarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bProductos;
        private System.Windows.Forms.Button bCrearProducto;
        private System.Windows.Forms.Button bAtributos;
        private System.Windows.Forms.Button bCategorias;
        private System.Windows.Forms.Button bDashboard;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bRelaciones;

    }
}