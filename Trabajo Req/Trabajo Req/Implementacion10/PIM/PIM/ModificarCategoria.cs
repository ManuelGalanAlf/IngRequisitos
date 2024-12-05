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
    public partial class ModificarCategoria : Form
    {
        private Categoria c;
        public ModificarCategoria(Categoria c)
        {
            InitializeComponent();
            this.c = c;
            tbNombre.Text = c.Nombre;
        }
        private void bDashboard_Click(object sender, EventArgs e)
        {
            PantallaPrincipal principal = new PantallaPrincipal();
            principal.Show();
            this.Hide();
        }

        private void bProductos_Click(object sender, EventArgs e)
        {
            ListarProducto l = new ListarProducto();
            l.Show();
            this.Hide();
        }

        private void bCategorias_Click(object sender, EventArgs e)
        {
            ListarCategoria l  = new ListarCategoria();
            l.Show();
            this.Hide();
        }

        private void bAtributos_Click(object sender, EventArgs e)
        {
            ListarAtributo l = new ListarAtributo();
            l.Show();
            this.Hide(); 
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el nombre no esté vacío
                if (string.IsNullOrWhiteSpace(tbNombre.Text))
                {
                    MessageBox.Show("El nombre de la categoria no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar si el nombre de la categoría ya existe y no es el mismo que el original
                if (ExisteCategoriaConNombre(tbNombre.Text) && tbNombre.Text != c.Nombre)
                {
                    MessageBox.Show("Ya existe una categoria con el nombre " + tbNombre.Text + ". Por favor, elija otro nombre.", "Nombre duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Actualizar la categoría en la base de datos
                string consultaCategoria = "UPDATE Categoria SET nombre = '" + tbNombre.Text + "' WHERE nombre = '" + c.Nombre + "';";
                Consulta consulta = new Consulta();
                consulta.Update(consultaCategoria);

                // También debemos actualizar las filas de ProductoCategoria que referencian a esta categoría
                string consultaProductoCategoria = "UPDATE ProductoCategoria SET categoria_nombre = '" + tbNombre.Text + "' WHERE categoria_nombre = '" + c.Nombre + "';";
                consulta.Update(consultaProductoCategoria);

                // Actualizar el objeto en memoria
                c.Nombre = tbNombre.Text;

                // Volver a la lista de categorías
                ListarCategoria l = new ListarCategoria();
                l.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListarCategoria l = new ListarCategoria();
            l.Show();
        }

        private bool ExisteCategoriaConNombre(string nombre)
        {
            // Consulta para verificar si el nombre ya existe en la base de datos
            Consulta c = new Consulta();
            string consulta = "SELECT COUNT(*) FROM Categoria WHERE nombre = '" + nombre + "';";
            object resultado = c.Select(consulta)[0][0];

            // Convertir el resultado a entero y verificar si es mayor a 0
            return Convert.ToInt32(resultado) > 0;
        }

        private void ModificarCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
