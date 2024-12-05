using System;
using System.Collections.Generic;

namespace PIM
{
     class ValorAtributo
    {
        public string productoSku;
        public string productoGtin;
        public string atributoNombre;
        public string valor;

        // Constructor que inserta el valor en la base de datos
        public ValorAtributo(string productoSku, string productoGtin, string atributoNombre, string valor)
        {
            this.productoSku = productoSku;
            this.productoGtin = productoGtin;
            this.atributoNombre = atributoNombre;
            this.valor = valor;

            // Inserción en la base de datos
            Consulta c = new Consulta();
            string consulta = "INSERT INTO ValorAtributo (producto_sku, producto_gtin, atributo_nombre, valor) VALUES ('" + productoSku + "', '" + productoGtin + "', '" + atributoNombre + "', '" + valor + "');";
            c.Insert(consulta);
        }

        public ValorAtributo(string atributoNombre, string valor)
        {
            this.atributoNombre = atributoNombre;
            this.valor = valor;
        }

        // Método estático para listar los atributos de un producto
        public static List<ValorAtributo> ListarAtributoDeProducto(Producto producto)
        {
            Consulta c = new Consulta();
            List<ValorAtributo> atributos = new List<ValorAtributo>();

            string consulta = "SELECT atributo_nombre, valor FROM ValorAtributo WHERE producto_sku = '" + producto.SKU + "';";
            var resultados = c.Select(consulta);

            foreach (object[] a in resultados)
            {
                string atributoNombre = (string)a[0]; // Nombre del atributo
                string valor = (string)a[1]; // Valor asociado al atributo
                ValorAtributo atributo = new ValorAtributo(atributoNombre, valor);
                atributos.Add(atributo);
            }

            return atributos;
        }

        public string VALOR
        {
            get { return this.valor; }
            set
            {
                Consulta c = new Consulta();
                string consulta = "UPDATE ValorAtributo SET valor = '" + value + "' WHERE SKU = '" + this.productoSku + "';";
                c.Update(consulta);
                this.valor = value;
            }
        }
    }
}
