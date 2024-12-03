using System;
using System.Collections.Generic; // Para trabajar con List<T>

namespace PIM
{
    public class ProductoCategoria
    {
        private string productoSku;
        private string productoGtin;
        private string categoriaNombre;

        // Constructor para agregar una relación Producto-Categoría
        public ProductoCategoria(string productoSku, string productoGtin, string categoriaNombre)
        {
            this.productoSku = productoSku;
            this.productoGtin = productoGtin;
            this.categoriaNombre = categoriaNombre;

            // Incrementar el número de productos en la categoría
            Categoria categoria = new Categoria { Nombre = categoriaNombre };
            categoria.NumeroProductos += 1;

            // Insertar la relación en la base de datos
            Consulta c = new Consulta();
            string consultaInsertar = "INSERT INTO ProductoCategoria (producto_sku, producto_gtin, categoria_nombre) " +
                                      "VALUES ('" + productoSku.Replace("'", "''") + "', '" + productoGtin.Replace("'", "''") + "', '" + categoriaNombre.Replace("'", "''") + "');";
            c.Insert(consultaInsertar);
        }

        // Método para borrar la relación entre el producto y la categoría
        public static void Borrar(Producto producto, Categoria categoria)
        {
            Consulta c = new Consulta();

            // Eliminar la relación entre el producto y la categoría
            string consultaEliminar = "DELETE FROM ProductoCategoria " +
                                      "WHERE producto_sku = '" + producto.SKU.Replace("'", "''") + "' " +
                                      "AND producto_gtin = '" + producto.GTIN.Replace("'", "''") + "' " +
                                      "AND categoria_nombre = '" + categoria.Nombre.Replace("'", "''") + "';";

            c.Delete(consultaEliminar);

            // Ahora actualizamos el número de productos en la categoría
            try
            {
                // Obtener el número actual de productos en la categoría desde la base de datos
                string consultaContarProductos = "SELECT COUNT(*) FROM ProductoCategoria WHERE categoria_nombre = '" + categoria.Nombre.Replace("'", "''") + "';";
                int nuevoNumeroProductos = (int)c.Select(consultaContarProductos)[0][0];

                // Actualizamos la propiedad NumeroProductos de la categoría
                categoria.NumeroProductos = nuevoNumeroProductos;

                // Verificamos si el valor de NumeroProductos es negativo y lo corregimos
                if (categoria.NumeroProductos < 0)
                {
                    categoria.NumeroProductos = 0; // No debe ser negativo
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el número de productos en la categoría: " + ex.Message);
            }
        }

        // Método para borrar todas las relaciones de un producto con categorías
        public static void BorrarProductoRelacionados(Producto producto)
        {
            Consulta c = new Consulta();

            // Consultar las categorías asociadas al producto
            string consultaCategorias = "SELECT categoria_nombre FROM ProductoCategoria WHERE producto_sku = '" + producto.SKU.Replace("'", "''") + "';";
            var categorias = c.Select(consultaCategorias);

            // Eliminar las relaciones para cada categoría
            foreach (var categoria in categorias)
            {
                string categoriaNombre = (string)categoria[0];
                Categoria cat = new Categoria { Nombre = categoriaNombre };
                Borrar(producto, cat);
            }
        }

        // Método para listar categorías con el conteo de productos
        public static List<Tuple<string, int>> ListaProductoCategorias()
        {
            Consulta c = new Consulta();
            string consulta = "SELECT categoria_nombre, COUNT(*) FROM ProductoCategoria GROUP BY categoria_nombre;";

            List<Tuple<string, int>> categoriasConProductos = new List<Tuple<string, int>>();

            // Ejecutar la consulta
            var resultado = c.Select(consulta);

            // Procesar los resultados
            if (resultado != null && resultado.Count > 0)
            {
                foreach (var fila in resultado)
                {
                    string categoriaNombre = (string)fila[0];
                    int cantidadProductos = Convert.ToInt32(fila[1]);
                    categoriasConProductos.Add(new Tuple<string, int>(categoriaNombre, cantidadProductos));
                }
            }

            return categoriasConProductos;
        }
    }
}