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
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void bProductos_Click(object sender, EventArgs e)
        {
            ListarProducto l = new ListarProducto();
            l.Show();

            this.Hide();

        }

        private void bCategorias_Click(object sender, EventArgs e)
        {
            ListarCategoria l = new ListarCategoria();
            l.Show();

            this.Hide();
        }

        private void bAtributos_Click(object sender, EventArgs e)
        {
            ListarAtributo l = new ListarAtributo();
            l.Show();

            this.Hide();
        }







    }
}
