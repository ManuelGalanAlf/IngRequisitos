namespace PIM
{
    partial class CrearAtributo
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
            this.cbTipoAtributo = new System.Windows.Forms.ComboBox();
            this.bAtributos = new System.Windows.Forms.Button();
            this.bCategorias = new System.Windows.Forms.Button();
            this.bProductos = new System.Windows.Forms.Button();
            this.bDashboard = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.Tipo = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lSku = new System.Windows.Forms.Label();
            this.bRelaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbTipoAtributo
            // 
            this.cbTipoAtributo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoAtributo.FormattingEnabled = true;
            this.cbTipoAtributo.Location = new System.Drawing.Point(466, 160);
            this.cbTipoAtributo.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoAtributo.Name = "cbTipoAtributo";
            this.cbTipoAtributo.Size = new System.Drawing.Size(164, 21);
            this.cbTipoAtributo.TabIndex = 32;
            // 
            // bAtributos
            // 
            this.bAtributos.Location = new System.Drawing.Point(431, 29);
            this.bAtributos.Margin = new System.Windows.Forms.Padding(2);
            this.bAtributos.Name = "bAtributos";
            this.bAtributos.Size = new System.Drawing.Size(112, 47);
            this.bAtributos.TabIndex = 31;
            this.bAtributos.Text = "Atributos";
            this.bAtributos.UseVisualStyleBackColor = true;
            this.bAtributos.Click += new System.EventHandler(this.bAtributos_Click);
            // 
            // bCategorias
            // 
            this.bCategorias.Location = new System.Drawing.Point(302, 29);
            this.bCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.bCategorias.Name = "bCategorias";
            this.bCategorias.Size = new System.Drawing.Size(112, 47);
            this.bCategorias.TabIndex = 30;
            this.bCategorias.Text = "Categorias";
            this.bCategorias.UseVisualStyleBackColor = true;
            this.bCategorias.Click += new System.EventHandler(this.bCategorias_Click);
            // 
            // bProductos
            // 
            this.bProductos.Location = new System.Drawing.Point(172, 29);
            this.bProductos.Margin = new System.Windows.Forms.Padding(2);
            this.bProductos.Name = "bProductos";
            this.bProductos.Size = new System.Drawing.Size(112, 47);
            this.bProductos.TabIndex = 29;
            this.bProductos.Text = "Productos";
            this.bProductos.UseVisualStyleBackColor = true;
            this.bProductos.Click += new System.EventHandler(this.bProductos_Click);
            // 
            // bDashboard
            // 
            this.bDashboard.Location = new System.Drawing.Point(49, 29);
            this.bDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.bDashboard.Name = "bDashboard";
            this.bDashboard.Size = new System.Drawing.Size(112, 47);
            this.bDashboard.TabIndex = 28;
            this.bDashboard.Text = "Dashboard";
            this.bDashboard.UseVisualStyleBackColor = true;
            this.bDashboard.Click += new System.EventHandler(this.bDashboard_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.Red;
            this.bCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bCancelar.Location = new System.Drawing.Point(885, 437);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(113, 48);
            this.bCancelar.TabIndex = 27;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bConfirmar
            // 
            this.bConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bConfirmar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bConfirmar.Location = new System.Drawing.Point(759, 437);
            this.bConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(113, 48);
            this.bConfirmar.TabIndex = 26;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = false;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipo.Location = new System.Drawing.Point(463, 125);
            this.Tipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(37, 19);
            this.Tipo.TabIndex = 25;
            this.Tipo.Text = "Tipo";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(49, 161);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(299, 20);
            this.tbNombre.TabIndex = 24;
            // 
            // lSku
            // 
            this.lSku.AutoSize = true;
            this.lSku.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSku.Location = new System.Drawing.Point(46, 125);
            this.lSku.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lSku.Name = "lSku";
            this.lSku.Size = new System.Drawing.Size(60, 19);
            this.lSku.TabIndex = 23;
            this.lSku.Text = "Nombre";
            // 
            // bRelaciones
            // 
            this.bRelaciones.Location = new System.Drawing.Point(564, 29);
            this.bRelaciones.Margin = new System.Windows.Forms.Padding(2);
            this.bRelaciones.Name = "bRelaciones";
            this.bRelaciones.Size = new System.Drawing.Size(112, 47);
            this.bRelaciones.TabIndex = 49;
            this.bRelaciones.Text = "Relaciones";
            this.bRelaciones.UseVisualStyleBackColor = true;
            this.bRelaciones.Click += new System.EventHandler(this.bRelaciones_Click);
            // 
            // CrearAtributo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 514);
            this.Controls.Add(this.bRelaciones);
            this.Controls.Add(this.cbTipoAtributo);
            this.Controls.Add(this.bAtributos);
            this.Controls.Add(this.bCategorias);
            this.Controls.Add(this.bProductos);
            this.Controls.Add(this.bDashboard);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lSku);
            this.Name = "CrearAtributo";
            this.Text = "CrearAtributo";
            this.Load += new System.EventHandler(this.CrearAtributo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipoAtributo;
        private System.Windows.Forms.Button bAtributos;
        private System.Windows.Forms.Button bCategorias;
        private System.Windows.Forms.Button bProductos;
        private System.Windows.Forms.Button bDashboard;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bConfirmar;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lSku;
        private System.Windows.Forms.Button bRelaciones;
    }
}