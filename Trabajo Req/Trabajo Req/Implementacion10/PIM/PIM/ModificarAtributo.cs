using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM
{
    public partial class ModificarAtributo : Form
    {
        private Atributo atributo;

        public ModificarAtributo(Atributo atributo)
        {
            InitializeComponent();
            this.atributo = atributo;
        }

        private void ModificarAtributo_Load(object sender, EventArgs e)
        {
            tbNombre.Text = atributo.Nombre;
            cbTipoAtributo.DataSource = Enum.GetValues(typeof(TipoAtributo));
            cbTipoAtributo.SelectedItem = atributo.Tipo;
            cbTipoAtributo.Enabled = false; // Bloquear edición del ComboBox        
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
            try
            {
                // Obtener el nuevo nombre del TextBox
                string nuevoNombre = tbNombre.Text.Trim();

                // Validar que el nombre no esté vacío
                if (string.IsNullOrWhiteSpace(nuevoNombre))
                {
                    MessageBox.Show("El nombre del atributo no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar si el nombre ya existe
                if (ExisteAtributoConNombre(nuevoNombre) && nuevoNombre != atributo.Nombre)
                {
                    MessageBox.Show("Ya existe un atributo con el nombre " + nuevoNombre + ". Por favor, elija otro nombre.", "Nombre duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Actualizar el nombre del atributo
                atributo.Nombre = nuevoNombre;

                // Mostrar mensaje de éxito
                MessageBox.Show("Nombre del atributo modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarAtributo listarAtributo = new ListarAtributo();
                listarAtributo.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el nombre del atributo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ExisteAtributoConNombre(string nombre)
        {
            // Consulta para verificar si el nombre ya existe en la base de datos
            Consulta c = new Consulta();
            string consulta = "SELECT COUNT(*) FROM Atributo WHERE nombre = '" + nombre + "';";
            object resultado = c.Select(consulta)[0][0];

            // Convertir el resultado a entero y verificar si es mayor a 0
            return Convert.ToInt32(resultado) > 0;
        }
    }
}