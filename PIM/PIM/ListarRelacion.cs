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
    public partial class ListarRelacion : Form
    {
        public ListarRelacion()
        {
            InitializeComponent();
        }

        private void ListarRelacion_Load(object sender, EventArgs e)
        {
            CargarRelaciones();

            // Agregar los botones de "Editar" y "Borrar" si no existen
            AgregarBotonesDataGridView();

            // Vincular el evento para manejar el clic en las celdas
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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

        }

        private void BorrarRelacion(int idRelacion)
        {
            using (TiendaEntities1 BD = new TiendaEntities1())
            {
                // Buscar la relación por su ID para obtener el nombre
                var relacion = BD.Relacion.FirstOrDefault(r => r.Id == idRelacion);

                if (relacion != null)
                {
                    string nombreRelacion = relacion.NombreRelacion;

                    // Confirmar con el usuario antes de borrar
                    DialogResult confirmacion = MessageBox.Show(
                        string.Format("Are you sure you want to delete all relationships with the name '{0}'?", nombreRelacion),
                        "Confirm",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmacion == DialogResult.Yes)
                    {
                        // Obtener todas las relaciones con el mismo nombre
                        var relacionesAgrupadas = BD.Relacion.Where(r => r.NombreRelacion == nombreRelacion).ToList();

                        if (relacionesAgrupadas.Any())
                        {
                            // Eliminar todas las relaciones agrupadas
                            BD.Relacion.RemoveRange(relacionesAgrupadas);
                            BD.SaveChanges();

                            MessageBox.Show("Relationships deleted successfully.");
                            CargarRelaciones(); // Actualizar el DataGridView después de borrar
                        }
                        else
                        {
                            MessageBox.Show("No relationships were found with that name.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Relationship not found.");
                }
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el índice de fila y columna sean válidos
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && e.ColumnIndex >= 0)
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                if (columnName == "Edit" || columnName == "Delete")
                {
                    var selectedRow = dataGridView1.Rows[e.RowIndex];

                    // Verificar si la fila tiene datos válidos en la columna "Id"
                    if (selectedRow.Cells["Id"].Value != null)
                    {
                        int idRelacion = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                        if (columnName == "Edit")
                        {
                            EditarRelacion(idRelacion);
                        }
                        else
                        {
                            BorrarRelacion(idRelacion);
                        }
                    }
                }
            }
        }


        private void EditarRelacion(int idRelacion)
        {
            using (TiendaEntities1 BD = new TiendaEntities1())
            {
                var relacion = BD.Relacion.FirstOrDefault(r => r.Id == idRelacion);

                if (relacion != null)
                {
                    var editarForm = new ModificarRelacion(relacion);
                    editarForm.ShowDialog();
                    this.Close();
                    CargarRelaciones();
                }
                else
                {
                    MessageBox.Show("Relationship not found.");
                }
            }

        }

        private void CargarRelaciones()
        {
            using (TiendaEntities1 BD = new TiendaEntities1())
            {
                // Verifica que la colección 'Relacion' no sea null
                if (BD.Relacion == null)
                {
                    MessageBox.Show("The relationships in the database could not be accessed.");
                    return; // Detiene el proceso si la colección es null
                }

                try
                {
                    // Agrupar las relaciones por NombreRelacion para evitar duplicados
                    var relaciones = (from r in BD.Relacion
                                      group r by r.NombreRelacion into g
                                      select new
                                      {
                                          Id = g.FirstOrDefault().Id,  // Incluir el Id de la relación
                                          NombreRelacion = g.Key,      // Nombre único de la relación
                                      }).ToList();

                    // Verificar si hay resultados
                    if (relaciones == null || !relaciones.Any())
                    {
                        MessageBox.Show("No relationships were found.");
                        return; // Si no hay relaciones, muestra un mensaje y detiene el proceso
                    }

                    // Establecer los datos del DataGridView
                    dataGridView1.DataSource = relaciones;

                    // Verificar que la columna 'Id' existe antes de intentar ocultarla
                    if (dataGridView1.Columns.Contains("Id"))
                    {
                        dataGridView1.Columns["Id"].Visible = false;  // Puedes ocultarla si lo deseas
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading relations: " + ex.Message);
                }
            }
        }


        private void bCrearRelacion_Click(object sender, EventArgs e)
        {
            CrearRelacion crearRelacion = new CrearRelacion();
            crearRelacion.Show();
            this.Hide();
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
