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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bCrearProducto
            // 
            this.bCrearProducto.Location = new System.Drawing.Point(711, 212);
            this.bCrearProducto.Margin = new System.Windows.Forms.Padding(2);
            this.bCrearProducto.Name = "bCrearProducto";
            this.bCrearProducto.Size = new System.Drawing.Size(191, 47);
            this.bCrearProducto.TabIndex = 39;
            this.bCrearProducto.Text = "Crear Categoria";
            this.bCrearProducto.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(135, 166);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(480, 180);
            this.dataGridView1.TabIndex = 38;
            // 
            // bAtributos
            // 
            this.bAtributos.Location = new System.Drawing.Point(544, 44);
            this.bAtributos.Margin = new System.Windows.Forms.Padding(2);
            this.bAtributos.Name = "bAtributos";
            this.bAtributos.Size = new System.Drawing.Size(112, 47);
            this.bAtributos.TabIndex = 37;
            this.bAtributos.Text = "Atributos";
            this.bAtributos.UseVisualStyleBackColor = true;
            // 
            // bCategorias
            // 
            this.bCategorias.Location = new System.Drawing.Point(410, 44);
            this.bCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.bCategorias.Name = "bCategorias";
            this.bCategorias.Size = new System.Drawing.Size(112, 47);
            this.bCategorias.TabIndex = 36;
            this.bCategorias.Text = "Categorias";
            this.bCategorias.UseVisualStyleBackColor = true;
            // 
            // bProductos
            // 
            this.bProductos.Location = new System.Drawing.Point(280, 44);
            this.bProductos.Margin = new System.Windows.Forms.Padding(2);
            this.bProductos.Name = "bProductos";
            this.bProductos.Size = new System.Drawing.Size(112, 47);
            this.bProductos.TabIndex = 35;
            this.bProductos.Text = "Productos";
            this.bProductos.UseVisualStyleBackColor = true;
            // 
            // bDashboard
            // 
            this.bDashboard.Location = new System.Drawing.Point(157, 44);
            this.bDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.bDashboard.Name = "bDashboard";
            this.bDashboard.Size = new System.Drawing.Size(112, 47);
            this.bDashboard.TabIndex = 34;
            this.bDashboard.Text = "Dashboard";
            this.bDashboard.UseVisualStyleBackColor = true;
            // 
            // ListarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 514);
            this.Controls.Add(this.bCrearProducto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bAtributos);
            this.Controls.Add(this.bCategorias);
            this.Controls.Add(this.bProductos);
            this.Controls.Add(this.bDashboard);
            this.Name = "ListarCategoria";
            this.Text = "ListarCategoria";
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
    }
}