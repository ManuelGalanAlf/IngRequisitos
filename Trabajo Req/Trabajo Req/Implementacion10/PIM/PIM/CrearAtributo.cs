using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM
{
    public partial class CrearAtributo : Form
    {
        public CrearAtributo()
        {
            InitializeComponent();
        }

        private void CrearAtributo_Load(object sender, EventArgs e)
        {
            // Poblar el ComboBox con los valores del enum TipoAtributo
            cbTipoAtributo.DataSource = Enum.GetValues(typeof(TipoAtributo));
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

        private void cbTipoAtributo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Acción opcional si se quiere manejar el cambio de selección
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = tbNombre.Text.Trim();
                TipoAtributo tipoSeleccionado = (TipoAtributo)cbTipoAtributo.SelectedItem;

                // Verificar si el nombre del atributo está vacío
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El nombre del atributo no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar si ya existe un atributo con el mismo nombre
                if (ExisteAtributoConNombre(nombre))
                {
                    MessageBox.Show("Ya existe un atributo con el nombre '" + nombre + "'. Por favor, elija otro nombre.", "Nombre duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear el objeto Atributo solo si el nombre es único
                Atributo atributo = new Atributo(nombre, tipoSeleccionado);
                MessageBox.Show("Atributo creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Regresar a la lista de atributos
                ListarAtributo listarAtributo = new ListarAtributo();
                listarAtributo.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el atributo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
