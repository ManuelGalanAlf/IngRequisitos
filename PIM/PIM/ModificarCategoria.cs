using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace PIM
{
    public partial class ModificarCategoria : Form
    {
        TiendaEntities1 bd = new TiendaEntities1();
        Categoria categoria;
        public ModificarCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
        }

        private void ModificarCategoria_Load(object sender, EventArgs e)
        {
            tbNombre.Text = categoria.Nombre;
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

        private void bConfirmar_Click(object sender, EventArgs e)
        {

            try
            {
                bd.Entry(categoria).State = EntityState.Detached;
                var categoriaSeleccionado = bd.Categoria.FirstOrDefault(c => c.Nombre == categoria.Nombre);

                string nuevoNombre = tbNombre.Text;
                // Verificar si el nombre no está vacío
                if (string.IsNullOrEmpty(nuevoNombre))
                {
                    MessageBox.Show("Por favor ingrese un nombre para la categoria.");
                    return;
                }

                // Actualizar el nombre del atributo
                categoriaSeleccionado.Nombre = nuevoNombre;

                bd.SaveChanges();

                MessageBox.Show("Categoria actualizada exitosamente.");
                ListarCategoria listarCategoria = new ListarCategoria();
                listarCategoria.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar la categoria: " + ex.Message);
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            ListarCategoria listarCategoria = new ListarCategoria();
            listarCategoria.Show();
            this.Hide();
        }

        private void bRelaciones_Click(object sender, EventArgs e)
        {
            ListarRelacion listarRelacion = new ListarRelacion();
            listarRelacion.Show();
            this.Hide();
        }


    }
}
