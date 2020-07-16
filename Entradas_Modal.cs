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
    public partial class Entradas_Modal : Form
    {
        C_Entradas objeto = new C_Entradas();
        public Entradas_Modal()
        {
            InitializeComponent();
        }
        private void Entradas_Modal_Load(object sender, EventArgs e)
        {
            MostrarProdctos();
        }
        private void MostrarProdctos()
        {
            dataGridView1.DataSource = objeto.MostrarProd();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
