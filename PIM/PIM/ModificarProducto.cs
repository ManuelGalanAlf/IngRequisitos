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
            TiendaEntities1 BD = new TiendaEntities1();

            // Cargar los ValorAtributo correspondientes al producto
            var data = (from va in BD.ValorAtributo
                        where va.ProductoId == producto.Id
                        select new
                        {
                            Id = va.AtributoId,  // Usar el Id del atributo
                            Nombre = va.Atributo.Nombre,
                            Valor = va.Valor // El valor del atributo para este producto
                        }).ToList();

            // Crear una tabla temporal para que los datos sean editables
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));  // Para el Id del atributo
            dataTable.Columns.Add("Nombre", typeof(string));
            dataTable.Columns.Add("Valor", typeof(string));

            // Añadir los ValorAtributo a la tabla
            foreach (var item in data)
            {
                dataTable.Rows.Add(item.Id, item.Nombre, item.Valor);
            }

            // Asignar la tabla al DataGridView
            dataGridView1.DataSource = dataTable;

            // Permitir edición solo en la columna "Valor"
            dataGridView1.Columns["Valor"].ReadOnly = false;
            dataGridView1.Columns["Nombre"].ReadOnly = true; // No permitir editar "Nombre"
            dataGridView1.AllowUserToAddRows = false;

            // Mostrar los valores actuales en los TextBox
            tbNombre.Text = producto.Nombre;
            tbGtin.Text = producto.Gtin.ToString();
            tbSku.Text = producto.Sku.ToString(); // Agregar SKU

            // Cargar las categorías en el CheckedListBox
            foreach (Categoria c in BD.Categoria)
            {
                clbCategorias.Items.Add(c.Nombre);
            }

            // Marcar las categorías asociadas al producto
            foreach (var categoria in producto.Categoria)
            {
                int index = clbCategorias.Items.IndexOf(categoria.Nombre);
                if (index != -1)
                {
                    clbCategorias.SetItemChecked(index, true);
                }
            }
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                using (TiendaEntities1 BD = new TiendaEntities1())
                {
                    // Obtener el producto usando su Id
                    var productoParaActualizar = BD.Producto.FirstOrDefault(p => p.Id == producto.Id);

                    if (productoParaActualizar != null)
                    {
                        // Actualizar los datos básicos del producto
                        productoParaActualizar.Nombre = tbNombre.Text;
                        productoParaActualizar.Gtin = Convert.ToInt64(tbGtin.Text);
                        productoParaActualizar.Sku = int.Parse(tbSku.Text); // Actualizar SKU

                        // Actualizar atributos
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.IsNewRow) continue;

                            int atributoId = Convert.ToInt32(row.Cells["Id"].Value);
                            string valorAtributo = row.Cells["Valor"].Value.ToString();

                            var atributo = BD.ValorAtributo
                                .FirstOrDefault(va => va.ProductoId == producto.Id && va.AtributoId == atributoId);

                            if (atributo != null)
                            {
                                // Actualiza el valor del atributo
                                atributo.Valor = valorAtributo;
                            }
                        }

                        // Obtener las categorías seleccionadas del CheckedListBox por su Id
                        var categoriasSeleccionadas = clbCategorias.CheckedItems.Cast<string>().Select(item =>
                        {
                            return BD.Categoria.FirstOrDefault(c => c.Nombre == item);  // Obtener la categoría por nombre
                        }).Where(c => c != null).ToList();

                        // Obtener las categorías actuales asociadas al producto
                        var categoriasActuales = productoParaActualizar.Categoria.ToList();

                        // Añadir nuevas categorías
                        foreach (var categoria in categoriasSeleccionadas)
                        {
                            if (!categoriasActuales.Contains(categoria))
                            {
                                productoParaActualizar.Categoria.Add(categoria);  // Agregar categoría si no está asociada
                                categoria.NumeroProductos++;  // Incrementar el contador de productos
                            }
                        }

                        // Eliminar categorías no seleccionadas
                        foreach (var categoria in categoriasActuales)
                        {
                            if (!categoriasSeleccionadas.Contains(categoria))
                            {
                                productoParaActualizar.Categoria.Remove(categoria);  // Eliminar categoría si no está seleccionada
                                categoria.NumeroProductos--;  // Decrementar el contador de productos
                            }
                        }

                        // Guardar cambios en la base de datos
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
