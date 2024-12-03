using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PIM
{
    public partial class CrearProducto : Form
    {
        // Lista de atributos pendientes para ser guardados
        private string nombreAtributoSeleccionado;
        List<ValorAtributo> ListaAtributosPendientes = new List<ValorAtributo>();

        private string ThumbnailBase64;

        public CrearProducto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cargar las categorías en el clbCategorias
            foreach (Categoria p in Categoria.ListaCategorias())
            {
                clbCategorias.Items.Add(p);
            }

            // Cargar los atributos en el DataGridView
            dataGridView1.DataSource = Atributo.ListaAtributos();
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.ClearSelection();

            // Inicialmente, ocultar el TextBox y la Label de atributo
            tbAtributo.Visible = false;
            lbAtributo.Visible = false;
            bAgregar.Visible = false;

        }

        private void bThumbnail_Click(object sender, EventArgs e)
        {
            // Crear el OpenFileDialog para seleccionar la imagen
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Todos los archivos|*.*";
            openFileDialog.Title = "Seleccionar una imagen";

            // Si el usuario selecciona una imagen, la mostramos en el PictureBox
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image imagen = new Bitmap(openFileDialog.FileName);

                    // Mostrar la imagen en el PictureBox
                    pbThumbnail.SizeMode = PictureBoxSizeMode.Zoom;
                    pbThumbnail.Image = imagen;

                    // Convertir la imagen a Base64
                    ThumbnailBase64 = ImagenABase64(imagen);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el nombre del atributo seleccionado
                nombreAtributoSeleccionado = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                // Limpiar el TextBox
                tbAtributo.Clear();

                // Mostrar el TextBox y la Label para ingresar el valor del atributo
                tbAtributo.Visible = true;
                lbAtributo.Visible = true;
                bAgregar.Visible = true;
                // Actualizar la Label con el nombre del atributo seleccionado
                lbAtributo.Text = "Atributo seleccionado: " + nombreAtributoSeleccionado;
            }
            else
            {
                // Si no se selecciona ninguna fila, ocultamos el TextBox y la Label
                tbAtributo.Visible = false;
                lbAtributo.Visible = false;
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            // Abrir la ventana de listar productos y ocultar la actual
            ListarProducto listarProductoForm = new ListarProducto();
            listarProductoForm.Show();
            this.Hide();
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear el producto
                Producto producto = new Producto(tbSku.Text, tbGtin.Text, tbNombre.Text, ThumbnailBase64);

                // Guardar los valores de los atributos
                foreach (ValorAtributo v in ListaAtributosPendientes)
                {
                    ValorAtributo v2 = new ValorAtributo(tbSku.Text, tbGtin.Text, v.atributoNombre, v.valor);
                }

                // Guardar las categorías seleccionadas
                foreach (object item in clbCategorias.CheckedItems)
                {
                    Categoria categoriaSeleccionada = (Categoria)item;
                    ProductoCategoria pc = new ProductoCategoria(tbSku.Text, tbGtin.Text, categoriaSeleccionada.Nombre);
                    categoriaSeleccionada.NumeroProductos++;

                }



                MessageBox.Show("Producto creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir la lista de productos y ocultar la ventana actual
                ListarProducto listarProductoForm = new ListarProducto();
                listarProductoForm.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void clbCategorias_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Lógica para manejar cambios en la selección de categorías si es necesario
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            ListaAtributosPendientes.Add(new ValorAtributo(nombreAtributoSeleccionado, tbAtributo.Text));
        }


        private string ImagenABase64(Image imagen)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Usa el formato adecuado
                byte[] bytes = ms.ToArray();
                return Convert.ToBase64String(bytes);
            }
        }

        private Image Base64AImagen(string base64)
        {
            byte[] bytes = Convert.FromBase64String(base64);
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void bDashboard_Click(object sender, EventArgs e)
        {
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();

            // Mostrar el formulario principal
            pantallaPrincipal.Show();

            // Ocultar el formulario actual
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

        private void bDashboard_Click_1(object sender, EventArgs e)
        {
            PantallaPrincipal principal = new PantallaPrincipal();
            this.Hide();
            principal.Show();
        }
    }
}
