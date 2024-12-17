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
    public partial class ListarProducto : Form
    {
        public ListarProducto()
        {
            InitializeComponent();
        }

        private void ListarProducto_Load(object sender, EventArgs e)
        {
            CargarProductos();

            // Agregar los botones de "Editar" y "Borrar" si no existen
            AgregarBotonesDataGridView();

            // Vincular el evento para manejar el clic en las celdas
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }

        private void AgregarBotonesDataGridView()
        {
            // Agregar la columna "Editar" si no existe
            if (!dataGridView1.Columns.Contains("Edit"))
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(btnEditar);
            }

            // Agregar la columna "Borrar" si no existe
            if (!dataGridView1.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn btnBorrar = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(btnBorrar);
            }

            // Agregar la columna "Mostrar" si no existe
            if (!dataGridView1.Columns.Contains("Show"))
            {
                DataGridViewButtonColumn btnMostrar = new DataGridViewButtonColumn
                {
                    Name = "Show",
                    Text = "Show",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(btnMostrar);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el índice de fila y columna sean válidos
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && e.ColumnIndex >= 0)
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                if (columnName == "Edit" || columnName == "Delete" || columnName == "Show")
                {
                    var selectedRow = dataGridView1.Rows[e.RowIndex];

                    // Verificar si la fila tiene datos válidos en la columna "SKU"
                    if (selectedRow.Cells["SKU"].Value != null)
                    {
                        int sku = Convert.ToInt32(selectedRow.Cells["SKU"].Value);

                        if (columnName == "Edit")
                        {
                            EditarProducto(sku);
                        }
                        else if (columnName == "Delete")
                        {
                            BorrarProducto(sku);
                        }
                        else if (columnName == "Show")
                        {
                            MostrarProducto(sku);
                        }
                    }
                }
            }
        }

        private void EditarProducto(int sku)
        {
            using (TiendaEntities1 BD = new TiendaEntities1())
            {
                var producto = BD.Producto.FirstOrDefault(p => p.Sku == sku);

                if (producto != null)
                {
                    var editarForm = new ModificarProducto(producto);
                    editarForm.ShowDialog();
                    this.Close();
                    CargarProductos();
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }
            }
        }

        private void BorrarProducto(int sku)
        {
            using (TiendaEntities1 BD = new TiendaEntities1())
            {
                var producto = BD.Producto.FirstOrDefault(p => p.Sku == sku);

                if (producto != null)
                {
                    DialogResult confirmacion = MessageBox.Show(
                        "Are you sure you want to delete this product?",
                        "Confirm",
                        MessageBoxButtons.YesNo);

                    if (confirmacion == DialogResult.Yes)
                    {
                        // Eliminar registros relacionados en la tabla Relacion
                        var relaciones = BD.Relacion.Where(r => r.Producto1 == sku).ToList();
                        foreach (var relacion in relaciones)
                        {
                            BD.Relacion.Remove(relacion);
                        }

                        // Actualizar atributos relacionados
                        var valorAtributos = BD.ValorAtributo.Where(va => va.ProductoId == producto.Sku).ToList();
                        foreach (var valorAtributo in valorAtributos)
                        {
                            var atributo = BD.Atributo.FirstOrDefault(a => a.Id == valorAtributo.AtributoId);
                            if (atributo != null)
                            {
                                atributo.NumeroProductos--;
                            }
                        }

                        // Actualizar categorías relacionadas
                        var categorias = BD.Categoria.Where(c => c.Producto.Any(p => p.Sku == producto.Sku)).ToList();
                        foreach (var categoria in categorias)
                        {
                            categoria.NumeroProductos--;
                        }

                        // Eliminar el producto
                        BD.Producto.Remove(producto);
                        BD.SaveChanges();

                        MessageBox.Show("Product deleted successfully.");
                        CargarProductos(); // Actualizar el DataGridView después de borrar
                    }
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }
            }
        }


        private void CargarProductos()
        {
            using (TiendaEntities1 BD = new TiendaEntities1())
            {
                // Limpiar columnas anteriores si existen
                dataGridView1.Columns.Clear();

                // Agregar columna Thumbnail como primera columna
                if (!dataGridView1.Columns.Contains("Thumbnail"))
                {
                    DataGridViewImageColumn thumbnailColumn = new DataGridViewImageColumn
                    {
                        Name = "Thumbnail",
                        HeaderText = "Thumbnail",
                        ImageLayout = DataGridViewImageCellLayout.Zoom // Ajusta la imagen al tamaño de la celda
                    };
                    dataGridView1.Columns.Add(thumbnailColumn);
                }

                // Configurar el tamaño de la fila para reducir el tamaño de la imagen
                dataGridView1.RowTemplate.Height = 50; // Puedes ajustar el valor según el tamaño deseado

                // Crear columnas base (SKU, GTIN, Name)
                dataGridView1.Columns.Add("SKU", "SKU");
                dataGridView1.Columns.Add("GTIN", "GTIN");
                dataGridView1.Columns.Add("Name", "Name");

                // Obtener los atributos dinámicos de la tabla Atributo
                var atributos = BD.Atributo.ToList();

                // Crear una columna por cada atributo
                foreach (var atributo in atributos)
                {
                    if (!dataGridView1.Columns.Contains(atributo.Nombre)) // Evitar duplicados
                    {
                        dataGridView1.Columns.Add(atributo.Nombre, atributo.Nombre);
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
                    row.CreateCells(dataGridView1, thumbnailImage, producto.SKU, producto.GTIN, producto.Name);

                    // Llenar las columnas de atributos
                    foreach (var atributo in atributos)
                    {
                        // Buscar el valor del atributo para este producto
                        var valorAtributo = producto.ValoresAtributos
                            .FirstOrDefault(va => va.AtributoId == atributo.Id);

                        // Encontrar el índice de la columna actual
                        int columnIndex = dataGridView1.Columns[atributo.Nombre].Index;

                        // Asignar el valor del atributo o una cadena vacía si no existe
                        row.Cells[columnIndex].Value = valorAtributo != null ? valorAtributo.Valor : "";
                    }

                    dataGridView1.Rows.Add(row);
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

        private MostrarProducto mostrarForm; // Campo estático para la instancia de MostrarProducto

        private void MostrarProducto(int sku)
        {
            using (TiendaEntities1 BD = new TiendaEntities1())
            {
                var producto = BD.Producto.FirstOrDefault(p => p.Sku == sku);

                if (producto != null)
                {
                    // Verificar si ya hay una instancia abierta de MostrarProducto
                    if (mostrarForm == null || mostrarForm.IsDisposed)
                    {
                        // Si no existe o ya ha sido cerrada, crear una nueva instancia
                        mostrarForm = new MostrarProducto(producto);
                        mostrarForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Si ya está abierta, llevarla al frente
                        mostrarForm.BringToFront();
                    }
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }
            }
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

        private void bCrearProducto_Click(object sender, EventArgs e)
        {
            CrearProducto crearProducto = new CrearProducto();
            crearProducto.Show();
            
        }

        private void bRelaciones_Click(object sender, EventArgs e)
        {
            ListarRelacion listarRelacion = new ListarRelacion();
            listarRelacion.Show();
            this.Hide();
        }

        private void bCuenta_Click(object sender, EventArgs e)
        {
            MostrarInformacionCuenta m = new MostrarInformacionCuenta();
            m.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExportarCV n = new ExportarCV();
            n.Show();
        }
    }
}
