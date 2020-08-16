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
    public partial class Reporte_Productos : Form
    {
        public Reporte_Productos()
        {
            InitializeComponent();
        }

        private void Reporte_Productos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sys_inventarioDataSet1.MostrarProductos' table. You can move, or remove it, as needed.
            this.MostrarProductosTableAdapter.Fill(this.sys_inventarioDataSet1.MostrarProductos);

            this.reportViewer1.RefreshReport();
        }
    }
}
