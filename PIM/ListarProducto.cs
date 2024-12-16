using System;
using System.Linq;
using System.Windows.Forms;
using System.Data;

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
                var productos = (from p in BD.Producto
                                 select new
                                 {
                                     SKU = p.Sku,  // Renombrar la columna a "SKU"
                                     GTIN = p.Gtin,  // Renombrar la columna a "GTIN"
                                     Name = p.Nombre,
                                 }).ToList();

                dataGridView1.DataSource = productos;
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
