using System;
using System.Linq;
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
            // Configurar el campo de texto para el nombre
            tbNombre.Text = atributo.nombre;

            // Poblar el ComboBox con los tipos válidos (solo lectura)
            cbTipoAtributo.DataSource = Enum.GetValues(typeof(CrearAtributo.TipoAtributo));

            // Seleccionar el tipo actual del atributo
            CrearAtributo.TipoAtributo tipoSeleccionado;
            if (Enum.TryParse(atributo.tipo, out tipoSeleccionado))
            {
                cbTipoAtributo.SelectedItem = tipoSeleccionado;
            }
            else
            {
                // Si no se pudo parsear, selecciona un valor predeterminado
                cbTipoAtributo.SelectedItem = CrearAtributo.TipoAtributo.Cadena;
            }

            // Deshabilitar el ComboBox para evitar cambios en el tipo
            cbTipoAtributo.Enabled = false;
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


            grupo17_DB DB = new grupo17_DB();

            var atributoSeleccionado = DB.Atributo.FirstOrDefault(a => a.nombre == atributo.nombre);

            string nuevoNombre = tbNombre.Text;
            Console.WriteLine("Nuevo nombre: " + nuevoNombre);
            // Verificar si el nombre no está vacío
            if (string.IsNullOrEmpty(nuevoNombre))
            {
                MessageBox.Show("Por favor ingrese un nombre para el atributo.");
                return;
            }

            // Actualizar el nombre del atributo
            atributoSeleccionado.nombre = nuevoNombre;

          
                DB.SaveChanges();

                MessageBox.Show("Atributo actualizado exitosamente.");

                ListarAtributo listarAtributo = new ListarAtributo();
                listarAtributo.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar el atributo: " + ex.Message);
            }


        }
    }
}
