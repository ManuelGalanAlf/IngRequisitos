using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

           // Consulta c1 = new Consulta();
           // c1.Insert("INSERT INTO Categoria (nombre) VALUES ('Prueba')");

           // Producto p1 = new Producto("001", "001", "producto1", null);
           // Producto p2 = new Producto("002", "002", "producto2", null);
           // Producto p3 = new Producto("003", "003", "producto3", null);
           // Producto p4 = new Producto("004", "004", "producto4", null);
           // Producto p5 = new Producto("005", "005", "producto5", null);

           // Atributo a1 = new Atributo("Detalle", TipoAtributo.Cadena);
           // Atributo a2 = new Atributo("Precio", TipoAtributo.Real);

           // Categoria cat1 = new Categoria("categoria1");
           // Categoria c2 = new Categoria("categoria2");
           // Categoria c3 = new Categoria("categoria3");

           // ProductoCategoria pc1 = new ProductoCategoria("001", "001", "categoria2");
           //ProductoCategoria pc2 = new ProductoCategoria("003", "003", "categoria2");
           // ProductoCategoria pc3 = new ProductoCategoria("002", "002", "categoria1");
           // ProductoCategoria pc4 = new ProductoCategoria("002", "002", "categoria2");
           // ProductoCategoria pc5 = new ProductoCategoria("004", "004", "categoria3");

            //Console.WriteLine("Lista de Atributos:");
            //foreach (Atributo atributo in listaAtributos)
            //{
                // Mostrar cada atributo usando el método ToString
              //  Console.WriteLine(atributo.ToString());
            //}

            /*
            foreach(Categoria a in Categoria.ListarCategorias()) {
                Console.WriteLine(a.ToString());
            }

            */

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            

            // Inicia la aplicación de Windows Forms
            Application.Run(new PantallaPrincipal());
            
        }
    }
}
