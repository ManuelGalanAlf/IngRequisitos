using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
//using System.Collections.Generic;

namespace PIM
{
    public partial class MostrarProducto : Form
    {
        private Producto p;

        public MostrarProducto(Producto p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void bDashboard_Click(object sender, EventArgs e)
        {
            PantallaPrincipal p = new PantallaPrincipal();
            this.Hide();
            p.Show();
        }

        private void bAtributos_Click(object sender, EventArgs e)
        {
            ListarAtributo p = new ListarAtributo();
            this.Hide();
            p.Show();
        }

        private void bCategorias_Click(object sender, EventArgs e)
        {
            ListarCategoria p = new ListarCategoria();
            this.Hide();
            p.Show();
        }

        private void bProductos_Click(object sender, EventArgs e)
        {
            ListarProducto p = new ListarProducto();
            this.Hide();
            p.Show();
        }

        private void LlenarDataGridViewConAtributos(Producto producto)
        {
            // Obtener los atributos y sus valores para el producto
            List<ValorAtributo> atributosProducto = ValorAtributo.ListarAtributoDeProducto(producto);

            // Limpiar el DataGridView antes de llenarlo
            dataGridView1.Rows.Clear();

            // Añadir columnas si no están ya añadidas
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("Nombre", "Nombre Atributo");
                dataGridView1.Columns.Add("Valor", "Valor");
            }

            // Añadir filas al DataGridView con el nombre y el valor
            foreach (ValorAtributo atributo in atributosProducto)
            {
                string nombreAtributo = atributo.atributoNombre;
                string valorAtributo = atributo.valor;

                // Añadir una nueva fila al DataGridView
                dataGridView1.Rows.Add(nombreAtributo, valorAtributo);
            }
        }

        private void CargarCategoriasEnListBox()
        {
            // Obtener la lista de categorías con su cantidad de productos
            List<Tuple<string, int>> categoriasConProductos = ProductoCategoria.ListaProductoCategorias();

            // Crear una lista solo con los nombres de las categorías
            List<string> nombresCategorias = categoriasConProductos.Select(c => c.Item1).ToList();

            // Asignar esta lista al ListBox
            listBox1.DataSource = nombresCategorias;

            // Establecer el DisplayMember (esto no es necesario si solo estamos asignando una lista de strings)
            listBox1.DisplayMember = "Nombre"; // Esto es redundante porque el DataSource es una lista de strings.
        }


        private void MostrarProducto_Load(object sender, EventArgs e)
        {
            tNombre.Text = p.Nombre;
            tGtin.Text = p.GTIN;
            tSKU.Text = p.SKU;
            CargarCategoriasEnListBox();
            LlenarDataGridViewConAtributos(p);

            // Mostrar la imagen en el PictureBox
            if (!string.IsNullOrEmpty(p.Thumbnail))
            {
                try
                {
                    // Convertir la imagen de Base64 a Image
                    Image imagen = Base64AImagen(p.Thumbnail);

                    // Mostrar la imagen en el PictureBox
                    pictureBox1.Image = imagen;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }

      
        // Método para convertir Base64 a Image
        private Image Base64AImagen(string base64)
        {
            byte[] bytes = Convert.FromBase64String(base64);
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            p.Borrar();
            this.Close();
            ListarProducto l = new ListarProducto();
            l.Show();
            MessageBox.Show("Producto eliminado correctamente.");

        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            ModificarProducto l = new ModificarProducto(p);
            l.Show();
            this.Close();
        }

        
    }
}
