using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PIM
{
    public partial class Exportar : Form
    {
        // Propiedad pública para almacenar la categoría seleccionada
        public string CategoriaSeleccionada { get; set; }

        // Constructor que recibe la categoría seleccionada
        public Exportar(string categoriaSeleccionada)
        {
            InitializeComponent();
            // Asignamos la categoría recibida al campo de la propiedad
            CategoriaSeleccionada = categoriaSeleccionada;
        }

        // Evento Load del formulario
        private void Exportar_Load(object sender, EventArgs e)
        {

            // Obtener el nombre del primer objeto de la tabla Cuenta
            using (var context = new TiendaEntities1())
            {
                var primerCuenta = context.Cuenta.FirstOrDefault(); // Obtiene el primer objeto de la tabla Cuenta (si existe)
                if (primerCuenta != null)
                {
                    textBox1.Text = primerCuenta.Nombre;  // Asigna el nombre de la cuenta a textBox1
                }
                else
                {
                    textBox1.Text = "No hay cuentas disponibles";  // Mensaje si no hay registros
                }
            }

            // Asignar valores a los otros TextBox
            textBox2.Text = "GTIN";  // Valor para TextBox2
            textBox3.Text = "SKU";   // Valor para TextBox3

            // Rellenar ComboBox con True/False
            comboBox2.Items.Add("True");
            comboBox2.Items.Add("False");

            // Seleccionar el primer valor del ComboBox por defecto (opcional)
            comboBox2.SelectedIndex = 1; // Esto selecciona "True" por defecto

            // Rellenar ComboBox con valores de la tabla "atributos"
            RellenarComboBoxConValoresDeTabla();
        }

        // Método para rellenar el ComboBox con los valores de la tabla "atributos" usando Entity Framework
        private void RellenarComboBoxConValoresDeTabla()
        {
            try
            {
                using (var context = new TiendaEntities1())
                {
                    // Filtrar atributos con tipo numérico
                    var valores = context.Atributo
                        .Where(a => a.Tipo == "Entero" || a.Tipo == "Real" || a.Tipo == "decimal" || a.Tipo == "double")
                        .Select(a => a.Nombre)
                        .Distinct()
                        .ToList();

                    foreach (var valor in valores)
                    {
                        comboBox1.Items.Add(valor);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los valores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para crear un archivo CSV vacío al pulsar el botón "Button1"
        private void Button1_Click(object sender, EventArgs e)
        {
          try
    {
        // Comprobar si se ha seleccionado un atributo en el ComboBox
        if (comboBox1.SelectedItem == null)
        {
            MessageBox.Show("Por favor, seleccione un atributo para continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return; // No ejecutar el resto del código si no hay un atributo seleccionado
        }

        // Mostrar el cuadro de diálogo para guardar el archivo
        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        {
            saveFileDialog.Filter = "Archivos CSV (*.csv)|*.csv"; // Filtrar solo archivos CSV
            saveFileDialog.Title = "Guardar archivo CSV";
            saveFileDialog.FileName = "productos_categoria.csv"; // Nombre predeterminado

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string rutaArchivo = saveFileDialog.FileName;

                // Crear el archivo CSV vacío en la ubicación seleccionada
                using (StreamWriter writer = new StreamWriter(rutaArchivo))
                {
                    // Escribir el encabezado en el archivo CSV
                    writer.WriteLine("SKU, Title, FulfilledBy, AmazonSKU, Price, OfferPrice");

                    // Obtener el atributo seleccionado en el ComboBox
                    string atributoSeleccionado = comboBox1.SelectedItem.ToString();

                    // Obtener los productos de la categoría seleccionada
                    using (var context = new TiendaEntities1())
                    {
                        var productos = context.Producto
                                               .Where(p => p.Categoria.Any(c => c.Nombre == CategoriaSeleccionada))  // Filtrar productos por categoría
                                               .Select(p => new
                                               {
                                                   SKU = p.Sku,  // Asumo que "SKU" es un campo de la tabla Producto
                                                   Title = p.Nombre,  // Asumimos que el "Nombre" es el título del producto
                                                   GTIN = p.Gtin,  // Suponiendo que "GTIN" es un campo de la tabla Producto
                                                   ProductoId = p.Id  // Suponiendo que "Id" es la clave primaria del producto
                                               })
                                               .ToList();

                        // Obtener el nombre de la cuenta
                        string cuentaNombre = textBox1.Text;

                        // Si hay un atributo seleccionado, obtenemos su ID
                        int? atributoId = null;
                        if (!string.IsNullOrEmpty(atributoSeleccionado))
                        {
                            var atributo = context.Atributo
                                                .FirstOrDefault(a => a.Nombre == atributoSeleccionado);
                            atributoId = atributo.Id;
                        }

                        // Escribir cada producto en una nueva línea del CSV
                        foreach (var producto in productos)
                        {
                            // Obtener el valor del atributo para este producto
                            string priceValue = null;
                            if (atributoId.HasValue)
                            {
                                var valorAtributo = context.ValorAtributo
                                                           .FirstOrDefault(va => va.ProductoId == producto.ProductoId && va.AtributoId == atributoId.Value);

                                if (valorAtributo != null)
                                {
                                    priceValue = valorAtributo.Valor;
                                }
                                else
                                {
                                    // Si no se encuentra un valor, asignar un valor predeterminado
                                    priceValue = "Valor no disponible";  // O cualquier valor adecuado
                                }
                            }
                            else
                            {
                                // Maneja el caso cuando atributoId no tiene valor
                                priceValue = "Atributo no seleccionado";  // O cualquier valor predeterminado
                            }

                            // Si el precio es nulo, no escribir el producto en el archivo CSV
                            if (priceValue == "Valor no disponible" || priceValue == "Atributo no seleccionado")
                            {
                                MessageBox.Show("Product: " + producto + " was not inserted because atribute was null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue; // Saltar este producto
                            }

                            // Asegurarse de manejar correctamente comas, comillas dobles y otros caracteres especiales
                            string skuEscapado = EscaparCsvValue(producto.SKU.ToString());
                            string titleEscapado = EscaparCsvValue(producto.Title);
                            string fulfilledByEscapado = EscaparCsvValue(cuentaNombre);
                            string amazonSkuEscapado = EscaparCsvValue(producto.GTIN.ToString());
                            string priceEscapado = EscaparCsvValue(priceValue);  // Rellenar Price con el valor obtenido
                            string offerPriceEscapado = EscaparCsvValue("False");  // Se establece como "False" como se indicó

                            // Escribir el producto y sus detalles en el CSV
                            writer.WriteLine(skuEscapado + ", " + titleEscapado + ", " + fulfilledByEscapado + ", " +
                                             amazonSkuEscapado + ", " + priceEscapado + ", " + offerPriceEscapado);
                        }
                    }
                }

                // Informar al usuario que el archivo se ha creado con éxito
                MessageBox.Show("Archivo CSV creado con éxito en: " + rutaArchivo, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error al crear el archivo CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
        private string EscaparCsvValue(string value)
        {
            if (value.Contains("\""))
            {
                // Si el valor contiene comillas dobles, las duplicamos para escapar
                value = value.Replace("\"", "\"\"");
            }

            // Si el valor contiene comas o saltos de línea, lo rodeamos con comillas dobles
            if (value.Contains(",") || value.Contains("\n") || value.Contains("\r"))
            {
                value = "\"" + value + "\"";
            }

            return value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportarCV ex = new ExportarCV();
            ex.Show();
            this.Close();
        }
    }
}
