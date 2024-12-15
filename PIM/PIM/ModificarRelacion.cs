using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PIM
{
    public partial class ModificarRelacion : Form
    {
        Relacion relacion;

        public ModificarRelacion(Relacion relacion)
        {
            InitializeComponent();
            this.relacion = relacion;
        }

        private void ModificarRelacion_Load(object sender, EventArgs e)
        {
            tbNombre.Text = relacion.NombreRelacion;
            tbNombre.Enabled = false;  // Desactivar la edición del nombre de la relación
            CargarRelaciones();
            CargarProductos();  // Cargar productos en los ListBox
        }

        private void CargarProductos()
        {
            using (TiendaEntities1 BD = new TiendaEntities1())
            {
                // Obtener los nombres de los productos como una lista de cadenas
                var productos = BD.Producto
                                 .Select(p => p.Nombre)
                                 .ToList();

                // Asignar la lista de productos a los ListBox
                lbProducto1.Items.Clear();
                lbProducto1.DataSource = productos;

                lbProducto2.Items.Clear();
                lbProducto2.DataSource = new List<string>(productos);  // Aseguramos que sean independientes
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && e.ColumnIndex >= 0)
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                // Verificar si el botón pulsado es "Borrar"
                if (columnName == "Borrar")
                {
                    var selectedRow = dataGridView1.Rows[e.RowIndex];
                    int idRelacion = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    BorrarRelacion(idRelacion);
                }
            }
        }

        private void BorrarRelacion(int idRelacion)
        {
            using (TiendaEntities1 BD = new TiendaEntities1())
            {
                var relacion = BD.Relacion.FirstOrDefault(r => r.Id == idRelacion);

                if (relacion != null)
                {
                    DialogResult confirmacion = MessageBox.Show(
                        string.Format("¿Está seguro de que desea borrar la relación '{0}'?", relacion.NombreRelacion),
                        "Confirmar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmacion == DialogResult.Yes)
                    {
                        BD.Relacion.Remove(relacion);
                        BD.SaveChanges();
                        MessageBox.Show("Relación borrada correctamente.");
                        CargarRelaciones(); // Actualizar el DataGridView
                    }
                }
                else
                {
                    MessageBox.Show("Relación no encontrada.");
                }
            }
        }

        private void CargarRelaciones()
        {
            using (TiendaEntities1 BD = new TiendaEntities1())
            {
                if (BD.Relacion == null)
                {
                    MessageBox.Show("No se pudo acceder a las relaciones en la base de datos.");
                    return;
                }

                try
                {
                    var relaciones = from r in BD.Relacion
                                     join p1 in BD.Producto on r.Producto1 equals p1.Id
                                     join p2 in BD.Producto on r.Producto2 equals p2.Id
                                     where r.NombreRelacion == relacion.NombreRelacion
                                     select new
                                     {
                                         r.Id,
                                         Producto1 = p1.Nombre,
                                         Producto2 = p2.Nombre
                                     };

                    if (!relaciones.Any())
                    {
                        MessageBox.Show("No se encontraron relaciones con ese nombre.");
                        return;
                    }

                    var listaRelaciones = relaciones.ToList();
                    dataGridView1.DataSource = listaRelaciones;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (!dataGridView1.Columns.Contains("Borrar"))
                    {
                        DataGridViewButtonColumn btnBorrar = new DataGridViewButtonColumn
                        {
                            Name = "Borrar",
                            Text = "Borrar",
                            UseColumnTextForButtonValue = true
                        };
                        dataGridView1.Columns.Add(btnBorrar);
                    }

                    if (dataGridView1.Columns.Contains("Id"))
                    {
                        dataGridView1.Columns["Id"].Visible = false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las relaciones: " + ex.Message);
                }
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            // Obtener los nombres de los productos seleccionados en ambos ListBox
            var producto1Nombre = lbProducto1.SelectedItem.ToString();
            var producto2Nombre = lbProducto2.SelectedItem.ToString();

            using (TiendaEntities1 BD = new TiendaEntities1())
            {
                // Buscar los productos en la base de datos y obtener sus IDs
                var producto1 = BD.Producto.FirstOrDefault(x => x.Nombre.Equals(producto1Nombre));
                var producto2 = BD.Producto.FirstOrDefault(x => x.Nombre.Equals(producto2Nombre));

                // Crear una nueva relación y asignar el nuevo ID
                var nuevaRelacion = new Relacion
                {
                    NombreRelacion = relacion.NombreRelacion,  // Usar el nombre de la relación actual
                    Producto1 = producto1.Id,  // Asignar el ID del producto 1
                    Producto2 = producto2.Id   // Asignar el ID del producto 2
                };

                // Agregar la nueva relación a la base de datos
                BD.Relacion.Add(nuevaRelacion);
                BD.SaveChanges();

                MessageBox.Show("Relación añadida correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarRelaciones(); // Actualizar el DataGridView con la nueva relación
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

        private void bRelaciones_Click(object sender, EventArgs e)
        {
            ListarRelacion listarRelacion = new ListarRelacion();
            listarRelacion.Show();
            this.Hide();
        }

        private void bVovler_Click(object sender, EventArgs e)
        {
            ListarRelacion listarRelacion = new ListarRelacion();
            listarRelacion.Show();
            this.Hide();
        }
    }
}
