﻿using System;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.IO;
using System.Data.Entity.Infrastructure;

namespace PIM
{
    public partial class CrearProducto : Form
    {
        TiendaEntities1 bd = new TiendaEntities1();
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
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Value", typeof(string));

            // Añadir datos a la tabla
            foreach (var item in data)
            {
                dataTable.Rows.Add(item.Id, item.Nombre, item.Valor);
            }

            // Asignar la tabla al DataGridView
            dataGridView1.DataSource = dataTable;

            // Ocultar la columna "Id"
            dataGridView1.Columns["Id"].Visible = false;

            // Permitir edición solo en la columna "Valor"
            dataGridView1.Columns["Value"].ReadOnly = false;
            dataGridView1.Columns["Name"].ReadOnly = true; // Opcional, para evitar editar "Tipo"
            dataGridView1.AllowUserToAddRows = false;

            // Cargar las categorías en el CheckedListBox
            foreach (Categoria c in BD.Categoria)
            {
                clbCategorias.Items.Add(c.Nombre);
            }
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            if (bd.Producto.Count() >= 100000)
            {
                MessageBox.Show("Exceeded products limit (100000)");
                return;
            }
            try
            {
                TiendaEntities1 BD = new TiendaEntities1();
                string SKU = tbSku.Text;
                if (String.IsNullOrEmpty(SKU))
                {
                    MessageBox.Show("SKU is mandatory");
                    return;
                }
                string GTIN = tbGtin.Text;

                // Validación de GTIN para asegurarse que sea un número de exactamente 13 dígitos
                if (String.IsNullOrEmpty(GTIN) || GTIN.Length != 13 || !GTIN.All(char.IsDigit))
                {
                    MessageBox.Show("GTIN must be a 13 digit number.");
                    return;
                }

                string NOMBRE = tbNombre.Text;
                if (String.IsNullOrEmpty(NOMBRE))
                {
                    MessageBox.Show("Name is mandatory");
                    return;
                }

                Producto p = new Producto();
                p.Sku = int.Parse(SKU);
                p.Gtin = long.Parse(GTIN);  // Asumimos que GTIN se maneja como un número largo (long)
                p.Nombre = NOMBRE;
                p.FechaCreacion = DateTime.Today;

                // Aquí se guarda la imagen en formato de byte[]
                if (ofd_Thumbnail.FileName != "")
                {
                    // Convertir la imagen seleccionada en un array de bytes
                    byte[] imageBytes = File.ReadAllBytes(ofd_Thumbnail.FileName);
                    p.Thumbnail = imageBytes;  // Asignar el array de bytes al campo Thumbnail

                    // Mostrar la imagen en el PictureBox
                    pbThumbnail.Image = Image.FromFile(ofd_Thumbnail.FileName);  // Cargar la imagen

                    // Ajustar la imagen al tamaño del PictureBox
                    pbThumbnail.SizeMode = PictureBoxSizeMode.StretchImage;  // Establecer el ajuste automático de la imagen
                }

                BD.Producto.Add(p);
                BD.SaveChanges();  // Guardar el producto

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var valorCelda = row.Cells["Value"].Value;
                        if (valorCelda != null && valorCelda.ToString() != "")
                        {
                            ValorAtributo nuevoValorAtributo = new ValorAtributo
                            {
                                ProductoId = p.Id,
                                AtributoId = (int)row.Cells["Id"].Value,
                                Valor = (string)valorCelda
                            };
                            BD.ValorAtributo.Add(nuevoValorAtributo);

                            Atributo atributo = BD.Atributo.FirstOrDefault(a => a.Id == nuevoValorAtributo.AtributoId);
                            if (atributo != null)
                            {
                                atributo.NumeroProductos = atributo.NumeroProductos + 1;
                            }

                            BD.SaveChanges();  // Guardar los valores de atributo
                        }
                    }
                }

                foreach (string item in clbCategorias.CheckedItems)
                {
                    var categoria = BD.Categoria.FirstOrDefault(c => c.Nombre == item);
                    if (categoria != null)
                    {
                        p.Categoria.Add(categoria);
                        categoria.NumeroProductos = categoria.NumeroProductos + 1;
                    }
                }

                BD.SaveChanges();  // Guardar los cambios de las categorías

                MessageBox.Show("Product created successfully");

                ListarProducto listarProducto = new ListarProducto();
                listarProducto.Show();
                this.Close();
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show("Database error " + dbEx.Message);
                // Puedes inspeccionar más detalles con dbEx.InnerException si es necesario
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

        private void bThumbnail_Click(object sender, EventArgs e)
        {
            if (ofd_Thumbnail.ShowDialog() == DialogResult.OK)
            {
                pbThumbnail.Image = Image.FromFile(ofd_Thumbnail.FileName);

                // Ajustar la imagen al tamaño del PictureBox
                pbThumbnail.SizeMode = PictureBoxSizeMode.StretchImage;  // Establecer el ajuste automático de la imagen
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

        private void bCrearRelacion_Click(object sender, EventArgs e)
        {
            ListarRelacion listarRelacion = new ListarRelacion();
            listarRelacion.Show();
            this.Hide();
        }

        private void bRelaciones_Click(object sender, EventArgs e)
        {
            ListarRelacion listarRelacion = new ListarRelacion();
            listarRelacion.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bCuenta_Click(object sender, EventArgs e)
        {
            MostrarInformacionCuenta m = new MostrarInformacionCuenta();
            m.Show();
            this.Hide();
        }
    }
}
