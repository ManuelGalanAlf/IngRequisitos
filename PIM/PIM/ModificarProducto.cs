using System;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PIM
{
    public partial class ModificarProducto : Form
    {
        private Producto producto;
        TiendaEntities1 BD = new TiendaEntities1();

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
                                Name = atributo.Nombre,     // Nombre del atributo
                                Value = va != null ? va.Valor : ""  // Valor si existe, de lo contrario cadena vacía
                            }).ToList();

                // Crear una tabla temporal para que los datos sean editables
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("Name", typeof(string));
                dataTable.Columns.Add("Value", typeof(string));

                // Añadir los atributos a la tabla, con sus valores correspondientes
                foreach (var item in data)
                {
                    dataTable.Rows.Add(item.Id, item.Name, item.Value);
                }

                // Asignar la tabla al DataGridView
                dataGridView1.DataSource = dataTable;

                // Configurar columnas del DataGridView
                dataGridView1.Columns["Id"].Visible = false;            // Ocultar columna "Id"
                dataGridView1.Columns["Name"].ReadOnly = true;        // No permitir editar "Nombre"
                dataGridView1.Columns["Value"].ReadOnly = false;        // Permitir editar "Valor"
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

                // Mostrar el thumbnail en el PictureBox si existe
                if (producto.Thumbnail != null && producto.Thumbnail.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(producto.Thumbnail))
                    {
                        pbThumbnail.Image = Image.FromStream(ms);  // Cargar la imagen desde los bytes y asignarla al PictureBox
                        pbThumbnail.SizeMode = PictureBoxSizeMode.StretchImage;  // Asegurarse de que la imagen se ajuste al tamaño del PictureBox
                    }
                }
                else
                {
                    pbThumbnail.Image = null;  // Si no hay imagen, asegurarse de que el PictureBox esté vacío
                }
            }
        }

        private void bThumbnail_Click(object sender, EventArgs e)
        {
            // Crear el OpenFileDialog
            OpenFileDialog ofd_Thumbnail = new OpenFileDialog();
            ofd_Thumbnail.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp;*.gif"; // Filtro para imágenes
            ofd_Thumbnail.Title = "Select an image for the thumbnail";

            if (ofd_Thumbnail.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Cargar la imagen seleccionada y asignarla al PictureBox
                    pbThumbnail.Image = Image.FromFile(ofd_Thumbnail.FileName);
                    pbThumbnail.SizeMode = PictureBoxSizeMode.StretchImage;  // Asegurarse de que la imagen se ajuste al tamaño del PictureBox
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image " + ex.Message);
                }
            }
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                // Convertir el GTIN fuera de la consulta LINQ
                long gtinBuscado = long.Parse(tbGtin.Text);

                // Obtener el producto a actualizar por su GTIN
                var productoParaActualizar = BD.Producto.FirstOrDefault(p => p.Gtin == gtinBuscado);

                if (productoParaActualizar == null)
                {
                    MessageBox.Show("Product not found");
                    return;
                }

                // Actualizar los datos básicos del producto
                productoParaActualizar.Nombre = tbNombre.Text;
                productoParaActualizar.Gtin = gtinBuscado;
                productoParaActualizar.Sku = int.Parse(tbSku.Text);
                productoParaActualizar.FechaModificacion = DateTime.Today;

                // Procesar los valores de los atributos
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Id"].Value == null) continue;

                    int atributoId = (int)row.Cells["Id"].Value;
                    string valor = row.Cells["Value"].Value != null ? row.Cells["Value"].Value.ToString() : string.Empty;

                    // Buscar el ValorAtributo existente para el producto y el atributo actual
                    var valorAtributoExistente = BD.ValorAtributo
                        .FirstOrDefault(va => va.ProductoId == productoParaActualizar.Id && va.AtributoId == atributoId);

                    if (string.IsNullOrWhiteSpace(valor))
                    {
                        // Si el valor está vacío y existe un registro en la base de datos, eliminarlo
                        if (valorAtributoExistente != null)
                        {
                            BD.ValorAtributo.Remove(valorAtributoExistente);
                        }
                    }
                    else
                    {
                        // Si el valor no está vacío, actualizar o crear un nuevo registro
                        if (valorAtributoExistente != null)
                        {
                            valorAtributoExistente.Valor = valor;
                        }
                        else
                        {
                            // Crear un nuevo ValorAtributo si no existe
                            BD.ValorAtributo.Add(new ValorAtributo
                            {
                                ProductoId = productoParaActualizar.Id,
                                AtributoId = atributoId,
                                Valor = valor
                            });
                        }
                    }
                }

                // Obtener las categorías seleccionadas en el CheckedListBox
                var categoriasSeleccionadas = clbCategorias.CheckedItems.Cast<string>()
                    .Select(nombreCategoria => BD.Categoria.FirstOrDefault(c => c.Nombre == nombreCategoria))
                    .Where(c => c != null)
                    .ToList();

                // Obtener las categorías actualmente asociadas al producto
                var categoriasAsociadas = productoParaActualizar.Categoria.ToList();

                // Desasociar categorías desmarcadas
                foreach (var categoria in categoriasAsociadas)
                {
                    if (!categoriasSeleccionadas.Contains(categoria))
                    {
                        productoParaActualizar.Categoria.Remove(categoria);
                        if (categoria.NumeroProductos > 0)
                        {
                            categoria.NumeroProductos--;
                        }
                    }
                }

                // Asociar nuevas categorías seleccionadas
                foreach (var categoria in categoriasSeleccionadas)
                {
                    if (!productoParaActualizar.Categoria.Contains(categoria))
                    {
                        productoParaActualizar.Categoria.Add(categoria);
                        categoria.NumeroProductos++;
                    }
                }

                // Guardar los cambios en una transacción para asegurar consistencia
                using (var transaction = BD.Database.BeginTransaction())
                {
                    BD.SaveChanges();
                    transaction.Commit();
                }

                MessageBox.Show("Product updated successfully.");
                this.Close();

                // Abrir el formulario de listado de productos
                ListarProducto listarProducto = new ListarProducto();
                listarProducto.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product:" + ex.Message);
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


    }
}
