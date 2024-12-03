namespace PIM
{
    partial class CrearProducto
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lSku = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lGtin = new System.Windows.Forms.Label();
            this.lThumbnai = new System.Windows.Forms.Label();
            this.tbSku = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbGtin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clbCategorias = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bDashboard = new System.Windows.Forms.Button();
            this.bProductos = new System.Windows.Forms.Button();
            this.bCategorias = new System.Windows.Forms.Button();
            this.bAtributos = new System.Windows.Forms.Button();
            this.tbAtributo = new System.Windows.Forms.TextBox();
            this.ofdThumbnail = new System.Windows.Forms.OpenFileDialog();
            this.pbThumbnail = new System.Windows.Forms.PictureBox();
            this.bThumbnail = new System.Windows.Forms.Button();
            this.lbAtributo = new System.Windows.Forms.Label();
            this.bAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // lSku
            // 
            this.lSku.AutoSize = true;
            this.lSku.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSku.Location = new System.Drawing.Point(43, 127);
            this.lSku.Name = "lSku";
            this.lSku.Size = new System.Drawing.Size(148, 24);
            this.lSku.TabIndex = 0;
            this.lSku.Text = "SKU(Obligatorio)";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(43, 225);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(184, 24);
            this.lNombre.TabIndex = 1;
            this.lNombre.Text = "Nombre(Obligatorio)";
            // 
            // lGtin
            // 
            this.lGtin.AutoSize = true;
            this.lGtin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGtin.Location = new System.Drawing.Point(43, 320);
            this.lGtin.Name = "lGtin";
            this.lGtin.Size = new System.Drawing.Size(157, 24);
            this.lGtin.TabIndex = 2;
            this.lGtin.Text = "GTIN(Obligatorio)";
            // 
            // lThumbnai
            // 
            this.lThumbnai.AutoSize = true;
            this.lThumbnai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lThumbnai.Location = new System.Drawing.Point(31, 441);
            this.lThumbnai.Name = "lThumbnai";
            this.lThumbnai.Size = new System.Drawing.Size(206, 24);
            this.lThumbnai.TabIndex = 3;
            this.lThumbnai.Text = "Thumbnail(Obligatorio)";
            // 
            // tbSku
            // 
            this.tbSku.Location = new System.Drawing.Point(35, 164);
            this.tbSku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSku.Name = "tbSku";
            this.tbSku.Size = new System.Drawing.Size(397, 22);
            this.tbSku.TabIndex = 4;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(35, 261);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(397, 22);
            this.tbNombre.TabIndex = 5;
            // 
            // tbGtin
            // 
            this.tbGtin.Location = new System.Drawing.Point(35, 375);
            this.tbGtin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGtin.Name = "tbGtin";
            this.tbGtin.Size = new System.Drawing.Size(397, 22);
            this.tbGtin.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(519, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seleccione tipo de atributo (opcional)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1012, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Añada categorías al producto";
            // 
            // clbCategorias
            // 
            this.clbCategorias.FormattingEnabled = true;
            this.clbCategorias.Location = new System.Drawing.Point(983, 177);
            this.clbCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clbCategorias.Name = "clbCategorias";
            this.clbCategorias.Size = new System.Drawing.Size(319, 174);
            this.clbCategorias.TabIndex = 10;
            this.clbCategorias.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbCategorias_ItemCheck);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(489, 164);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(435, 210);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // bConfirmar
            // 
            this.bConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bConfirmar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bConfirmar.Location = new System.Drawing.Point(1016, 562);
            this.bConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(151, 59);
            this.bConfirmar.TabIndex = 12;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = false;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.Red;
            this.bCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bCancelar.Location = new System.Drawing.Point(1184, 562);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(151, 59);
            this.bCancelar.TabIndex = 13;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bDashboard
            // 
            this.bDashboard.Location = new System.Drawing.Point(40, 20);
            this.bDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDashboard.Name = "bDashboard";
            this.bDashboard.Size = new System.Drawing.Size(149, 58);
            this.bDashboard.TabIndex = 14;
            this.bDashboard.Text = "Dashboard";
            this.bDashboard.UseVisualStyleBackColor = true;
            this.bDashboard.Click += new System.EventHandler(this.bDashboard_Click_1);
            // 
            // bProductos
            // 
            this.bProductos.Location = new System.Drawing.Point(204, 20);
            this.bProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bProductos.Name = "bProductos";
            this.bProductos.Size = new System.Drawing.Size(149, 58);
            this.bProductos.TabIndex = 15;
            this.bProductos.Text = "Productos";
            this.bProductos.UseVisualStyleBackColor = true;
            this.bProductos.Click += new System.EventHandler(this.bProductos_Click);
            // 
            // bCategorias
            // 
            this.bCategorias.Location = new System.Drawing.Point(377, 20);
            this.bCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCategorias.Name = "bCategorias";
            this.bCategorias.Size = new System.Drawing.Size(149, 58);
            this.bCategorias.TabIndex = 16;
            this.bCategorias.Text = "Categorias";
            this.bCategorias.UseVisualStyleBackColor = true;
            // 
            // bAtributos
            // 
            this.bAtributos.Location = new System.Drawing.Point(556, 20);
            this.bAtributos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAtributos.Name = "bAtributos";
            this.bAtributos.Size = new System.Drawing.Size(149, 58);
            this.bAtributos.TabIndex = 17;
            this.bAtributos.Text = "Atributos";
            this.bAtributos.UseVisualStyleBackColor = true;
            // 
            // tbAtributo
            // 
            this.tbAtributo.Location = new System.Drawing.Point(523, 480);
            this.tbAtributo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAtributo.Name = "tbAtributo";
            this.tbAtributo.Size = new System.Drawing.Size(101, 22);
            this.tbAtributo.TabIndex = 18;
            // 
            // ofdThumbnail
            // 
            this.ofdThumbnail.FileName = "openFileDialog1";
            // 
            // pbThumbnail
            // 
            this.pbThumbnail.Location = new System.Drawing.Point(40, 480);
            this.pbThumbnail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbThumbnail.Name = "pbThumbnail";
            this.pbThumbnail.Size = new System.Drawing.Size(133, 105);
            this.pbThumbnail.TabIndex = 24;
            this.pbThumbnail.TabStop = false;
            // 
            // bThumbnail
            // 
            this.bThumbnail.Location = new System.Drawing.Point(227, 505);
            this.bThumbnail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bThumbnail.Name = "bThumbnail";
            this.bThumbnail.Size = new System.Drawing.Size(115, 57);
            this.bThumbnail.TabIndex = 25;
            this.bThumbnail.Text = "Añadir thumbnail";
            this.bThumbnail.UseVisualStyleBackColor = true;
            this.bThumbnail.Click += new System.EventHandler(this.bThumbnail_Click);
            // 
            // lbAtributo
            // 
            this.lbAtributo.AutoSize = true;
            this.lbAtributo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAtributo.Location = new System.Drawing.Point(519, 443);
            this.lbAtributo.Name = "lbAtributo";
            this.lbAtributo.Size = new System.Drawing.Size(255, 24);
            this.lbAtributo.TabIndex = 22;
            this.lbAtributo.Text = "Inserte atributo seleccionado";
            // 
            // bAgregar
            // 
            this.bAgregar.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.Location = new System.Drawing.Point(676, 480);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(75, 23);
            this.bAgregar.TabIndex = 26;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // CrearProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 633);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.bThumbnail);
            this.Controls.Add(this.pbThumbnail);
            this.Controls.Add(this.lbAtributo);
            this.Controls.Add(this.tbAtributo);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CrearProducto";
            this.Text = "Crear Producto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lSku;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lGtin;
        private System.Windows.Forms.Label lThumbnai;
        private System.Windows.Forms.TextBox tbSku;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbGtin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clbCategorias;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bConfirmar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bDashboard;
        private System.Windows.Forms.Button bProductos;
        private System.Windows.Forms.Button bCategorias;
        private System.Windows.Forms.Button bAtributos;
        private System.Windows.Forms.TextBox tbAtributo;
        private System.Windows.Forms.OpenFileDialog ofdThumbnail;
        private System.Windows.Forms.PictureBox pbThumbnail;
        private System.Windows.Forms.Button bThumbnail;
        private System.Windows.Forms.Label lbAtributo;
        private System.Windows.Forms.Button bAgregar;
    }
}

