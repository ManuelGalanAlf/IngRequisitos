using System;
using System.Collections.Generic;  // Para poder usar List<T>

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
            // Eliminar la relación entre el producto y la categoría
            Consulta c = new Consulta();
            string consultaEliminar = "DELETE FROM ProductoCategoria " +
                                      "WHERE producto_sku = '" + producto.SKU + "' " +
                                      "AND producto_gtin = '" + producto.GTIN + "' " +
                                      "AND categoria_nombre = '" + categoria.Nombre + "';";
            c.Delete(consultaEliminar);

            // Obtener el número actual de productos en la categoría
            string consultaObtenerNumeroProductos = "SELECT numero_de_productos FROM Categoria WHERE nombre = '" + categoria.Nombre.Replace("'", "''") + "';";
            var resultado = c.Select(consultaObtenerNumeroProductos);

            // Verificar si la consulta devolvió resultados
            if (resultado != null && resultado.Count > 0)
            {
                // Si hay resultados, acceder al número de productos
                int numeroDeProductos = (int)resultado[0][0];

                // Restar 1 al número de productos
                numeroDeProductos -= 1;

                // Actualizar el número de productos en la categoría
                string consultaActualizarNumeroProductos = "UPDATE Categoria SET numero_de_productos = " + numeroDeProductos +
                                                            " WHERE nombre = '" + categoria.Nombre.Replace("'", "''") + "';";
                c.Update(consultaActualizarNumeroProductos);
            }
            else
            {
                // Si no hay resultados, manejar el caso (por ejemplo, categoría no encontrada o error)
                Console.WriteLine("No se encontró la categoría o no tiene productos asociados.");
            }
        }

        // Método para borrar todos los productos relacionados a una categoría cuando se borra un producto
        public static void BorrarProductoRelacionados(Producto producto)
        {
            // Consultar las categorías a las que el producto está asociado
            Consulta c = new Consulta();
            string consultaCategorias = "SELECT categoria_nombre FROM ProductoCategoria WHERE producto_sku = '" + producto.SKU + "';";

            var categorias = c.Select(consultaCategorias);

            // Eliminar las relaciones para cada categoría
            foreach (var categoria in categorias)
            {
                string categoriaNombre = (string)categoria[0];
                Categoria cat = new Categoria { Nombre = categoriaNombre };
                Borrar(producto, cat);  // Llamar al método Borrar que también actualiza el número de productos
            }
        }

        // Método estático para obtener las categorías con el conteo de productos
        public static List<Tuple<string, int>> ListaProductoCategorias()
        {
            Consulta c = new Consulta();
            string consulta = "SELECT categoria_nombre, COUNT(*) FROM ProductoCategoria GROUP BY categoria_nombre;";

            List<Tuple<string, int>> categoriasConProductos = new List<Tuple<string, int>>();

            // Ejecutar la consulta
            var resultado = c.Select(consulta);

            // Verificar que hay resultados
            if (resultado != null && resultado.Count > 0)
            {
                foreach (var fila in resultado)
                {
                    string categoriaNombre = (string)fila[0]; // Primer columna: nombre de la categoría
                    int cantidadProductos = Convert.ToInt32(fila[1]); // Segunda columna: cantidad de productos

                    // Añadir la tupla (nombre de la categoría, número de productos) a la lista
                    categoriasConProductos.Add(new Tuple<string, int>(categoriaNombre, cantidadProductos));
                }
            }

            return categoriasConProductos;
        }
    }
}
