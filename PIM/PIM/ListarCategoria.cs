﻿using System;
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
    public partial class ListarCategoria : Form
    {
        TiendaEntities1 bd = new TiendaEntities1();

        public ListarCategoria()
        {
            InitializeComponent();
        }

        private void ListarCategoria_Load(object sender, EventArgs e)
        {
            // Cargar las categorías en el DataGridView
            CargarCategorias();


            // Agregar columna "Editar"
            DataGridViewButtonColumn editarBtn = new DataGridViewButtonColumn
            {
                Name = "Edit",
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(editarBtn);

            // Agregar columna "Eliminar"
            DataGridViewButtonColumn eliminarBtn = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(eliminarBtn);

            // Manejar el evento CellClick
            dataGridView1.CellClick += (s, ev) =>
            {
                // Evitar errores al hacer clic en encabezados
                if (ev.RowIndex < 0) return;

                // Obtener el ID de la categoría seleccionada
                var categoriaNombre = dataGridView1.Rows[ev.RowIndex].Cells["Name"].Value.ToString();
                var categoriaSeleccionada = bd.Categoria.FirstOrDefault(c => c.Nombre == categoriaNombre);

                // Acción para el botón "Editar"
                if (dataGridView1.Columns[ev.ColumnIndex].Name == "Edit")
                {
                    // Abrir el formulario de modificación y pasar el ID como parámetro
                    ModificarCategoria formModificar = new ModificarCategoria(categoriaSeleccionada);
                    this.Hide();
                    formModificar.ShowDialog();

                    // Recargar datos después de la modificación
                    CargarCategorias();
                }

                // Acción para el botón "Eliminar"
                if (dataGridView1.Columns[ev.ColumnIndex].Name == "Delete")
                {
                    // Buscar la categoría por su ID
                    if (categoriaSeleccionada != null)
                    {
                        // Verificar si la categoría tiene productos
                        if (categoriaSeleccionada.NumeroProductos > 0)
                        {
                            // Mostrar mensaje de confirmación si tiene productos
                            DialogResult confirm = MessageBox.Show(
                                "This category contains products. Are you sure you want to delete it?",
                                "Confirm delete",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning
                            );

                            if (confirm != DialogResult.Yes)
                            {
                                return; // Salir si el usuario no confirma
                            }
                        }

                        // Eliminar la categoría
                        bd.Categoria.Remove(categoriaSeleccionada);
                        bd.SaveChanges();
                        MessageBox.Show("Category successfully deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recargar datos después de eliminar
                        CargarCategorias();
                    }
                }
            };
        }


        private void CargarCategorias()
        {
            dataGridView1.DataSource = (from d in bd.Categoria
                                        select new
                                        {
                                            Name = d.Nombre,
                                            NumberofProducts = d.NumeroProductos // Conteo de productos
                                        }).ToList();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

        private void bCategorias_Click(object sender, EventArgs e)
        {
            ListarCategoria listarCategoria = new ListarCategoria();
            listarCategoria.Show();
            this.Hide();
        }

        private void bAtributos_Click(object sender, EventArgs e)
        {
            ListarAtributo listarAtributo = new ListarAtributo();
            listarAtributo.Show();
            this.Hide();
        }

        private void bCrearProducto_Click(object sender, EventArgs e)
        {
            CrearCategoria crearCategoria = new CrearCategoria();
            crearCategoria.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bRelaciones_Click(object sender, EventArgs e)
        {
            ListarRelacion listarRelacion = new ListarRelacion();
            listarRelacion.Show();
            this.Hide();
        }

        private void bCuenta_Click(object sender, EventArgs e)
        {
            MostrarInformacionCuenta m = new MostrarInformacionCuenta();
            m.Show();
            this.Hide();
        }


    }
}
