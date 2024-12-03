using System;
using System.Collections.Generic;

namespace PIM
{
    public class Producto
    {
        private string sku;
        private string gtin;
        private string nombre;
        private string thumbnail;

        // Constructor para agregar un producto
        public Producto(string sku, string gtin, string nombre, string thumbnail)
        {
            Consulta c = new Consulta();
            c.Insert("INSERT INTO Producto VALUES ('" + sku + "', '" + gtin + "', '" + thumbnail + "', '" + nombre + "');");

            this.sku = sku;
            this.gtin = gtin;
            this.nombre = nombre;
            this.thumbnail = thumbnail;
        }

        public Producto()
        {
        }

        // Constructor con SKU
        public Producto(string sku)
        {
            this.sku = sku;
            Consulta c = new Consulta();
            // Consultar el producto por SKU
            string query = "SELECT GTIN, Thumbnail_url, nombre FROM Producto WHERE SKU = '" + sku + "'";

            Object[] a = c.Select(query)[0];

            this.gtin = (string)a[0];
            this.thumbnail = (string)a[1];
            this.nombre = (string)a[2];
        }

        // Método para listar todos los productos
        public static List<Producto> ListaProductos()
        {
            Consulta c = new Consulta();
            List<Producto> p = new List<Producto>();
            foreach (Object[] a in c.Select("SELECT * FROM Producto"))
            {
                Producto p1 = new Producto();
                p1.sku = (string)a[0];
                p1.gtin = (string)a[1];
                p1.nombre = (string)a[3];
                p1.thumbnail = (string)a[2];
                p.Add(p1);
            }
            return p;
        }

        // Método para borrar un producto
        public void Borrar()
        {
            try
            {
                // Primero eliminamos las relaciones con las categorías
                ProductoCategoria.BorrarProductoRelacionados(this);

                // Luego, eliminamos el producto en sí
                Consulta c = new Consulta();
                c.Delete("DELETE FROM Producto WHERE SKU='" + this.sku + "'");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el producto: " + ex.Message);
            }
        }

        // Propiedades
        public string SKU
        {
            get { return this.sku; }
            set
            {
                Consulta c = new Consulta();
                string consulta = "UPDATE Producto SET SKU = '" + value + "' WHERE SKU = '" + this.sku + "';";
                c.Update(consulta);
                this.sku = value;
            }
        }

        public string GTIN
        {
            get { return this.gtin; }
            set
            {
                Consulta c = new Consulta();
                string consulta = "UPDATE Producto SET GTIN = '" + value + "' WHERE SKU = '" + this.sku + "';";
                c.Update(consulta);
                this.gtin = value;
            }
        }

        public string Thumbnail
        {
            get { return this.thumbnail; }
            set
            {
                Consulta c = new Consulta();
                string consulta = "UPDATE Producto SET thumbnail = '" + value + "' WHERE SKU = '" + this.sku + "';";
                c.Update(consulta);
                this.thumbnail = value;
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                Consulta c = new Consulta();
                string consulta = "UPDATE Producto SET nombre = '" + value + "' WHERE SKU = '" + this.sku + "';";
                c.Update(consulta);
                this.nombre = value;
            }
        }
    }
}
