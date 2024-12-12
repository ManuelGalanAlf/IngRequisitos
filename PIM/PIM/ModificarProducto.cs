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
    using (TiendaEntities1 BD = new TiendaEntities1())
    {
        // Obtener todos los atributos disponibles
        var todosLosAtributos = BD.Atributo.ToList();

        // Obtener los valores de atributos existentes para el producto actual
        var valoresAtributosProducto = BD.ValorAtributo
            .Where(va => va.ProductoId == producto.Id)
            .ToList();

        // Crear una lista combinada que incluya todos los atributos, incluso sin valor
        var data = (from atributo in todosLosAtributos
                    join va in valoresAtributosProducto
                    on atributo.Id equals va.AtributoId into valores
                    from va in valores.DefaultIfEmpty()
                    select new
                    {
                        Id = atributo.Id,             // Id del atributo
                        Nombre = atributo.Nombre,     // Nombre del atributo
                        Valor = va != null ? va.Valor : ""  // Valor si existe, de lo contrario cadena vacía
                    }).ToList();

        // Crear una tabla temporal para que los datos sean editables
        DataTable dataTable = new DataTable();
        dataTable.Columns.Add("Id", typeof(int));
        dataTable.Columns.Add("Nombre", typeof(string));
        dataTable.Columns.Add("Valor", typeof(string));

        // Añadir los atributos a la tabla, con sus valores correspondientes
        foreach (var item in data)
        {
            dataTable.Rows.Add(item.Id, item.Nombre, item.Valor);
        }

        // Asignar la tabla al DataGridView
        dataGridView1.DataSource = dataTable;

        // Configurar columnas del DataGridView
        dataGridView1.Columns["Id"].Visible = false;            // Ocultar columna "Id"
        dataGridView1.Columns["Nombre"].ReadOnly = true;        // No permitir editar "Nombre"
        dataGridView1.Columns["Valor"].ReadOnly = false;        // Permitir editar "Valor"
        dataGridView1.AllowUserToAddRows = false;

        // Mostrar los valores actuales en los TextBox
        tbNombre.Text = producto.Nombre;
        tbGtin.Text = producto.Gtin.ToString();
        tbSku.Text = producto.Sku.ToString();

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
                productoParaActualizar.Sku = int.Parse(tbSku.Text);

                // Actualizar atributos
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    int atributoId = Convert.ToInt32(row.Cells["Id"].Value);
                    string valorAtributo = (row.Cells["Valor"].Value != null) ? row.Cells["Valor"].Value.ToString().Trim() : string.Empty;

                    if (!string.IsNullOrEmpty(valorAtributo))
                    {
                        // Buscar si ya existe un ValorAtributo para este producto y atributo
                        var atributo = BD.ValorAtributo
                            .FirstOrDefault(va => va.ProductoId == producto.Id && va.AtributoId == atributoId);

                        if (atributo != null)
                        {
                            // Actualiza el valor existente
                            atributo.Valor = valorAtributo;
                        }
                        else
                        {
                            // Inserta un nuevo registro si no existe
                            var nuevoValorAtributo = new ValorAtributo
                            {
                                ProductoId = producto.Id,
                                AtributoId = atributoId,
                                Valor = valorAtributo
                            };
                            BD.ValorAtributo.Add(nuevoValorAtributo);
                        }
                    }
                }

                // Obtener las categorías seleccionadas del CheckedListBox por su Id
                var categoriasSeleccionadas = clbCategorias.CheckedItems.Cast<string>()
                    .Select(item => BD.Categoria.FirstOrDefault(c => c.Nombre == item))
                    .Where(c => c != null)
                    .ToList();

                // Obtener las categorías actuales asociadas al producto
                var categoriasActuales = productoParaActualizar.Categoria.ToList();

                // Añadir nuevas categorías
                foreach (var categoria in categoriasSeleccionadas)
                {
                    if (!categoriasActuales.Contains(categoria))
                    {
                        productoParaActualizar.Categoria.Add(categoria);
                        categoria.NumeroProductos++;
                    }
                }

                // Eliminar categorías no seleccionadas
                foreach (var categoria in categoriasActuales)
                {
                    if (!categoriasSeleccionadas.Contains(categoria))
                    {
                        productoParaActualizar.Categoria.Remove(categoria);
                        categoria.NumeroProductos--;
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
    }
}
