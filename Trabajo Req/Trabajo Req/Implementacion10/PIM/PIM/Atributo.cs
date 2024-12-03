using System;
using System.Collections.Generic;

namespace PIM
{
    // Definición del Enum TipoAtributo
    public enum TipoAtributo
    {
        Cadena,    // Representa un tipo de dato cadena
        Real,      // Representa un tipo de dato decimal
        Entero,    // Representa un tipo de dato entero
    }

    public class Atributo
    {
        private string nombre; // Clave primaria única
        private TipoAtributo tipo; // Ahora es un tipo enum

        // Constructor que carga el atributo desde la base de datos
        public Atributo(string nombre)
        {
            this.nombre = nombre;
            Consulta c = new Consulta();
            Object[] a = c.Select("SELECT tipo FROM Atributo WHERE nombre = '" + this.nombre + "';")[0];

            // Asumir que el valor a[0] es un valor que corresponde a un miembro del enum
            this.tipo = (TipoAtributo)Enum.Parse(typeof(TipoAtributo), (string)a[0]);
        }
        public Atributo()
        {

        }

        // Constructor para insertar un nuevo atributo en la base de datos
        public Atributo(string nombre, TipoAtributo tipo)
        {
            this.nombre = nombre;
            this.tipo = tipo;

            // Inserción en la base de datos
            Consulta c = new Consulta();
            c.Insert("INSERT INTO Atributo (nombre, tipo) VALUES ('" + nombre + "', '" + tipo.ToString() + "');");
        }

        // Método estático para listar todos los atributos
        public static List<Atributo> ListaAtributos()
        {
            Consulta c = new Consulta();
            string consulta = "SELECT nombre, tipo FROM Atributo;";

            List<Atributo> listaAtributos = new List<Atributo>();

            // Usamos un foreach para recorrer los resultados y añadir objetos Atributo a la lista
            foreach (object[] tupla in c.Select(consulta))
            {
                string nombre = (string)tupla[0];
                string tipoStr = (string)tupla[1];

                // Convertimos el string del tipo a su valor correspondiente del enum
                TipoAtributo tipo = (TipoAtributo)Enum.Parse(typeof(TipoAtributo), tipoStr);

                Atributo atributo = new Atributo(nombre);
                atributo.tipo = tipo;
                listaAtributos.Add(atributo);
            }

            return listaAtributos;
        }

        // Propiedad Nombre (Clave primaria)
        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                Consulta c = new Consulta();
                string consulta = "UPDATE Atributo SET nombre = '" + value + "' WHERE nombre = '" + this.nombre + "';";
                c.Update(consulta);

                this.nombre = value;
            }
        }

        // Propiedad Tipo (Enum TipoAtributo)
        public TipoAtributo Tipo
        {
            get { return this.tipo; }
            set
            {
                Consulta c = new Consulta();
                string consulta = "UPDATE Atributo SET tipo = '" + value.ToString() + "' WHERE nombre = '" + this.nombre + "';";
                c.Update(consulta);
                this.tipo = value;
            }
        }

        public override string ToString()
        {
            return this.nombre;
        }

        public void Borrar()
        {
            Consulta c = new Consulta();
            c.Delete("DELETE FROM Atributo WHERE Nombre ='" + this.Nombre + "'");
        }
    }
}
