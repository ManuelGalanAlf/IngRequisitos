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
    public partial class ListarAtributo : Form
    {
        public ListarAtributo()
        {
            InitializeComponent();
        }

        private void ListarAtributo_Load(object sender, EventArgs e)
        {
            // Establecer los datos de la base de datos como fuente del DataGridView
            dataGridView1.DataSource = Atributo.ListaAtributos();

            // Añadir las columnas de "Editar" y "Eliminar" solo si no existen
            AgregarColumnasPersonalizadas();
        }

        private void AgregarColumnasPersonalizadas()
        {
            // Comprobar si las columnas ya están presentes
            if (!dataGridView1.Columns.Contains("Editar"))
            {
                // Añadir una columna para el botón "Editar"
                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                editButtonColumn.Name = "Editar";
                editButtonColumn.HeaderText = "Editar";
                editButtonColumn.Text = "Editar";
                editButtonColumn.UseColumnTextForButtonValue = true; // Esto asegura que el botón muestre texto
                dataGridView1.Columns.Add(editButtonColumn);
            }

            if (!dataGridView1.Columns.Contains("Eliminar"))
            {
                // Añadir una columna para el botón "Eliminar"
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "Eliminar";
                deleteButtonColumn.HeaderText = "Eliminar";
                deleteButtonColumn.Text = "Eliminar";
                deleteButtonColumn.UseColumnTextForButtonValue = true; // Esto asegura que el botón muestre texto
                dataGridView1.Columns.Add(deleteButtonColumn);
            }
        }

        private void RecargarDatos()
        {
            // Limpiar columnas personalizadas para evitar duplicados
            foreach (var columnName in new[] { "Editar", "Eliminar" })
            {
                if (dataGridView1.Columns.Contains(columnName))
                {
                    dataGridView1.Columns.Remove(columnName);
                }
            }

            // Recargar datos
            dataGridView1.DataSource = null; // Limpiar fuente de datos
            dataGridView1.DataSource = Atributo.ListaAtributos(); // Recargar datos

            // Volver a agregar las columnas personalizadas
            AgregarColumnasPersonalizadas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se haya hecho clic en una columna de botón
            if (e.RowIndex >= 0 && (e.ColumnIndex == dataGridView1.Columns["Editar"].Index || e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index))
            {
                // Obtener el atributo correspondiente a la fila seleccionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string atributoNombre = row.Cells["Nombre"].Value.ToString(); // Suponiendo que la columna "Nombre" existe en la fuente de datos

                if (e.ColumnIndex == dataGridView1.Columns["Editar"].Index)
                {
                    // Acción para el botón "Editar"
                    Atributo a1 = new Atributo { Nombre = atributoNombre };
                    ModificarAtributo m = new ModificarAtributo(a1);
                    this.Close();
                    m.Show();
                }
                else if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index)
                {
                    // Acción para el botón "Eliminar"
                    DialogResult result = MessageBox.Show(
                        "¿Estás seguro de que deseas eliminar el atributo con nombre: " + atributoNombre + "?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        // Eliminar el atributo de la base de datos
                        Atributo a1 = new Atributo();
                        a1.Nombre = atributoNombre;
                        a1.Borrar();

                        // Recargar los datos después de eliminar
                        RecargarDatos();
                    }
                }
            }
        }

        private void bCrearAtributo_Click(object sender, EventArgs e)
        {
            CrearAtributo c = new CrearAtributo();
            c.Show();
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

        private void bProductos_Click(object sender, EventArgs e)
        {
            ListarProducto l = new ListarProducto();
            l.Show();
            this.Hide();
        }
    }
}
