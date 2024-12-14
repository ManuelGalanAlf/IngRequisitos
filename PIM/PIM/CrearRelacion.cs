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
    public partial class CrearRelacion : Form
    {
        private List<Relacion> relaciones = new List<Relacion>();
        TiendaEntities1 BD = new TiendaEntities1();
        public CrearRelacion()
        {
            InitializeComponent();
        }

        private void CrearRelación_Load(object sender, EventArgs e)
        {
            using (TiendaEntities1 BD = new TiendaEntities1())
            {
                // Obtener los nombres de los productos como una lista de cadenas
                var productos = BD.Producto
                                 .Select(p => p.Nombre)
                                 .ToList();

                // Asignar la lista de nombres al ListBox1
                lbProducto1.Items.Clear();
                lbProducto1.DataSource = productos;

                // Asignar la lista de nombres al ListBox2
                lbProducto2.Items.Clear();
                lbProducto2.DataSource = new List<string>(productos);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
                           // Obtener los nombres de los productos seleccionados en ambos ListBox
                var producto1Nombre = lbProducto1.SelectedItem.ToString();
                var producto2Nombre = lbProducto2.SelectedItem.ToString();

                // Buscar los productos en la base de datos y obtener sus IDs
                var producto1 = BD.Producto.FirstOrDefault(x => x.Nombre.Equals(producto1Nombre));
                var producto2 = BD.Producto.FirstOrDefault(x => x.Nombre.Equals(producto2Nombre));

                // Crear una nueva relación y asignar el nuevo ID
                relaciones.Add(new Relacion
                {
                    NombreRelacion = tbNombre.Text,
                    Producto1 = producto1.Id,  // Asignar el ID del producto 1
                    Producto2 = producto2.Id   // Asignar el ID del producto 2
                });

                // Limpiar las selecciones de los ListBox
                lbProducto1.ClearSelected();
                lbProducto2.ClearSelected();

                // Hacer el TextBox readonly
                tbNombre.ReadOnly = true;

                // Mostrar mensaje de éxito
                MessageBox.Show("Relación añadida correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            bool todasRelacionesCreadas = true;  // Variable para rastrear si alguna relación no se crea

            foreach (var relacion in relaciones)
            {
                // Verificar si la relación ya existe en la base de datos
                var existeRelacion = BD.Relacion.Any(r =>
                    ((r.Producto1 == relacion.Producto1 && r.Producto2 == relacion.Producto2) ||
                    (r.Producto1 == relacion.Producto2 && r.Producto2 == relacion.Producto1)) &&
                    r.NombreRelacion == relacion.NombreRelacion); // Verificar ambos sentidos y nombre de relación

                if (existeRelacion)
                {
                    MessageBox.Show("La relación ya existe.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    todasRelacionesCreadas = false;  // Alguna relación no se creó
                    continue;  // Si ya existe, pasar a la siguiente relación
                }
                else
                {
                    BD.Relacion.Add(relacion);
                    MostrarRelacionesEnTerminal();
                    BD.SaveChanges();
                }
            }

            // Mostrar mensaje solo si todas las relaciones fueron creadas exitosamente
            if (todasRelacionesCreadas)
            {
                MessageBox.Show("Las relaciones han sido creadas con éxito.",
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Algunas relaciones no pudieron ser creadas debido a duplicados.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ListarRelacion listarRelacion = new ListarRelacion();
            listarRelacion.Show();
            this.Hide();            
        }

        private void MostrarRelacionesEnTerminal()
        {
            foreach (var relacion in relaciones)
            {
                // Usar el operador + para concatenar las cadenas
                string resultado = "";
                resultado = "Nombre de Relación: " + relacion.NombreRelacion + "\n";
                resultado = resultado + "Producto 1 ID: " + relacion.Producto1 + "\n";
                resultado = resultado + "Producto 2 ID: " + relacion.Producto2 + "\n";
                resultado = resultado + "ID Relacion: " + relacion.Id + "\n";


                // Mostrar el resultado completo en la terminal
                Console.WriteLine(resultado);
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

        private void bCancelar_Click(object sender, EventArgs e)
        {
            ListarRelacion listarRelacion = new ListarRelacion();
            listarRelacion.Show();
            this.Hide();
        }




    }
}
