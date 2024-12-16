using System;
using System.Linq;
using System.Windows.Forms;

namespace PIM
{
    public partial class ExportarCV : Form
    {
        // Variable global para almacenar la categoría seleccionada
        private string categoriaSeleccionada;

        public ExportarCV()
        {
            InitializeComponent();
        }

        private void ExportarCV_Load(object sender, EventArgs e)
        {
            using (var context = new TiendaEntities1())
            {
                // Obtener los nombres de las categorías
                var categorias = context.Categoria.Select(c => c.Nombre).ToList();
                // Cargar el ComboBox con los nombres de las categorías
                cbCategorias.DataSource = categorias;
            }

            // Establecer el ComboBox en blanco al cargar el formulario
            cbCategorias.SelectedItem = null;  // Esto asegura que no haya ningún valor seleccionado al inicio
            cbCategorias.Text = "";  
        }

        private void bFiltrar_Click(object sender, EventArgs e)
        {
            // Asignar la categoría seleccionada a la variable global
            categoriaSeleccionada = cbCategorias.SelectedItem as string;

            // Verificar si se seleccionó una categoría
            if (!string.IsNullOrEmpty(categoriaSeleccionada))
            {
                using (var context = new TiendaEntities1())
                {
                    // Obtener los productos asociados a la categoría seleccionada
                    var productos = context.Producto
                                           .Where(p => p.Categoria.Any(c => c.Nombre == categoriaSeleccionada))  // Compara con los nombres de las categorías
                                           .Select(p => p.Nombre)
                                           .ToList();

                    // Limpiar el ListBox antes de agregar los nuevos productos
                    lCategorias.Items.Clear();

                    // Agregar los productos al ListBox
                    foreach (var producto in productos)
                    {
                        lCategorias.Items.Add(producto);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please, select a category");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Solo cambiar de formulario si se ha seleccionado una categoría
            if (string.IsNullOrEmpty(categoriaSeleccionada))
            {
                MessageBox.Show("Please, select a category to change the form");
                return;
            }

            // Crear una instancia del formulario Exportar
            Exportar n = new Exportar(categoriaSeleccionada);
            n.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            PantallaPrincipal ex = new PantallaPrincipal();
            ex.Show();

        }
    }
}
