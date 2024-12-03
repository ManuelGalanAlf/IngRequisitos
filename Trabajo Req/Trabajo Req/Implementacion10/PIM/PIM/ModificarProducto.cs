using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PIM
{
    public partial class ModificarProducto : Form
    {
        private Producto p;
        private Dictionary<string, string> valoresModificados = new Dictionary<string, string>(); // Para almacenar los valores modificados

        public ModificarProducto(Producto producto)
        {
            InitializeComponent();
            this.p = new Producto(producto.SKU);
        }

        private void LlenarDataGridViewConAtributos(Producto producto)
        {
            // Obtener la lista de todos los atributos del sistema
            List<Atributo> listaAtributosSistema = Atributo.ListaAtributos();

            // Obtener los valores asociados a los atributos del producto
            List<ValorAtributo> valoresAtributosProducto = ValorAtributo.ListarAtributoDeProducto(producto);

            // Crear un diccionario para acceder fácilmente a los valores asociados por nombre de atributo
            Dictionary<string, string> valoresPorAtributo = valoresAtributosProducto
                .ToDictionary(va => va.atributoNombre, va => va.valor);

            // Limpiar el DataGridView antes de llenarlo
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Asegurar que las columnas están definidas
            dataGridView1.Columns.Add("Nombre", "Nombre Atributo");
            dataGridView1.Columns.Add("Valor", "Valor Asociado");

            // Llenar las filas con los atributos y valores
            foreach (Atributo atributo in listaAtributosSistema)
            {
                string nombreAtributo = atributo.Nombre; // Nombre del atributo del sistema
                string valorAsociado = valoresPorAtributo.ContainsKey(nombreAtributo)
                    ? valoresPorAtributo[nombreAtributo]
                    : string.Empty; // Si no hay valor asociado, dejar vacío

                // Añadir la fila al DataGridView
                dataGridView1.Rows.Add(nombreAtributo, valorAsociado);
            }
        }

        private void ModificarProducto_Load(object sender, EventArgs e)
        {
            tbNombre.Text = p.Nombre;
            tbGtin.Text = p.GTIN;
            tbSku.Text = p.SKU;

            // Cargar todas las categorías disponibles del sistema
            List<Categoria> todasLasCategorias = Categoria.ListaCategorias();  // Obtiene todas las categorías del sistema

            // Establecer el DataSource del CheckedListBox con las categorías
            clbCategorias.DataSource = todasLasCategorias;
            clbCategorias.DisplayMember = "Nombre";  // Mostrar el nombre de la categoría en el CheckedListBox
            clbCategorias.ValueMember = "Nombre";   // Utilizar el nombre de la categoría para la selección

            // Obtener las categorías asociadas al producto
            List<string> categoriasProducto = ObtenerCategoriasAsociadas(p.SKU);

            // Marcar las categorías asociadas al producto
            for (int i = 0; i < clbCategorias.Items.Count; i++)
            {
                Categoria categoria = (Categoria)clbCategorias.Items[i];  // Obtenemos el objeto Categoria

                // Si el nombre de la categoría está en la lista de categorías asociadas al producto, marcarla
                if (categoriasProducto.Contains(categoria.Nombre))
                {
                    clbCategorias.SetItemChecked(i, true);  // Marcar la categoría asociada
                }
            }

            // Llenar los atributos del producto en el DataGridView
            LlenarDataGridViewConAtributos(p);

        }

        private List<string> ObtenerCategoriasAsociadas(string productoSku)
        {
            // Obtener todas las categorías asociadas a un producto específico
            Consulta c = new Consulta();
            string consulta = "SELECT categoria_nombre FROM ProductoCategoria WHERE producto_sku = '" + productoSku + "';";
            var resultado = c.Select(consulta);

            List<string> categorias = new List<string>();

            if (resultado != null && resultado.Count > 0)
            {
                foreach (var fila in resultado)
                {
                    string categoriaNombre = (string)fila[0]; // Nombre de la categoría
                    categorias.Add(categoriaNombre);
                }
            }

            return categorias;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool cambiosRealizados = false;

            // Verificar si los valores principales han sido modificados
            if (tbSku.Text != p.SKU)
            {
                p.SKU = tbSku.Text;
                cambiosRealizados = true;
            }

            if (tbNombre.Text != p.Nombre)
            {
                p.Nombre = tbNombre.Text;
                cambiosRealizados = true;
            }

            if (tbGtin.Text != p.GTIN)
            {
                p.GTIN = tbGtin.Text;
                cambiosRealizados = true;
            }

            // Actualizar las asociaciones producto-categoría
            List<string> categoriasSeleccionadas = clbCategorias.CheckedItems.Cast<Categoria>().Select(c => c.Nombre).ToList();
            List<string> categoriasActuales = ObtenerCategoriasAsociadas(p.SKU);

            // Determinar las categorías a eliminar (que ya no están marcadas)
            List<string> categoriasAEliminar = categoriasActuales.Except(categoriasSeleccionadas).ToList();

            // Determinar las categorías a agregar (que están marcadas pero no estaban antes)
            List<string> categoriasAAgregar = categoriasSeleccionadas.Except(categoriasActuales).ToList();

            // Eliminar asociaciones que ya no están marcadas
            foreach (string categoriaNombre in categoriasAEliminar)
            {
                Categoria categoria = new Categoria { Nombre = categoriaNombre };
                ProductoCategoria.Borrar(p, categoria);
                cambiosRealizados = true;
            }

            // Agregar nuevas asociaciones que han sido marcadas
            foreach (string categoriaNombre in categoriasAAgregar)
            {
                new ProductoCategoria(p.SKU, p.GTIN, categoriaNombre);
                cambiosRealizados = true;
            }


            // Procesar los cambios realizados en el DataGridView (atributos del producto)
            foreach (var item in valoresModificados)
            {
                string atributo = item.Key;
                string nuevoValor = item.Value;

                // Actualizar en la base de datos
                // ValorAtributo.ActualizarAtributo(producto.SKU, atributo, nuevoValor);

                cambiosRealizados = true;
            }

            // Mostrar un mensaje dependiendo si hubo o no cambios
            if (cambiosRealizados)
            {
                MessageBox.Show("Cambios realizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetearEstado();
            }
            else
            {
                MessageBox.Show("No se realizaron cambios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetearEstado()
        {
            // Refrescar los valores en los controles
            tbSku.Text = p.SKU;
            tbNombre.Text = p.Nombre;
            tbGtin.Text = p.GTIN;

            // Limpiar los valores modificados
            valoresModificados.Clear();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string atributo = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString(); // Nombre del atributo
                string nuevoValor = dataGridView1.Rows[e.RowIndex].Cells["Valor"].Value.ToString(); // Nuevo valor

                if (!valoresModificados.ContainsKey(atributo))
                {
                    valoresModificados.Add(atributo, nuevoValor);
                }
                else
                {
                    valoresModificados[atributo] = nuevoValor;
                }
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            // Restablecer los valores del DataGridView a su estado original
            dataGridView1.DataSource = ValorAtributo.ListarAtributoDeProducto(p);

            // Limpiar los valores modificados
            valoresModificados.Clear();

            // Cerrar el formulario
            this.Close();
        }


        private void bConfirmar_Click(object sender, EventArgs e)
        {
            bool cambiosRealizados = false;

            // Verificar si los valores principales han sido modificados
            if (tbSku.Text != p.SKU)
            {
                p.SKU = tbSku.Text;
                cambiosRealizados = true;
            }

            if (tbNombre.Text != p.Nombre)
            {
                p.Nombre = tbNombre.Text;
                cambiosRealizados = true;
            }

            if (tbGtin.Text != p.GTIN)
            {
                p.GTIN = tbGtin.Text;
                cambiosRealizados = true;
            }

            // Actualizar las asociaciones producto-categoría
            List<string> categoriasSeleccionadas = clbCategorias.CheckedItems.Cast<Categoria>().Select(c => c.Nombre).ToList();
            List<string> categoriasActuales = ObtenerCategoriasAsociadas(p.SKU);

            // Determinar las categorías a eliminar (que ya no están marcadas)
            List<string> categoriasAEliminar = categoriasActuales.Except(categoriasSeleccionadas).ToList();

            // Determinar las categorías a agregar (que están marcadas pero no estaban antes)
            List<string> categoriasAAgregar = categoriasSeleccionadas.Except(categoriasActuales).ToList();

            // Eliminar asociaciones que ya no están marcadas
            foreach (string categoriaNombre in categoriasAEliminar)
            {
                Categoria categoria = new Categoria(categoriaNombre);

                // Eliminar la relación de ProductoCategoria
                ProductoCategoria.Borrar(p, categoria);


                cambiosRealizados = true;
            }

            // Agregar nuevas asociaciones que han sido marcadas
            foreach (string categoriaNombre in categoriasAAgregar)
            {
                Categoria categoria = new Categoria(categoriaNombre);

                // Crear la nueva relación entre Producto y Categoria
                new ProductoCategoria(p.SKU, p.GTIN, categoriaNombre);

                // Incrementar el número de productos en la 
                ContarProductosPorConsulta(categoriaNombre);
                cambiosRealizados = true;
            }


            // Procesar los cambios realizados en el DataGridView (atributos del producto)
            foreach (var item in valoresModificados)
            {
                string atributo = item.Key;
                string nuevoValor = item.Value;

                // Crear un objeto ValorAtributo y actualizar su valor
                ValorAtributo valorAtributo = new ValorAtributo(p.SKU, p.GTIN, atributo, nuevoValor);
                valorAtributo.VALOR = nuevoValor; // Actualizar en la base de datos

                cambiosRealizados = true;
            }

            // Mostrar un mensaje dependiendo si hubo o no cambios
            if (cambiosRealizados)
            {
                MessageBox.Show("Cambios realizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetearEstado();
            }
            else
            {
                MessageBox.Show("No se realizaron cambios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void bCategorias_Click(object sender, EventArgs e)
        {
            ListarCategoria listarCategoria = new ListarCategoria();

            listarCategoria.Show();
            this.Hide();

        }
        public int ContarProductosPorConsulta(string consultaNombre)
        {
            // Crear una instancia de la clase que maneja las consultas a la base de datos
            Consulta c = new Consulta();
            // MessageBox.Show("El valor es " + consultaNombre);
            // Consulta SQL para contar los productos asociados con el nombre de la consulta
            string consulta = "SELECT COUNT(*) FROM PRODUCTOCATEGORIA WHERE CATEGORIANOMBRE = " + consultaNombre;


            // Ejecutar la consulta
            var resultado = c.Select(consulta);

            // Verificar que el resultado contiene datos
            if (resultado != null && resultado.Count > 0)
            {
                //MessageBox.Show("El valor es " + Convert.ToInt32(resultado[0][0]));
                // El resultado debería ser una lista con el primer valor como el conteo de productos
                return Convert.ToInt32(resultado[0][0]);
            }

            // Si no hay productos asociados, devolver 0
            return 0;
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

        private void bAtributos_Click(object sender, EventArgs e)
        {
            ListarAtributo listarAtributo = new ListarAtributo();

            listarAtributo.Show();
            this.Hide();
        }
    }
}