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
            this.bCuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbTipoAtributo
            // 
            this.cbTipoAtributo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoAtributo.FormattingEnabled = true;
            this.cbTipoAtributo.Location = new System.Drawing.Point(621, 197);
            this.cbTipoAtributo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTipoAtributo.Name = "cbTipoAtributo";
            this.cbTipoAtributo.Size = new System.Drawing.Size(217, 24);
            this.cbTipoAtributo.TabIndex = 32;
            // 
            // bAtributos
            // 
            this.bAtributos.Location = new System.Drawing.Point(575, 36);
            this.bAtributos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAtributos.Name = "bAtributos";
            this.bAtributos.Size = new System.Drawing.Size(149, 58);
            this.bAtributos.TabIndex = 31;
            this.bAtributos.Text = "Attributes";
            this.bAtributos.UseVisualStyleBackColor = true;
            this.bAtributos.Click += new System.EventHandler(this.bAtributos_Click);
            // 
            // bCategorias
            // 
            this.bCategorias.Location = new System.Drawing.Point(403, 36);
            this.bCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCategorias.Name = "bCategorias";
            this.bCategorias.Size = new System.Drawing.Size(149, 58);
            this.bCategorias.TabIndex = 30;
            this.bCategorias.Text = "Categories";
            this.bCategorias.UseVisualStyleBackColor = true;
            this.bCategorias.Click += new System.EventHandler(this.bCategorias_Click);
            // 
            // bProductos
            // 
            this.bProductos.Location = new System.Drawing.Point(229, 36);
            this.bProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bProductos.Name = "bProductos";
            this.bProductos.Size = new System.Drawing.Size(149, 58);
            this.bProductos.TabIndex = 29;
            this.bProductos.Text = "Products";
            this.bProductos.UseVisualStyleBackColor = true;
            this.bProductos.Click += new System.EventHandler(this.bProductos_Click);
            // 
            // bDashboard
            // 
            this.bDashboard.Location = new System.Drawing.Point(65, 36);
            this.bDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDashboard.Name = "bDashboard";
            this.bDashboard.Size = new System.Drawing.Size(149, 58);
            this.bDashboard.TabIndex = 28;
            this.bDashboard.Text = "Dashboard";
            this.bDashboard.UseVisualStyleBackColor = true;
            this.bDashboard.Click += new System.EventHandler(this.bDashboard_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.Red;
            this.bCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bCancelar.Location = new System.Drawing.Point(1180, 538);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(151, 59);
            this.bCancelar.TabIndex = 27;
            this.bCancelar.Text = "Cancel";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bConfirmar
            // 
            this.bConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bConfirmar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bConfirmar.Location = new System.Drawing.Point(1012, 538);
            this.bConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(151, 59);
            this.bConfirmar.TabIndex = 26;
            this.bConfirmar.Text = "Confirm";
            this.bConfirmar.UseVisualStyleBackColor = false;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipo.Location = new System.Drawing.Point(617, 154);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(49, 24);
            this.Tipo.TabIndex = 25;
            this.Tipo.Text = "Type";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(65, 198);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(397, 22);
            this.tbNombre.TabIndex = 24;
            // 
            // lSku
            // 
            this.lSku.AutoSize = true;
            this.lSku.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSku.Location = new System.Drawing.Point(61, 154);
            this.lSku.Name = "lSku";
            this.lSku.Size = new System.Drawing.Size(59, 24);
            this.lSku.TabIndex = 23;
            this.lSku.Text = "Name";
            // 
            // bRelaciones
            // 
            this.bRelaciones.Location = new System.Drawing.Point(752, 36);
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
            this.bCuenta.Location = new System.Drawing.Point(1058, 36);
            this.bCuenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCuenta.Name = "bCuenta";
            this.bCuenta.Size = new System.Drawing.Size(149, 58);
            this.bCuenta.TabIndex = 86;
            this.bCuenta.Text = "Account";
            this.bCuenta.UseVisualStyleBackColor = true;
            this.bCuenta.Click += new System.EventHandler(this.bCuenta_Click);
            // 
            // CrearAtributo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 633);
            this.Controls.Add(this.bCuenta);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button bCuenta;
    }
}