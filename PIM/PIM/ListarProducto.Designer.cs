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
            this.button1 = new System.Windows.Forms.Button();
            this.bProductos = new System.Windows.Forms.Button();
            this.bCrearProducto = new System.Windows.Forms.Button();
            this.bAtributos = new System.Windows.Forms.Button();
            this.bCategorias = new System.Windows.Forms.Button();
            this.bDashboard = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 362);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 19);
            this.button1.TabIndex = 31;
            this.button1.Text = "Ver Producto";
            this.button1.UseVisualStyleBackColor = true;
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
            // 
            // bCrearProducto
            // 
            this.bCrearProducto.Location = new System.Drawing.Point(728, 218);
            this.bCrearProducto.Margin = new System.Windows.Forms.Padding(2);
            this.bCrearProducto.Name = "bCrearProducto";
            this.bCrearProducto.Size = new System.Drawing.Size(191, 47);
            this.bCrearProducto.TabIndex = 29;
            this.bCrearProducto.Text = "Crear Producto";
            this.bCrearProducto.UseVisualStyleBackColor = true;
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(146, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(499, 150);
            this.dataGridView1.TabIndex = 25;
            // 
            // ListarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bProductos);
            this.Controls.Add(this.bCrearProducto);
            this.Controls.Add(this.bAtributos);
            this.Controls.Add(this.bCategorias);
            this.Controls.Add(this.bDashboard);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListarProducto";
            this.Text = "ListarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bProductos;
        private System.Windows.Forms.Button bCrearProducto;
        private System.Windows.Forms.Button bAtributos;
        private System.Windows.Forms.Button bCategorias;
        private System.Windows.Forms.Button bDashboard;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}