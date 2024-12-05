using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM
{
    public partial class ListarCategoria : Form
    {
        public ListarCategoria()
        {
            InitializeComponent();
        }

        private void ListarCategoria_Load(object sender, EventArgs e)
        {
            // Configurar el DataGridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            
            // Cargar las categorías
            dataGridView1.DataSource = Categoria.ListaCategorias();
            MostrarNombresColumnas();
           
            // Añadir botones "Editar" y "Eliminar"
            if (!dataGridView1.Columns.Contains("Editar"))
            {
                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Editar",
                    HeaderText = "Editar",
                    Text = "Editar",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(editButtonColumn);
            }

            if (!dataGridView1.Columns.Contains("Eliminar"))
            {
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Eliminar",
                    HeaderText = "Eliminar",
                    Text = "Eliminar",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(deleteButtonColumn);
            }
        }

        private void MostrarNombresColumnas()
        {
            Console.WriteLine("Nombres de las columnas:");
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                Console.WriteLine("Nombre: " + column.Name + ", Encabezado: " + column.HeaderText);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se haya hecho clic en una columna de botón
            if (e.RowIndex >= 0 && (e.ColumnIndex == dataGridView1.Columns["Editar"].Index || e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index))
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Obtener el nombre de la categoría desde la columna "Categoria"
                string categoriaNombre = row.Cells["Nombre"].Value.ToString(); // Suponiendo que la columna "Categoria" existe en la fuente de datos
                
                if (e.ColumnIndex == dataGridView1.Columns["Editar"].Index)
                {
                    // Acción para el botón "Editar"
                    Categoria c = new Categoria { Nombre = categoriaNombre};

                    ModificarCategoria m = new ModificarCategoria(c);
                    this.Close();
                    m.Show();
                    // Aquí puedes abrir un nuevo formulario para editar la categoría
                }
                else if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index)
                {
                    // Mostrar mensaje de confirmación para eliminar la categoría
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar la categoría con nombre: " + categoriaNombre + "?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // Eliminar la categoría
                        Categoria p1 = new Categoria();
                        p1.Borrar(categoriaNombre);
                        // Recargar los datos después de eliminar
                        dataGridView1.DataSource = Categoria.ListaCategorias();

                        MessageBox.Show("Categoría eliminada correctamente.");
                    }
                }
            }
        }

        private void bProductos_Click(object sender, EventArgs e)
        {
            ListarProducto l = new ListarProducto();
            l.Show();
            this.Hide();
        }

        private void bAtributos_Click(object sender, EventArgs e)
        {
            ListarAtributo l = new ListarAtributo();
            l.Show();
            this.Hide();
        }

        private void bDashboard_Click(object sender, EventArgs e)
        {
            PantallaPrincipal p = new PantallaPrincipal();
            p.Show();
            this.Hide();
        }

        private void bCategorias_Click(object sender, EventArgs e)
        {
            ListarCategoria l = new ListarCategoria();
            l.Show();
            this.Hide();
        }

        private void bCrearProducto_Click(object sender, EventArgs e)
        {
            CrearCategoria c = new CrearCategoria();
            c.Show();
            this.Hide();
        }
    }
}
