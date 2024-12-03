using System;
using System.Windows.Forms;

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
            // Establecer los datos de la base de datos como fuente del DataGridView
            dataGridView1.DataSource = Producto.ListaProductos();

            // Añadir una columna para el botón "Editar"
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "Editar";
            editButtonColumn.HeaderText = "Editar";
            editButtonColumn.Text = "Editar";
            editButtonColumn.UseColumnTextForButtonValue = true; // Esto asegura que el botón muestre texto
            dataGridView1.Columns.Add(editButtonColumn);

            // Añadir una columna para el botón "Eliminar"
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Eliminar";
            deleteButtonColumn.HeaderText = "Eliminar";
            deleteButtonColumn.Text = "Eliminar";
            deleteButtonColumn.UseColumnTextForButtonValue = true; // Esto asegura que el botón muestre texto
            dataGridView1.Columns.Add(deleteButtonColumn);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se haya hecho clic en una columna de botón
            if (e.RowIndex >= 0 && (e.ColumnIndex == dataGridView1.Columns["Editar"].Index || e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index))
            {
                // Obtener el producto correspondiente a la fila seleccionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string productoSku = row.Cells["SKU"].Value.ToString(); // Suponiendo que la columna "Sku" existe en la fuente de datos

                if (e.ColumnIndex == dataGridView1.Columns["Editar"].Index)
                {
                    // Acción para el botón "Editar"
                    
                    Producto p1 = new Producto();
                    p1.SKU = productoSku;
                    // Aquí puedes abrir un nuevo formulario para editar el producto
                    ModificarProducto m = new ModificarProducto(p1);
                    m.Show();
                }
                else if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index)
                {
                    // Acción para el botón "Eliminar"
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar el producto con SKU: " + productoSku + "?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // Aquí puedes llamar a una función para eliminar el producto de la base de datos
                        Producto p1 = new Producto();
                        p1.SKU = productoSku;
                        p1.Borrar();
                        // Recargar los datos después de eliminar
                        dataGridView1.DataSource = Producto.ListaProductos();
                    }
                }
            }
        }

        private void bCrearProducto_Click(object sender, EventArgs e)
        {
            CrearProducto p = new CrearProducto();
            p.Show();
            this.Hide();
        }

        private void bDashboard_Click(object sender, EventArgs e)
        {
            PantallaPrincipal l = new PantallaPrincipal();
            l.Show();

            this.Hide();
        }


        private void bCategorias_Click(object sender, EventArgs e)
        {
            ListarCategoria l = new ListarCategoria();
            l.Show();

            this.Hide();
        }

        private void bAtributos_Click(object sender, EventArgs e)
        {
            ListarAtributo l = new ListarAtributo();
            l.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Producto p = new Producto(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                MostrarProducto m = new MostrarProducto(p);
                m.Show();
                this.Hide();
            } catch (Exception )
            {
               //MessageBox.Show("Error: " + ex.Message);
            }
   
        }
    }
}
