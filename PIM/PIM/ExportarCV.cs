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
                // Obtener los nombres de las categorías y cargarlas en el ComboBox
                var categorias = context.Categoria.Select(c => c.Nombre).ToList();
                cbCategorias.DataSource = categorias;
            }
            using (TiendaEntities1 BD = new TiendaEntities1())
            {
                // Limpiar columnas anteriores si existen
                dataGridViewProductos.Columns.Clear();

                // Agregar columna Thumbnail como primera columna
                if (!dataGridViewProductos.Columns.Contains("Thumbnail"))
                {
                    DataGridViewImageColumn thumbnailColumn = new DataGridViewImageColumn
                    {
                        Name = "Thumbnail",
                        HeaderText = "Thumbnail",
                        ImageLayout = DataGridViewImageCellLayout.Zoom // Ajusta la imagen al tamaño de la celda
                    };
                    dataGridViewProductos.Columns.Add(thumbnailColumn);
                }

                // Configurar el tamaño de la fila para reducir el tamaño de la imagen
                dataGridViewProductos.RowTemplate.Height = 50; // Puedes ajustar el valor según el tamaño deseado

                // Crear columnas base (SKU, GTIN, Name)
                dataGridViewProductos.Columns.Add("SKU", "SKU");
                dataGridViewProductos.Columns.Add("GTIN", "GTIN");
                dataGridViewProductos.Columns.Add("Name", "Name");

                // Obtener los atributos dinámicos de la tabla Atributo
                var atributos = BD.Atributo.ToList();

                // Crear una columna por cada atributo
                foreach (var atributo in atributos)
                {
                    if (!dataGridViewProductos.Columns.Contains(atributo.Nombre)) // Evitar duplicados
                    {
                        dataGridViewProductos.Columns.Add(atributo.Nombre, atributo.Nombre);
                    }
                }

                // Obtener productos de la base de datos con sus valores de atributos
                var productos = (from p in BD.Producto
                                 select new
                                 {
                                     SKU = p.Sku,
                                     GTIN = p.Gtin,
                                     Name = p.Nombre,
                                     Thumbnail = p.Thumbnail, // Asumiendo que el campo es byte[]
                                     ValoresAtributos = p.ValorAtributo.ToList()
                                 }).ToList();

                // Agregar las filas de productos al DataGridView
                foreach (var producto in productos)
                {
                    var row = new DataGridViewRow();

                    // Convertir Thumbnail a Image si existe
                    Image thumbnailImage = producto.Thumbnail != null ? ByteArrayToImage(producto.Thumbnail) : null;

                    // Crear la fila con el Thumbnail primero
                    row.CreateCells(dataGridViewProductos, thumbnailImage, producto.SKU, producto.GTIN, producto.Name);

                    // Llenar las columnas de atributos
                    foreach (var atributo in atributos)
                    {
                        // Buscar el valor del atributo para este producto
                        var valorAtributo = producto.ValoresAtributos
                            .FirstOrDefault(va => va.AtributoId == atributo.Id);

                        // Encontrar el índice de la columna actual
                        int columnIndex = dataGridViewProductos.Columns[atributo.Nombre].Index;

                        // Asignar el valor del atributo o una cadena vacía si no existe
                        row.Cells[columnIndex].Value = valorAtributo != null ? valorAtributo.Valor : "";
                    }

                    dataGridViewProductos.Rows.Add(row);
                }
            }
            dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProductos.AllowUserToAddRows = false;

            // Establecer el ComboBox en blanco al cargar el formulario
            cbCategorias.SelectedItem = null;
            cbCategorias.Text = "";
        }

        private void cargarDatos(string CategoriaSeleccioanda)
        {
            using (TiendaEntities1 BD = new TiendaEntities1())
            {
                // Limpiar columnas anteriores si existen
                dataGridViewProductos.Columns.Clear();

                // Agregar columna Thumbnail como primera columna
                if (!dataGridViewProductos.Columns.Contains("Thumbnail"))
                {
                    DataGridViewImageColumn thumbnailColumn = new DataGridViewImageColumn
                    {
                        Name = "Thumbnail",
                        HeaderText = "Thumbnail",
                        ImageLayout = DataGridViewImageCellLayout.Zoom // Ajusta la imagen al tamaño de la celda
                    };
                    dataGridViewProductos.Columns.Add(thumbnailColumn);
                }

                // Configurar el tamaño de la fila para reducir el tamaño de la imagen
                dataGridViewProductos.RowTemplate.Height = 50; // Puedes ajustar el valor según el tamaño deseado

                // Crear columnas base (SKU, GTIN, Name)
                dataGridViewProductos.Columns.Add("SKU", "SKU");
                dataGridViewProductos.Columns.Add("GTIN", "GTIN");
                dataGridViewProductos.Columns.Add("Name", "Name");

                // Obtener los atributos dinámicos de la tabla Atributo
                var atributos = BD.Atributo.ToList();

                // Crear una columna por cada atributo
                foreach (var atributo in atributos)
                {
                    if (!dataGridViewProductos.Columns.Contains(atributo.Nombre)) // Evitar duplicados
                    {
                        dataGridViewProductos.Columns.Add(atributo.Nombre, atributo.Nombre);
                    }
                }

                // Obtener productos de la base de datos con sus valores de atributos
                var productos = (from p in BD.Producto
                                 where p.Categoria.Any(c => c.Nombre == categoriaSeleccionada) // Filtra por categoría seleccionada
                                 select new
                                 {
                                     SKU = p.Sku,
                                     GTIN = p.Gtin,
                                     Name = p.Nombre,
                                     Thumbnail = p.Thumbnail, // Asumiendo que el campo es byte[]
                                     ValoresAtributos = p.ValorAtributo.ToList()
                                 }).ToList();

                // Agregar las filas de productos al DataGridView
                foreach (var producto in productos)
                {
                    var row = new DataGridViewRow();

                    // Convertir Thumbnail a Image si existe
                    Image thumbnailImage = producto.Thumbnail != null ? ByteArrayToImage(producto.Thumbnail) : null;

                    // Crear la fila con el Thumbnail primero
                    row.CreateCells(dataGridViewProductos, thumbnailImage, producto.SKU, producto.GTIN, producto.Name);

                    // Llenar las columnas de atributos
                    foreach (var atributo in atributos)
                    {
                        // Buscar el valor del atributo para este producto
                        var valorAtributo = producto.ValoresAtributos
                            .FirstOrDefault(va => va.AtributoId == atributo.Id);

                        // Encontrar el índice de la columna actual
                        int columnIndex = dataGridViewProductos.Columns[atributo.Nombre].Index;

                        // Asignar el valor del atributo o una cadena vacía si no existe
                        row.Cells[columnIndex].Value = valorAtributo != null ? valorAtributo.Valor : "";
                    }

                     dataGridViewProductos.Rows.Add(row);
                }
            }
        }
        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }

        private void bFiltrar_Click(object sender, EventArgs e)
        {
            // Asignar la categoría seleccionada a la variable global
            categoriaSeleccionada = cbCategorias.SelectedItem as string;

            // Verificar si se seleccionó una categoría
            if (!string.IsNullOrEmpty(categoriaSeleccionada))
            {
                cargarDatos(categoriaSeleccionada);
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
                //MessageBox.Show("Please, select a category to change the form");
                //return;
            }

            // Crear una instancia del formulario Exportar
            Exportar n = new Exportar(categoriaSeleccionada);
            n.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ListarProducto ex = new ListarProducto();
            ex.Show();
        }
    }
}
