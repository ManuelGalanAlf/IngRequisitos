using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace PIM
{
    public partial class MostrarProducto : Form
    {
        Producto producto;
        public MostrarProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
        }

        private void MostrarProducto_Load(object sender, EventArgs e)
        {
            if (producto == null)
            {
                MessageBox.Show("Invalid product");
                return;
            }

            using (TiendaEntities1 BD = new TiendaEntities1())
            {
                // Mostrar los datos básicos del producto
                tNombre.Text = producto.Nombre;
                tGtin.Text = producto.Gtin.ToString();
                tSKU.Text = producto.Sku.ToString();

                // Cargar y mostrar los atributos del producto en el DataGridView
                var atributos = BD.ValorAtributo
                                  .Where(va => va.ProductoId == producto.Id)
                                  .Select(va => new
                                  {
                                      va.Atributo.Nombre,
                                      va.Valor
                                  }).ToList();
                dataGridView1.DataSource = atributos;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Mostrar las categorías del producto en el ListBox
                lbCategorias.Items.Clear();
                if (producto.Categoria.Any())
                {
                    foreach (var categoria in producto.Categoria)
                    {
                        lbCategorias.Items.Add(categoria.Nombre);
                    }
                }
                else
                {
                    lbCategorias.Items.Add("It has no associated categories.");
                }

                // Cargar y mostrar el Thumbnail si está presente
                if (producto.Thumbnail != null && producto.Thumbnail.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(producto.Thumbnail))
                    {
                        pbThumbnail.Image = Image.FromStream(ms);  // Convertir los bytes a imagen y asignar al PictureBox
                        pbThumbnail.SizeMode = PictureBoxSizeMode.StretchImage;  // Ajustar la imagen al tamaño del PictureBox
                    }
                }
                else
                {
                    pbThumbnail.Image = null;  // Si no hay imagen, dejar el PictureBox vacío
                }
            }
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {

            // Confirmación antes de proceder a eliminar
            DialogResult confirmacion = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm delete",
                MessageBoxButtons.YesNo
            );

            if (confirmacion == DialogResult.Yes)
            {
                using (TiendaEntities1 BD = new TiendaEntities1())
                {
                    // Buscar el producto en la base de datos usando su SKU
                    var productoEliminar = BD.Producto.FirstOrDefault(p => p.Sku == producto.Sku);

                    if (productoEliminar != null)
                    {
                        // Eliminar las relaciones asociadas, si las hubiera
                        var valorAtributos = BD.ValorAtributo.Where(va => va.ProductoId == productoEliminar.Id).ToList();
                        foreach (var valorAtributo in valorAtributos)
                        {
                            var atributo = BD.Atributo.FirstOrDefault(a => a.Id == valorAtributo.AtributoId);
                            if (atributo != null)
                            {
                                atributo.NumeroProductos--;  // Decrementar el contador de productos relacionados
                            }
                        }

                        var categorias = BD.Categoria.Where(c => c.Producto.Any(p => p.Sku == productoEliminar.Sku)).ToList();
                        foreach (var categoria in categorias)
                        {
                            categoria.NumeroProductos--;  // Decrementar el contador de productos en la categoría
                        }

                        // Eliminar el producto de la base de datos
                        BD.Producto.Remove(productoEliminar);
                        BD.SaveChanges();

                        MessageBox.Show("Product removed successfully.");
                        this.Close();  // Cerrar el formulario actual después de eliminar el producto
                    }
                    else
                    {
                        MessageBox.Show("Product not found in the database.");
                    }
                }
            }
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            ModificarProducto m = new ModificarProducto(producto);
            m.Show();
            this.Close();
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
