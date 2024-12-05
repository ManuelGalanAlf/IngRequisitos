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
            this.bAtributos = new System.Windows.Forms.Button();
            this.bCategorias = new System.Windows.Forms.Button();
            this.bProductos = new System.Windows.Forms.Button();
            this.bDashboard = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.bCrearProducto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bAtributos
            // 
            this.bAtributos.Location = new System.Drawing.Point(460, 59);
            this.bAtributos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bAtributos.Name = "bAtributos";
            this.bAtributos.Size = new System.Drawing.Size(112, 47);
            this.bAtributos.TabIndex = 30;
            this.bAtributos.Text = "Atributos";
            this.bAtributos.UseVisualStyleBackColor = true;
            this.bAtributos.Click += new System.EventHandler(this.bAtributos_Click);
            // 
            // bCategorias
            // 
            this.bCategorias.Location = new System.Drawing.Point(326, 59);
            this.bCategorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bCategorias.Name = "bCategorias";
            this.bCategorias.Size = new System.Drawing.Size(112, 47);
            this.bCategorias.TabIndex = 29;
            this.bCategorias.Text = "Categorias";
            this.bCategorias.UseVisualStyleBackColor = true;
            this.bCategorias.Click += new System.EventHandler(this.bCategorias_Click);
            // 
            // bProductos
            // 
            this.bProductos.Location = new System.Drawing.Point(196, 59);
            this.bProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bProductos.Name = "bProductos";
            this.bProductos.Size = new System.Drawing.Size(112, 47);
            this.bProductos.TabIndex = 28;
            this.bProductos.Text = "Productos";
            this.bProductos.UseVisualStyleBackColor = true;
            this.bProductos.Click += new System.EventHandler(this.bProductos_Click);
            // 
            // bDashboard
            // 
            this.bDashboard.Location = new System.Drawing.Point(73, 59);
            this.bDashboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bDashboard.Name = "bDashboard";
            this.bDashboard.Size = new System.Drawing.Size(112, 47);
            this.bDashboard.TabIndex = 27;
            this.bDashboard.Text = "Dashboard";
            this.bDashboard.UseVisualStyleBackColor = true;
            this.bDashboard.Click += new System.EventHandler(this.bDashboard_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(20, 141);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(57, 13);
            this.linkLabel1.TabIndex = 33;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Categorias";
            // 
            // bCrearProducto
            // 
            this.bCrearProducto.Location = new System.Drawing.Point(548, 230);
            this.bCrearProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bCrearProducto.Name = "bCrearProducto";
            this.bCrearProducto.Size = new System.Drawing.Size(191, 47);
            this.bCrearProducto.TabIndex = 32;
            this.bCrearProducto.Text = "Crear Categoria";
            this.bCrearProducto.UseVisualStyleBackColor = true;
            this.bCrearProducto.Click += new System.EventHandler(this.bCrearProducto_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 177);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(480, 180);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ListarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 477);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.bCrearProducto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bAtributos);
            this.Controls.Add(this.bCategorias);
            this.Controls.Add(this.bProductos);
            this.Controls.Add(this.bDashboard);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ListarCategoria";
            this.Text = "ListarCategoria";
            this.Load += new System.EventHandler(this.ListarCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAtributos;
        private System.Windows.Forms.Button bCategorias;
        private System.Windows.Forms.Button bProductos;
        private System.Windows.Forms.Button bDashboard;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button bCrearProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}