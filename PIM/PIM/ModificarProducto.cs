using System;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.Entity;


namespace PIM
{
    public partial class ModificarProducto : Form
    {
        private Producto producto;

        public ModificarProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
        }

        private void ModificarProducto_Load(object sender, EventArgs e)
        {
            try
            {
                // Inicializa el contexto de la base de datos
                TiendaEntities1 BD = new TiendaEntities1();

                // Carga los datos del producto en los controles de la interfaz
                tbGtin.Text = producto.Gtin.ToString();
                tbNombre.Text = producto.Nombre;
                tbSku.Text = producto.Sku.ToString();

                // No es necesario modificar el producto aquí, solo mostrar los datos.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el producto: " + ex.Message);
            }
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de los campos
                if (string.IsNullOrWhiteSpace(tbSku.Text) || string.IsNullOrWhiteSpace(tbNombre.Text))
                {
                    MessageBox.Show("Debe completar todos los campos.");
                    return;
                }

                // Crea el contexto de la base de datos
                using (TiendaEntities1 BD = new TiendaEntities1())
                {
                    // Si el producto ya está siendo rastreado, lo desasociamos primero
                    BD.Entry(producto).State = EntityState.Detached;

                    // Ahora, cargamos el producto nuevamente desde la base de datos
                    var productoParaActualizar = BD.Producto.FirstOrDefault(p => p.Sku == producto.Sku);

                    if (productoParaActualizar != null)
                    {
                        // Actualiza los valores del producto con los datos del formulario
                        productoParaActualizar.Sku = int.Parse(tbSku.Text);
                        productoParaActualizar.Nombre = tbNombre.Text;
                        productoParaActualizar.Gtin = long.Parse(tbGtin.Text); // Si también quieres actualizar el GTIN

                        // Guarda los cambios en la base de datos
                        BD.SaveChanges();

                        MessageBox.Show("Producto actualizado correctamente.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado en la base de datos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message);
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            ListarProducto listarProducto = new ListarProducto();
            listarProducto.Show();
            this.Hide();
        }

        private void bDashboard_Click(object sender, EventArgs e)
        {
            PantallaPrincipal c = new PantallaPrincipal();
            c.Show();
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





        // Otros métodos y eventos si es necesario
    }
}
