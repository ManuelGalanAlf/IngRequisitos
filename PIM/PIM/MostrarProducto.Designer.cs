﻿namespace PIM
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
            this.bModificar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tSKU = new System.Windows.Forms.TextBox();
            this.tGtin = new System.Windows.Forms.TextBox();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCategorias = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bProductos = new System.Windows.Forms.Button();
            this.bCategorias = new System.Windows.Forms.Button();
            this.bDashboard = new System.Windows.Forms.Button();
            this.pbThumbnail = new System.Windows.Forms.PictureBox();
            this.bRelaciones = new System.Windows.Forms.Button();
            this.bAtributos = new System.Windows.Forms.Button();
            this.bCuenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // bModificar
            // 
            this.bModificar.BackColor = System.Drawing.Color.Yellow;
            this.bModificar.ForeColor = System.Drawing.Color.Black;
            this.bModificar.Location = new System.Drawing.Point(949, 537);
            this.bModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(171, 60);
            this.bModificar.TabIndex = 59;
            this.bModificar.Text = "Update";
            this.bModificar.UseVisualStyleBackColor = false;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bEliminar.ForeColor = System.Drawing.Color.White;
            this.bEliminar.Location = new System.Drawing.Point(1169, 537);
            this.bEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(171, 60);
            this.bEliminar.TabIndex = 58;
            this.bEliminar.Text = "Delete";
            this.bEliminar.UseVisualStyleBackColor = false;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(428, 201);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(389, 150);
            this.dataGridView1.TabIndex = 57;
            // 
            // tSKU
            // 
            this.tSKU.Location = new System.Drawing.Point(73, 476);
            this.tSKU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tSKU.Name = "tSKU";
            this.tSKU.ReadOnly = true;
            this.tSKU.Size = new System.Drawing.Size(164, 22);
            this.tSKU.TabIndex = 56;
            // 
            // tGtin
            // 
            this.tGtin.Location = new System.Drawing.Point(73, 402);
            this.tGtin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tGtin.Name = "tGtin";
            this.tGtin.ReadOnly = true;
            this.tGtin.Size = new System.Drawing.Size(164, 22);
            this.tGtin.TabIndex = 55;
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(60, 133);
            this.tNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tNombre.Name = "tNombre";
            this.tNombre.ReadOnly = true;
            this.tNombre.Size = new System.Drawing.Size(164, 22);
            this.tNombre.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "SKU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "GTIN";
            // 
            // lbCategorias
            // 
            this.lbCategorias.FormattingEnabled = true;
            this.lbCategorias.ItemHeight = 16;
            this.lbCategorias.Location = new System.Drawing.Point(428, 400);
            this.lbCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbCategorias.Name = "lbCategorias";
            this.lbCategorias.Size = new System.Drawing.Size(391, 84);
            this.lbCategorias.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Attributes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Categories";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Thumbnail";
            // 
            // bProductos
            // 
            this.bProductos.Location = new System.Drawing.Point(256, 32);
            this.bProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bProductos.Name = "bProductos";
            this.bProductos.Size = new System.Drawing.Size(149, 58);
            this.bProductos.TabIndex = 46;
            this.bProductos.Text = "Products";
            this.bProductos.UseVisualStyleBackColor = true;
            this.bProductos.Click += new System.EventHandler(this.bProductos_Click);
            // 
            // bCategorias
            // 
            this.bCategorias.Location = new System.Drawing.Point(427, 32);
            this.bCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCategorias.Name = "bCategorias";
            this.bCategorias.Size = new System.Drawing.Size(149, 58);
            this.bCategorias.TabIndex = 44;
            this.bCategorias.Text = "Categories";
            this.bCategorias.UseVisualStyleBackColor = true;
            this.bCategorias.Click += new System.EventHandler(this.bCategorias_Click);
            // 
            // bDashboard
            // 
            this.bDashboard.Location = new System.Drawing.Point(89, 32);
            this.bDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDashboard.Name = "bDashboard";
            this.bDashboard.Size = new System.Drawing.Size(149, 58);
            this.bDashboard.TabIndex = 43;
            this.bDashboard.Text = "Dashboard";
            this.bDashboard.UseVisualStyleBackColor = true;
            this.bDashboard.Click += new System.EventHandler(this.bDashboard_Click);
            // 
            // pbThumbnail
            // 
            this.pbThumbnail.Location = new System.Drawing.Point(56, 210);
            this.pbThumbnail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbThumbnail.Name = "pbThumbnail";
            this.pbThumbnail.Size = new System.Drawing.Size(168, 140);
            this.pbThumbnail.TabIndex = 42;
            this.pbThumbnail.TabStop = false;
            // 
            // bRelaciones
            // 
            this.bRelaciones.Location = new System.Drawing.Point(771, 32);
            this.bRelaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bRelaciones.Name = "bRelaciones";
            this.bRelaciones.Size = new System.Drawing.Size(149, 58);
            this.bRelaciones.TabIndex = 60;
            this.bRelaciones.Text = "Relations";
            this.bRelaciones.UseVisualStyleBackColor = true;
            this.bRelaciones.Click += new System.EventHandler(this.bRelaciones_Click);
            // 
            // bAtributos
            // 
            this.bAtributos.Location = new System.Drawing.Point(604, 32);
            this.bAtributos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAtributos.Name = "bAtributos";
            this.bAtributos.Size = new System.Drawing.Size(149, 58);
            this.bAtributos.TabIndex = 61;
            this.bAtributos.Text = "Attributes";
            this.bAtributos.UseVisualStyleBackColor = true;
            // 
            // bCuenta
            // 
            this.bCuenta.Location = new System.Drawing.Point(1119, 32);
            this.bCuenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCuenta.Name = "bCuenta";
            this.bCuenta.Size = new System.Drawing.Size(149, 58);
            this.bCuenta.TabIndex = 86;
            this.bCuenta.Text = "Account";
            this.bCuenta.UseVisualStyleBackColor = true;
            this.bCuenta.Click += new System.EventHandler(this.bCuenta_Click);
            // 
            // MostrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 633);
            this.Controls.Add(this.bCuenta);
            this.Controls.Add(this.bAtributos);
            this.Controls.Add(this.bRelaciones);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tSKU);
            this.Controls.Add(this.tGtin);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCategorias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bProductos);
            this.Controls.Add(this.bCategorias);
            this.Controls.Add(this.bDashboard);
            this.Controls.Add(this.pbThumbnail);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MostrarProducto";
            this.Text = "MostrarProducto";
            this.Load += new System.EventHandler(this.MostrarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tSKU;
        private System.Windows.Forms.TextBox tGtin;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbCategorias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bProductos;
        private System.Windows.Forms.Button bCategorias;
        private System.Windows.Forms.Button bDashboard;
        private System.Windows.Forms.PictureBox pbThumbnail;
        private System.Windows.Forms.Button bRelaciones;
        private System.Windows.Forms.Button bAtributos;
        private System.Windows.Forms.Button bCuenta;
    }
}