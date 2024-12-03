using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM
{
    public partial class CrearCategoria : Form
    {
        public CrearCategoria()
        {
            InitializeComponent();
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

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNombre.Text.Length < 1)
                {
                    MessageBox.Show("El nombre de la categoria no puede estar vacio");
                } else
                {
                    Categoria c = new Categoria(tbNombre.Text);
                    c.Nombre = tbNombre.Text;
                    MessageBox.Show("Categoria añadida correctamente");
                    this.Hide();
                    ListarCategoria l = new ListarCategoria();
                    l.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error añadiendo el producto: " + ex.Message);
            }

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListarCategoria l = new ListarCategoria();
            l.Show();
        }
    }
}
