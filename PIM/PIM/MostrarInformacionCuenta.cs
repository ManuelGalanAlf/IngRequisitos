using System;
using System.IO; // Para calcular espacio en disco
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace PIM
{
    public partial class MostrarInformacionCuenta : Form
    {
        public MostrarInformacionCuenta()
        {
            InitializeComponent();
        }

        private void MostrarInformacionCuenta_Load(object sender, EventArgs e)
        {
            using (TiendaEntities1 BD = new TiendaEntities1())
            {
                // Asumiendo que solo hay una cuenta en la base de datos
                var cuenta = BD.Cuenta.FirstOrDefault(); // Obtener la primera cuenta de la base de datos

                if (cuenta != null)
                {
                    // Obtener el número de productos
                    var numeroProductos = BD.Producto.Count();
                    tbProductos.Text = numeroProductos.ToString() + "/100000";

                    tbNombre.Text = cuenta.Nombre;
                    // Obtener el número de categorías
                    var numeroCategorias = BD.Categoria.Count();
                    tbCategories.Text = numeroCategorias.ToString() + "/1000";

                    // Obtener el número de relaciones
                    var numeroRelaciones = BD.Relacion
                         .Select(r => r.NombreRelacion)
                         .Distinct()
                         .Count();
                    tbRelations.Text = numeroRelaciones.ToString() + "/10";

                    // Obtener el número de atributos
                    var numeroAtributos = BD.Atributo.Count();
                    tbAttributes.Text = numeroAtributos.ToString() + "/5";

                    // Obtener la fecha de creación de la cuenta
                    tbFechaCreacion.Text = cuenta.FechaCreacion.Value.ToString("dd/MM/yyyy");

                    // Calcular el espacio disponible (esto es un ejemplo de cómo obtener el espacio del disco)
                    tbEspacio.Text = "200 GB"; // Calcular espacio disponible en GB
                    // Verificar si hay una imagen guardada en la cuenta
                    if (cuenta.Imagen != null)
                    {
                        // Convertir el array de bytes a una imagen
                        using (MemoryStream ms = new MemoryStream(cuenta.Imagen))
                        {
                            pbImagen.Image = Image.FromStream(ms);
                            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage; // Ajustar la imagen al tamaño del PictureBox
                        }
                    }
                    else
                    {
                        pbImagen.Image = null; // Si no tiene imagen, borrar la imagen en el PictureBox
                    }
                }
                else
                {
                    MessageBox.Show("No account was found.");
                }

            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bExportar_Click(object sender, EventArgs e)
        {
            using (TiendaEntities1 BD = new TiendaEntities1())
            {
                var cuenta = BD.Cuenta.FirstOrDefault();

                if (cuenta != null)
                {
                    // Crear el objeto con los datos
                    var cuentaData = new
                    {
                        NombreCuenta = cuenta.Nombre,
                        FechaCreacion = cuenta.FechaCreacion.Value.ToString("dd/MM/yyyy"),
                        Productos = BD.Producto.Count(),
                        Categorias = BD.Categoria.Count(),
                        Relaciones = BD.Relacion.Select(r => r.NombreRelacion).Distinct().Count(),
                        Atributos = BD.Atributo.Count(),                       
                    };

                    // Convertir a JSON
                    string json = JsonConvert.SerializeObject(cuentaData, Formatting.Indented);

                    // Crear el diálogo para guardar archivo
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Archivos JSON (*.json)|*.json";
                        saveFileDialog.Title = "Guardar archivo JSON";
                        saveFileDialog.FileName = "CuentaData.json";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Guardar el archivo en la ubicación seleccionada
                            File.WriteAllText(saveFileDialog.FileName, json);
                            MessageBox.Show("Data exported successfully in: " + saveFileDialog.FileName);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No account was found.");
                }
            }
        }

        private void bDashboard_Click(object sender, EventArgs e)
        {
            PantallaPrincipal p = new PantallaPrincipal();
            p.Show();
            this.Hide();
        }

        private void bProductos_Click(object sender, EventArgs e)
        {
            ListarProducto p = new ListarProducto();
            p.Show();
            this.Hide();
        }

        private void bCategorias_Click(object sender, EventArgs e)
        {
            ListarCategoria p = new ListarCategoria();
            p.Show();
            this.Hide();
        }

        private void bAtributos_Click(object sender, EventArgs e)
        {
            ListarAtributo p = new ListarAtributo();
            p.Show();
            this.Hide();
        }

        private void bRelaciones_Click(object sender, EventArgs e)
        {
            ListarRelacion p = new ListarRelacion();
            p.Show();
            this.Hide();
        }

        private void bCuenta_Click(object sender, EventArgs e)
        {
            MostrarInformacionCuenta m = new MostrarInformacionCuenta();
            m.Show();
            this.Hide();
        }





        // Add image
        private void AddImage_Click(object sender, EventArgs e)
        {
            if (ofdImagen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Mostrar la imagen seleccionada en el PictureBox
                    pbImagen.Image = Image.FromFile(ofdImagen.FileName);
                    pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;

                    // Guardar la imagen en la base de datos
                    using (TiendaEntities1 BD = new TiendaEntities1())
                    {
                        var cuenta = BD.Cuenta.FirstOrDefault();

                        if (cuenta != null)
                        {
                            // Convertir la imagen seleccionada en un array de bytes
                            cuenta.Imagen = File.ReadAllBytes(ofdImagen.FileName);

                            // Guardar los cambios en la base de datos
                            BD.SaveChanges();
                            MessageBox.Show("Account image saved successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No account was found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
