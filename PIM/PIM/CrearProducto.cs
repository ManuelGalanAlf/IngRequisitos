using System;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace PIM
{
    public partial class CrearProducto : Form
    {
        public CrearProducto()
        {
            InitializeComponent();
        }

        private void CrearProducto_Load(object sender, EventArgs e)
        {
            TiendaEntities1 BD = new TiendaEntities1();

            // Cargar los datos en una lista de objetos anónimos
            var data = (from p in BD.Atributo
                        select new
                        {
                            Id = p.Id,  // Usar el Id del atributo
                            Nombre = p.Nombre,
                            Valor = "" // Texto inicial vacío
                        }).ToList();

            // Crear una tabla temporal para que los datos sean editables
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));  // Para el Id del atributo
            dataTable.Columns.Add("Nombre", typeof(string));
            dataTable.Columns.Add("Valor", typeof(string));

            // Añadir datos a la tabla
            foreach (var item in data)
            {
                dataTable.Rows.Add(item.Id, item.Nombre, item.Valor);
            }

            // Asignar la tabla al DataGridView
            dataGridView1.DataSource = dataTable;

            // Permitir edición solo en la columna "Valor"
            dataGridView1.Columns["Valor"].ReadOnly = false;
            dataGridView1.Columns["Nombre"].ReadOnly = true; // Opcional, para evitar editar "Tipo"
            dataGridView1.AllowUserToAddRows = false;

            // Cargar las categorías en el CheckedListBox
            foreach (Categoria c in BD.Categoria)
            {
                clbCategorias.Items.Add(c.Nombre);
            }
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                TiendaEntities1 BD = new TiendaEntities1();
                string SKU = tbSku.Text;
                if (String.IsNullOrEmpty(SKU))
                {
                    MessageBox.Show("El Sku es obligatorio");
                    return;
                }
                string GTIN = tbGtin.Text;
                if (String.IsNullOrEmpty(GTIN))
                {
                    MessageBox.Show("El Gtin es obligatorio");
                    return;
                }
                string NOMBRE = tbNombre.Text;
                if (String.IsNullOrEmpty(NOMBRE))
                {
                    MessageBox.Show("El Nombre es obligatorio");
                    return;
                }

                Producto p = new Producto();
                p.Sku = int.Parse(SKU);
                p.Gtin = int.Parse(GTIN);
                p.Nombre = NOMBRE;
                p.FechaCreacion = DateTime.Today;

                BD.Producto.Add(p);
                BD.SaveChanges();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Verifica que la fila no sea la fila "nueva" (si está habilitada)
                    if (!row.IsNewRow)
                    {
                        // Accede a las celdas de la fila
                        var valorCelda = row.Cells["Valor"].Value; // Usa el nombre de la columna
                        if (valorCelda != "")
                        {
                            ValorAtributo nuevoValorAtributo = new ValorAtributo();

                            nuevoValorAtributo.ProductoId = p.Id; // Relacionar con este producto usando el Id
                            nuevoValorAtributo.AtributoId = (int)row.Cells["Id"].Value; // Relacionar con el atributo usando el Id
                            nuevoValorAtributo.Valor = (string)valorCelda;

                            BD.ValorAtributo.Add(nuevoValorAtributo);

                            // Actualizar el número de productos en el atributo
                            Atributo atributo = BD.Atributo.FirstOrDefault(a => a.Id == nuevoValorAtributo.AtributoId);
                            if (atributo != null)
                            {
                                atributo.NumeroProductos = atributo.NumeroProductos + 1;
                            }

                            BD.SaveChanges();
                        }
                    }
                }

                foreach (string item in clbCategorias.CheckedItems)
                {
                    // Buscar la categoría por nombre
                    var categoria = BD.Categoria.FirstOrDefault(c => c.Nombre == item);

                    if (categoria != null)
                    {
                        // Agregar la categoría al producto
                        p.Categoria.Add(categoria);
                        categoria.NumeroProductos = categoria.NumeroProductos + 1;
                    }
                }

                BD.SaveChanges(); // Guardar los cambios en las categorías
                MessageBox.Show("Producto creado con éxito");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
