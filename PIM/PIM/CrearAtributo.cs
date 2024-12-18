﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM
{
    public partial class CrearAtributo : Form
    {
        public enum TipoAtributo
        {
            Entero,
            Real,
            Cadena
        }

        TiendaEntities1 bd = new TiendaEntities1();

        public CrearAtributo()
        {
            InitializeComponent();
            cbTipoAtributo.DataSource = Enum.GetValues(typeof(TipoAtributo));
        }

        private void CrearAtributo_Load(object sender, EventArgs e)
        {

        }

        private void bDashboard_Click(object sender, EventArgs e)
        {
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
            pantallaPrincipal.Show();
            this.Hide();
        }

        private void bProductos_Click(object sender, EventArgs e)
        {
            ListarProducto listarProductos = new ListarProducto();
            listarProductos.Show();
            this.Hide();
        }

        private void bCategorias_Click(object sender, EventArgs e)
        {
            ListarCategoria listarCategoria = new ListarCategoria();
            listarCategoria.Show();
            this.Hide();
        }

        private void bAtributos_Click(object sender, EventArgs e)
        {
            ListarAtributo listarAtributo = new ListarAtributo();
            listarAtributo.Show();
            this.Hide();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            ListarAtributo listarAtributo = new ListarAtributo();
            listarAtributo.Show();
            this.Hide();
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            if (bd.Atributo.Count() >= 5) {
                MessageBox.Show("Exceeded attribute limit (5)");
                return;
            }
            
            string nombre = tbNombre.Text;
            string tipoString = cbTipoAtributo.SelectedItem.ToString();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Enter a name to create product.");
                return;
            }

            Atributo nuevoAtributo = new Atributo
            {
                Nombre = nombre,
                Tipo = tipoString
            };

            try
            {
                // Añadir el nuevo atributo al contexto de la base de datos
                bd.Atributo.Add(nuevoAtributo);

                // Guardar los cambios en la base de datos
                bd.SaveChanges();

                MessageBox.Show("Attribute created successfully.");

                // Opcional: Navegar a la pantalla que lista los atributos
                ListarAtributo listarAtributo = new ListarAtributo();
                listarAtributo.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the attribute:" + ex.Message);
            }
            
        }

        private void bRelaciones_Click(object sender, EventArgs e)
        {
            ListarRelacion listarRelacion = new ListarRelacion();
            listarRelacion.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bCuenta_Click(object sender, EventArgs e)
        {
            MostrarInformacionCuenta m = new MostrarInformacionCuenta();
            m.Show();
            this.Hide();
        }

    }
}
