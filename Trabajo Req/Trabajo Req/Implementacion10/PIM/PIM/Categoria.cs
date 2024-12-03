using System;
using System.Collections.Generic;
using System.Data;

namespace PIM
{
    public class Categoria
    {
        private string nombre; // Clave primaria única
        private int numeroProductos; // Nuevo atributo para almacenar el número de productos

        // Constructor para crear una nueva categoría
        public Categoria(string nombre)
        {
            // Inserción en la base de datos
            Consulta c = new Consulta();
            string consulta = "INSERT INTO Categoria (nombre, numero_de_productos) VALUES ('" + nombre + "', 0);";
            c.Insert(consulta);

            this.nombre = nombre;
            this.numeroProductos = 0; // Inicializamos en 0
        }

        // Constructor vacío
        public Categoria()
        {
        }

        // Método para obtener una lista de categorías
        public static List<Categoria> ListaCategorias()
        {
            Consulta c = new Consulta();
            List<Categoria> categorias = new List<Categoria>();
            foreach (Object[] a in c.Select("SELECT * FROM Categoria"))
            {
                Categoria categoria = new Categoria();
                categoria.nombre = (string)a[0];
                categoria.numeroProductos = Convert.ToInt32(a[1]); // Asumiendo que el número de productos está en la segunda columna
                categorias.Add(categoria);
            }
            return categorias;
        }

        // Propiedad Nombre (Clave primaria)
        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                Consulta c = new Consulta();
                string consulta = "UPDATE Categoria SET nombre = '" + value + "' WHERE nombre = '" + this.nombre + "';";
                c.Update(consulta);
                this.nombre = value;
            }
        }

        // Propiedad NumeroProductos
        public int NumeroProductos
        {
            get { return this.numeroProductos; }
            set
            {
                Consulta c = new Consulta();
                string consulta = "UPDATE Categoria SET numero_de_productos = " + value + " WHERE nombre = '" + this.nombre + "';";
                c.Update(consulta);
                this.numeroProductos = value;
            }
        }

        public override string ToString()
        {
            return this.nombre; // Mostrar solo el nombre de la categoría
        }

        // Método para borrar la categoría y sus relaciones
        public void Borrar(string n)
        {
            Consulta c = new Consulta();
            string consultaRelaciones = "DELETE FROM ProductoCategoria WHERE categoria_nombre = '" + n + "';";
            c.Delete(consultaRelaciones);

            Consulta c1 = new Consulta();
            string consulta = "DELETE FROM Categoria WHERE nombre = '" + n + "';";
            c1.Delete(consulta);
            this.nombre = null;
            this.numeroProductos = 0;
        }
    }
}
