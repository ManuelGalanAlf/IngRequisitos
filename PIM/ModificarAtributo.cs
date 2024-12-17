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
    public partial class ModificarAtributo : Form
    {
        TiendaEntities1 bd = new TiendaEntities1();

        Atributo atributo;
        public ModificarAtributo(Atributo atributo)
        {
            InitializeComponent();
            this.atributo = atributo;
        }

        private void ModificarAtributo_Load(object sender, EventArgs e)
        {
            // Configurar el campo de texto para el nombre
            tbNombre.Text = atributo.Nombre;

            // Poblar el ComboBox con los tipos válidos (solo lectura)
            cbTipoAtributo.DataSource = Enum.GetValues(typeof(CrearAtributo.TipoAtributo));

            // Seleccionar el tipo actual del atributo
            CrearAtributo.TipoAtributo tipoSeleccionado;
            if (Enum.TryParse(atributo.Tipo, out tipoSeleccionado))
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
                bd.Entry(atributo).State = EntityState.Detached;
                var atributoSeleccionado = bd.Atributo.FirstOrDefault(a => a.Nombre == atributo.Nombre);

                string nuevoNombre = tbNombre.Text;
                // Verificar si el nombre no está vacío
                if (string.IsNullOrEmpty(nuevoNombre))
                {
                    MessageBox.Show("Please enter a name for the attribute.");
                    return;
                }

                // Actualizar el nombre del atributo
                atributoSeleccionado.Nombre = nuevoNombre;

                bd.SaveChanges();

                MessageBox.Show("Attribute updated successfully.");

                ListarAtributo listarAtributo = new ListarAtributo();
                listarAtributo.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the attribute: " + ex.Message);
            }
        }

        private void bRelaciones_Click(object sender, EventArgs e)
        {
            ListarRelacion listarRelacion = new ListarRelacion();
            listarRelacion.Show();
            this.Hide();
        }

        private void Tipo_Click(object sender, EventArgs e)
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
