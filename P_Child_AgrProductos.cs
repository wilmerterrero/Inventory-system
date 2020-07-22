using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG1_PROYECTO_FINAL
{
    public partial class P_Child_AgrProductos : Form
    {
        C_Productos objeto = new C_Productos();
        private string idProducto = null;
        public P_Child_AgrProductos()
        {
            InitializeComponent();
        }

        private void P_Child_AgrProductos_Load(object sender, EventArgs e)
        {
            MostrarProdctos();
            ComboBoxTipo_Load();
        }

        private void MostrarProdctos()
        {
            dataGridView1.DataSource = objeto.MostrarProd();
        }

        private void iconBtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                objeto.InsertarProd(textBoxNombre.Text, textBoxMarca.Text, double.Parse(textBoxPrecio.Text), comboBxTipo.SelectedIndex);
                MessageBox.Show("se inserto correctamente");
                MostrarProdctos();
                CleanForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo insertar los datos por: " + ex);

            }
        }

        private void iconBtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                idProducto = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                objeto.EditarProd(idProducto, textBoxNombre.Text, textBoxMarca.Text, double.Parse(textBoxPrecio.Text));
                MessageBox.Show("Actualizado correctamente");
                MostrarProdctos();
                CleanForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo insertar los datos por: " + ex);

            }
        }

        private void iconBtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                idProducto = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                objeto.EliminarProd(idProducto);
                MessageBox.Show("Eliminado correctamente");
                MostrarProdctos();
                CleanForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo insertar los datos por: " + ex);

            }
        }

        private void ComboBoxTipo_Load()
        {
            comboBxTipo.Items.Insert(0, "-- Selec. un item --");
            comboBxTipo.SelectedIndex = 0;
            comboBxTipo.Items.Add("Computadoras");
            comboBxTipo.Items.Add("Celulares & Tablets");
            comboBxTipo.Items.Add("Accesorios");
        }

        private void CleanForm()
        {
            textBoxNombre.Clear();
            textBoxMarca.Clear();
            textBoxPrecio.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBoxNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxMarca.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBoxPrecio.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void reporte_Click(object sender, EventArgs e)
        {
            Reporte_Productos reporte_productos = new Reporte_Productos();
            reporte_productos.ShowDialog();
        }
    }
}
