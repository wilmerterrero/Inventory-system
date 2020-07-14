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
        public P_Child_AgrProductos()
        {
            InitializeComponent();
        }

        private void P_Child_AgrProductos_Load(object sender, EventArgs e)
        {
            MostrarProdctos();
        }

        private void MostrarProdctos()
        {
            dataGridView1.DataSource = objeto.MostrarProd();
        }

        private void iconBtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                objeto.InsertarProd(textBoxNombre.Text, textBoxMarca.Text, double.Parse(textBoxPrecio.Text));
                MessageBox.Show("se inserto correctamente");
                MostrarProdctos();
                CleanForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo insertar los datos por: " + ex);

            }
        }

        private void CleanForm()
        {
            textBoxNombre.Clear();
            textBoxMarca.Clear();
            textBoxPrecio.Clear();
        }
    }
}
