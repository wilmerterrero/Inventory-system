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
    public partial class Reporte_Producto_Inventario : Form
    {
        public Reporte_Producto_Inventario()
        {
            InitializeComponent();
        }

        private void Reporte_Producto_Inventario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Reporte_Inventario.MostrarInventario' table. You can move, or remove it, as needed.
            this.MostrarInventarioTableAdapter.Fill(this.Reporte_Inventario.MostrarInventario);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
