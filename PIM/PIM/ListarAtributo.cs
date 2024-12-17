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
        TiendaEntities1 bd = new TiendaEntities1();

        public ListarAtributo()
        {
            InitializeComponent();
        }

        private void ListarAtributo_Load(object sender, EventArgs e)
        {
             // Cargar los datos de la base de datos al DataGridView
            CargarDatos();

            // Agregar las columnas personalizadas si no existen
            AgregarColumnasPersonalizadas();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
        }

        private void CargarDatos()
        {
            // Obtener los atributos desde la base de datos
            var atributos = bd.Atributo.Select(a => new
            {
                Name = a.Nombre, // Nombre del atributo
                Type = a.Tipo      // Tipo del atributo
            }).ToList();

            // Establecer la fuente de datos del DataGridView
            dataGridView1.DataSource = atributos;
        }

        private void AgregarColumnasPersonalizadas()
        {
            // Verificar si ya existen las columnas "Editar" y "Eliminar"
            if (!dataGridView1.Columns.Contains("Edit"))
            {
                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    HeaderText = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true // Mostrar texto en el botón
                };
                dataGridView1.Columns.Add(editButtonColumn);
            }

            if (!dataGridView1.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true // Mostrar texto en el botón
                };
                dataGridView1.Columns.Add(deleteButtonColumn);
            }
        }

        private void RecargarDatos()
        {
            // Remover las columnas personalizadas para evitar duplicados
            foreach (var columnName in new[] { "Edit", "Delete" })
            {
                if (dataGridView1.Columns.Contains(columnName))
                {
                    dataGridView1.Columns.Remove(columnName);
                }
            }

            // Recargar los datos
            CargarDatos();

            // Volver a agregar las columnas personalizadas
            AgregarColumnasPersonalizadas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se hizo clic en una columna de botón
            if (e.RowIndex >= 0 && (e.ColumnIndex == dataGridView1.Columns["Edit"].Index || e.ColumnIndex == dataGridView1.Columns["Delete"].Index))
            {
                // Obtener el nombre del atributo de la fila seleccionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string atributoNombre = row.Cells["Name"].Value.ToString(); // Suponiendo que la columna "Nombre" existe

                if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
                {
                    // Acción para el botón "Editar"
                    var atributo = bd.Atributo.FirstOrDefault(a => a.Nombre == atributoNombre);
                    if (atributo != null)
                    {
                        ModificarAtributo modificarForm = new ModificarAtributo(atributo);
                        modificarForm.Show();
                        this.Close();
                    }
                }
                else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
                {
                    // Acción para el botón "Eliminar"
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to delete the attribute with name: " + atributoNombre + "?",
                        "Confirm delete",
                        MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        var atributo = bd.Atributo.FirstOrDefault(a => a.Nombre == atributoNombre);
                        if (atributo != null)
                        {
                            bd.Atributo.Remove(atributo); // Eliminar el atributo de la base de datos
                            bd.SaveChanges(); // Guardar cambios en la base de datos
                            RecargarDatos(); // Recargar los datos después de eliminar
                        }
                    }
                }
            }
        }

        private void bCrearAtributo_Click(object sender, EventArgs e)
        {

            CrearAtributo crearAtributo = new CrearAtributo();
            crearAtributo.Show();
            this.Hide();
        }

        private void bDashboard_Click(object sender, EventArgs e)
        {
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
            pantallaPrincipal.Show();
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

        private void bProductos_Click(object sender, EventArgs e)
        {
            ListarProducto listarProducto = new ListarProducto();
            listarProducto.Show();
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
