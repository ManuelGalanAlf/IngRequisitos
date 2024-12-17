namespace PIM
{
    partial class MostrarInformacionCuenta
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
            this.bRelaciones = new System.Windows.Forms.Button();
            this.bProductos = new System.Windows.Forms.Button();
            this.bCategorias = new System.Windows.Forms.Button();
            this.bDashboard = new System.Windows.Forms.Button();
            this.bExportar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEspacio = new System.Windows.Forms.TextBox();
            this.tbFechaCreacion = new System.Windows.Forms.TextBox();
            this.tbProductos = new System.Windows.Forms.TextBox();
            this.tbCategories = new System.Windows.Forms.TextBox();
            this.tbAttributes = new System.Windows.Forms.TextBox();
            this.tbRelations = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.ofdImagen = new System.Windows.Forms.OpenFileDialog();
            this.bCuenta = new System.Windows.Forms.Button();
            this.AddImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // bAtributos
            // 
            this.bAtributos.Location = new System.Drawing.Point(453, 23);
            this.bAtributos.Margin = new System.Windows.Forms.Padding(2);
            this.bAtributos.Name = "bAtributos";
            this.bAtributos.Size = new System.Drawing.Size(112, 47);
            this.bAtributos.TabIndex = 66;
            this.bAtributos.Text = "Attributes";
            this.bAtributos.UseVisualStyleBackColor = true;
            this.bAtributos.Click += new System.EventHandler(this.bAtributos_Click);
            // 
            // bRelaciones
            // 
            this.bRelaciones.Location = new System.Drawing.Point(578, 23);
            this.bRelaciones.Margin = new System.Windows.Forms.Padding(2);
            this.bRelaciones.Name = "bRelaciones";
            this.bRelaciones.Size = new System.Drawing.Size(112, 47);
            this.bRelaciones.TabIndex = 65;
            this.bRelaciones.Text = "Relations";
            this.bRelaciones.UseVisualStyleBackColor = true;
            this.bRelaciones.Click += new System.EventHandler(this.bRelaciones_Click);
            // 
            // bProductos
            // 
            this.bProductos.Location = new System.Drawing.Point(192, 23);
            this.bProductos.Margin = new System.Windows.Forms.Padding(2);
            this.bProductos.Name = "bProductos";
            this.bProductos.Size = new System.Drawing.Size(112, 47);
            this.bProductos.TabIndex = 64;
            this.bProductos.Text = "Products";
            this.bProductos.UseVisualStyleBackColor = true;
            this.bProductos.Click += new System.EventHandler(this.bProductos_Click);
            // 
            // bCategorias
            // 
            this.bCategorias.Location = new System.Drawing.Point(320, 23);
            this.bCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.bCategorias.Name = "bCategorias";
            this.bCategorias.Size = new System.Drawing.Size(112, 47);
            this.bCategorias.TabIndex = 63;
            this.bCategorias.Text = "Categories";
            this.bCategorias.UseVisualStyleBackColor = true;
            this.bCategorias.Click += new System.EventHandler(this.bCategorias_Click);
            // 
            // bDashboard
            // 
            this.bDashboard.Location = new System.Drawing.Point(67, 23);
            this.bDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.bDashboard.Name = "bDashboard";
            this.bDashboard.Size = new System.Drawing.Size(112, 47);
            this.bDashboard.TabIndex = 62;
            this.bDashboard.Text = "Dashboard";
            this.bDashboard.UseVisualStyleBackColor = true;
            this.bDashboard.Click += new System.EventHandler(this.bDashboard_Click);
            // 
            // bExportar
            // 
            this.bExportar.BackColor = System.Drawing.Color.Yellow;
            this.bExportar.ForeColor = System.Drawing.Color.Black;
            this.bExportar.Location = new System.Drawing.Point(754, 97);
            this.bExportar.Margin = new System.Windows.Forms.Padding(2);
            this.bExportar.Name = "bExportar";
            this.bExportar.Size = new System.Drawing.Size(128, 49);
            this.bExportar.TabIndex = 67;
            this.bExportar.Text = "Export to .JSON";
            this.bExportar.UseVisualStyleBackColor = false;
            this.bExportar.Click += new System.EventHandler(this.bExportar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 338);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Space left";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 237);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Date of creation";
            // 
            // tbEspacio
            // 
            this.tbEspacio.Location = new System.Drawing.Point(23, 368);
            this.tbEspacio.Margin = new System.Windows.Forms.Padding(2);
            this.tbEspacio.Name = "tbEspacio";
            this.tbEspacio.ReadOnly = true;
            this.tbEspacio.Size = new System.Drawing.Size(120, 20);
            this.tbEspacio.TabIndex = 72;
            // 
            // tbFechaCreacion
            // 
            this.tbFechaCreacion.Location = new System.Drawing.Point(23, 252);
            this.tbFechaCreacion.Margin = new System.Windows.Forms.Padding(2);
            this.tbFechaCreacion.Name = "tbFechaCreacion";
            this.tbFechaCreacion.ReadOnly = true;
            this.tbFechaCreacion.Size = new System.Drawing.Size(120, 20);
            this.tbFechaCreacion.TabIndex = 73;
            // 
            // tbProductos
            // 
            this.tbProductos.Location = new System.Drawing.Point(283, 204);
            this.tbProductos.Margin = new System.Windows.Forms.Padding(2);
            this.tbProductos.Name = "tbProductos";
            this.tbProductos.ReadOnly = true;
            this.tbProductos.Size = new System.Drawing.Size(120, 20);
            this.tbProductos.TabIndex = 74;
            // 
            // tbCategories
            // 
            this.tbCategories.Location = new System.Drawing.Point(535, 204);
            this.tbCategories.Margin = new System.Windows.Forms.Padding(2);
            this.tbCategories.Name = "tbCategories";
            this.tbCategories.ReadOnly = true;
            this.tbCategories.Size = new System.Drawing.Size(120, 20);
            this.tbCategories.TabIndex = 75;
            // 
            // tbAttributes
            // 
            this.tbAttributes.Location = new System.Drawing.Point(283, 328);
            this.tbAttributes.Margin = new System.Windows.Forms.Padding(2);
            this.tbAttributes.Name = "tbAttributes";
            this.tbAttributes.ReadOnly = true;
            this.tbAttributes.Size = new System.Drawing.Size(120, 20);
            this.tbAttributes.TabIndex = 76;
            // 
            // tbRelations
            // 
            this.tbRelations.Location = new System.Drawing.Point(541, 328);
            this.tbRelations.Margin = new System.Windows.Forms.Padding(2);
            this.tbRelations.Name = "tbRelations";
            this.tbRelations.ReadOnly = true;
            this.tbRelations.Size = new System.Drawing.Size(120, 20);
            this.tbRelations.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Number of Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "Number of Attributes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Number of Categories";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Number of Relations";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(283, 112);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ReadOnly = true;
            this.tbNombre.Size = new System.Drawing.Size(130, 20);
            this.tbNombre.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 83;
            this.label7.Text = "Account name";
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(24, 96);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(2);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(119, 125);
            this.pbImagen.TabIndex = 71;
            this.pbImagen.TabStop = false;
            // 
            // ofdImagen
            // 
            this.ofdImagen.FileName = "ofdImagen";
            // 
            // bCuenta
            // 
            this.bCuenta.Location = new System.Drawing.Point(754, 23);
            this.bCuenta.Margin = new System.Windows.Forms.Padding(2);
            this.bCuenta.Name = "bCuenta";
            this.bCuenta.Size = new System.Drawing.Size(112, 47);
            this.bCuenta.TabIndex = 85;
            this.bCuenta.Text = "Account";
            this.bCuenta.UseVisualStyleBackColor = true;
            this.bCuenta.Click += new System.EventHandler(this.bCuenta_Click);
            // 
            // AddImage
            // 
            this.AddImage.Location = new System.Drawing.Point(158, 137);
            this.AddImage.Name = "AddImage";
            this.AddImage.Size = new System.Drawing.Size(75, 23);
            this.AddImage.TabIndex = 86;
            this.AddImage.Text = "bAddImage";
            this.AddImage.UseVisualStyleBackColor = true;
            this.AddImage.Click += new System.EventHandler(this.AddImage_Click);
            // 
            // MostrarInformacionCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 634);
            this.Controls.Add(this.AddImage);
            this.Controls.Add(this.bCuenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRelations);
            this.Controls.Add(this.tbAttributes);
            this.Controls.Add(this.tbCategories);
            this.Controls.Add(this.tbProductos);
            this.Controls.Add(this.tbFechaCreacion);
            this.Controls.Add(this.tbEspacio);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bExportar);
            this.Controls.Add(this.bAtributos);
            this.Controls.Add(this.bRelaciones);
            this.Controls.Add(this.bProductos);
            this.Controls.Add(this.bCategorias);
            this.Controls.Add(this.bDashboard);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MostrarInformacionCuenta";
            this.Text = "MostrarInformacionCuenta";
            this.Load += new System.EventHandler(this.MostrarInformacionCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAtributos;
        private System.Windows.Forms.Button bRelaciones;
        private System.Windows.Forms.Button bProductos;
        private System.Windows.Forms.Button bCategorias;
        private System.Windows.Forms.Button bDashboard;
        private System.Windows.Forms.Button bExportar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEspacio;
        private System.Windows.Forms.TextBox tbFechaCreacion;
        private System.Windows.Forms.TextBox tbProductos;
        private System.Windows.Forms.TextBox tbCategories;
        private System.Windows.Forms.TextBox tbAttributes;
        private System.Windows.Forms.TextBox tbRelations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.OpenFileDialog ofdImagen;
        private System.Windows.Forms.Button bCuenta;
        private System.Windows.Forms.Button AddImage;
    }
}