using System;
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
    public partial class CrearCategoria : Form
    {
        TiendaEntities1 bd = new TiendaEntities1();

        public CrearCategoria()
        {
            InitializeComponent();
        }

        private void CrearCategoria_Load(object sender, EventArgs e)
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

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            string nuevoNombre = tbNombre.Text;

            // Verificar si el nombre no está vacío
            if (string.IsNullOrEmpty(nuevoNombre))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si el nombre de la categoría ya existe
            var categoriaExistente = bd.Categoria.FirstOrDefault(c => c.Nombre == nuevoNombre);
            if (categoriaExistente != null)
            {
                MessageBox.Show("Ya existe una categoría con este nombre. Elija otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear una nueva categoría con número de productos igual a 0
            Categoria nuevaCategoria = new Categoria
            {
                Nombre = nuevoNombre,
                NumeroProductos = 0 // Establecer el número de productos a 0
            };

            // Agregar la nueva categoría a la base de datos
            bd.Categoria.Add(nuevaCategoria);
            bd.SaveChanges();

            // Mostrar mensaje de confirmación
            MessageBox.Show("Categoría creada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ListarCategoria listarCategoria = new ListarCategoria();
            listarCategoria.Show();
            this.Hide();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            ListarCategoria listarCategoria = new ListarCategoria();
            listarCategoria.Show();
            this.Hide();
        }

       
    }
}
