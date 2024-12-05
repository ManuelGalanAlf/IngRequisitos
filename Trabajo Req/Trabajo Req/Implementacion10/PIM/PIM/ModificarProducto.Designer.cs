namespace PIM
{
    partial class ModificarProducto
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
            this.bThumbnail = new System.Windows.Forms.Button();
            this.pbThumbnail = new System.Windows.Forms.PictureBox();
            this.bAtributos = new System.Windows.Forms.Button();
            this.bCategorias = new System.Windows.Forms.Button();
            this.bProductos = new System.Windows.Forms.Button();
            this.bDashboard = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clbCategorias = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGtin = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbSku = new System.Windows.Forms.TextBox();
            this.lThumbnai = new System.Windows.Forms.Label();
            this.lGtin = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lSku = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bThumbnail
            // 
            this.bThumbnail.Location = new System.Drawing.Point(148, 396);
            this.bThumbnail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bThumbnail.Name = "bThumbnail";
            this.bThumbnail.Size = new System.Drawing.Size(86, 46);
            this.bThumbnail.TabIndex = 47;
            this.bThumbnail.Text = "Añadir thumbnail";
            this.bThumbnail.UseVisualStyleBackColor = true;
            // 
            // pbThumbnail
            // 
            this.pbThumbnail.Location = new System.Drawing.Point(9, 376);
            this.pbThumbnail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbThumbnail.Name = "pbThumbnail";
            this.pbThumbnail.Size = new System.Drawing.Size(100, 85);
            this.pbThumbnail.TabIndex = 46;
            this.pbThumbnail.TabStop = false;
            // 
            // bAtributos
            // 
            this.bAtributos.Location = new System.Drawing.Point(396, 2);
            this.bAtributos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bAtributos.Name = "bAtributos";
            this.bAtributos.Size = new System.Drawing.Size(112, 47);
            this.bAtributos.TabIndex = 43;
            this.bAtributos.Text = "Atributos";
            this.bAtributos.UseVisualStyleBackColor = true;
            this.bAtributos.Click += new System.EventHandler(this.bAtributos_Click);
            // 
            // bCategorias
            // 
            this.bCategorias.Location = new System.Drawing.Point(262, 2);
            this.bCategorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bCategorias.Name = "bCategorias";
            this.bCategorias.Size = new System.Drawing.Size(112, 47);
            this.bCategorias.TabIndex = 42;
            this.bCategorias.Text = "Categorias";
            this.bCategorias.UseVisualStyleBackColor = true;
            this.bCategorias.Click += new System.EventHandler(this.bCategorias_Click);
            // 
            // bProductos
            // 
            this.bProductos.Location = new System.Drawing.Point(132, 2);
            this.bProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bProductos.Name = "bProductos";
            this.bProductos.Size = new System.Drawing.Size(112, 47);
            this.bProductos.TabIndex = 41;
            this.bProductos.Text = "Productos";
            this.bProductos.UseVisualStyleBackColor = true;
            this.bProductos.Click += new System.EventHandler(this.bProductos_Click);
            // 
            // bDashboard
            // 
            this.bDashboard.Location = new System.Drawing.Point(9, 2);
            this.bDashboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bDashboard.Name = "bDashboard";
            this.bDashboard.Size = new System.Drawing.Size(112, 47);
            this.bDashboard.TabIndex = 40;
            this.bDashboard.Text = "Dashboard";
            this.bDashboard.UseVisualStyleBackColor = true;
            this.bDashboard.Click += new System.EventHandler(this.bDashboard_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.Red;
            this.bCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bCancelar.Location = new System.Drawing.Point(867, 443);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(113, 48);
            this.bCancelar.TabIndex = 39;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bConfirmar
            // 
            this.bConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bConfirmar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bConfirmar.Location = new System.Drawing.Point(741, 443);
            this.bConfirmar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(113, 48);
            this.bConfirmar.TabIndex = 38;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = false;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(346, 119);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(326, 171);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // clbCategorias
            // 
            this.clbCategorias.FormattingEnabled = true;
            this.clbCategorias.Location = new System.Drawing.Point(716, 130);
            this.clbCategorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clbCategorias.Name = "clbCategorias";
            this.clbCategorias.Size = new System.Drawing.Size(240, 154);
            this.clbCategorias.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(738, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Categorías del producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Seleccione el atributo a modificar";
            // 
            // tbGtin
            // 
            this.tbGtin.Location = new System.Drawing.Point(5, 291);
            this.tbGtin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGtin.Name = "tbGtin";
            this.tbGtin.Size = new System.Drawing.Size(299, 20);
            this.tbGtin.TabIndex = 33;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(5, 198);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(299, 20);
            this.tbNombre.TabIndex = 32;
            // 
            // tbSku
            // 
            this.tbSku.Location = new System.Drawing.Point(5, 119);
            this.tbSku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSku.Name = "tbSku";
            this.tbSku.Size = new System.Drawing.Size(299, 20);
            this.tbSku.TabIndex = 31;
            // 
            // lThumbnai
            // 
            this.lThumbnai.AutoSize = true;
            this.lThumbnai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lThumbnai.Location = new System.Drawing.Point(2, 344);
            this.lThumbnai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lThumbnai.Name = "lThumbnai";
            this.lThumbnai.Size = new System.Drawing.Size(160, 19);
            this.lThumbnai.TabIndex = 30;
            this.lThumbnai.Text = "Thumbnail(Obligatorio)";
            // 
            // lGtin
            // 
            this.lGtin.AutoSize = true;
            this.lGtin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGtin.Location = new System.Drawing.Point(10, 246);
            this.lGtin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lGtin.Name = "lGtin";
            this.lGtin.Size = new System.Drawing.Size(41, 19);
            this.lGtin.TabIndex = 29;
            this.lGtin.Text = "GTIN";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(10, 169);
            this.lNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(60, 19);
            this.lNombre.TabIndex = 28;
            this.lNombre.Text = "Nombre";
            // 
            // lSku
            // 
            this.lSku.AutoSize = true;
            this.lSku.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSku.Location = new System.Drawing.Point(10, 89);
            this.lSku.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lSku.Name = "lSku";
            this.lSku.Size = new System.Drawing.Size(34, 19);
            this.lSku.TabIndex = 27;
            this.lSku.Text = "SKU";
            // 
            // ModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 514);
            this.Controls.Add(this.bThumbnail);
            this.Controls.Add(this.pbThumbnail);
            this.Controls.Add(this.bAtributos);
            this.Controls.Add(this.bCategorias);
            this.Controls.Add(this.bProductos);
            this.Controls.Add(this.bDashboard);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clbCategorias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGtin);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbSku);
            this.Controls.Add(this.lThumbnai);
            this.Controls.Add(this.lGtin);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.lSku);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModificarProducto";
            this.Text = "ModificarProducto";
            this.Load += new System.EventHandler(this.ModificarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bThumbnail;
        private System.Windows.Forms.PictureBox pbThumbnail;
        private System.Windows.Forms.Button bAtributos;
        private System.Windows.Forms.Button bCategorias;
        private System.Windows.Forms.Button bProductos;
        private System.Windows.Forms.Button bDashboard;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bConfirmar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckedListBox clbCategorias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGtin;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbSku;
        private System.Windows.Forms.Label lThumbnai;
        private System.Windows.Forms.Label lGtin;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lSku;
    }
}