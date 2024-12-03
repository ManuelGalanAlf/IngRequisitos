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
    public partial class CrearAtributo : Form
    {
        public enum TipoAtributo
        {
            Entero,
            Real,
            Cadena
        }

        grupo17_DB DB = new grupo17_DB();

        public CrearAtributo()
        {
            InitializeComponent();
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

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string tipoString = cbTipoAtributo.SelectedItem.ToString();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Introduzca un nombre para crear producto.");
                return;
            }

            Atributo nuevoAtributo = new Atributo
            {
                nombre = nombre,
                tipo = tipoString
            };

            try
            {
                // Añadir el nuevo atributo al contexto de la base de datos
                DB.Atributo.Add(nuevoAtributo);

                // Guardar los cambios en la base de datos
                DB.SaveChanges();

                MessageBox.Show("Atributo creado exitosamente.");

                // Opcional: Navegar a la pantalla que lista los atributos
                ListarAtributo listarAtributo = new ListarAtributo();
                listarAtributo.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el atributo: " + ex.Message);
            }
        }

       
    }
}
