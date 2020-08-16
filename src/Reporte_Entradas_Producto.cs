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
    public partial class Reporte_Entradas_Producto : Form 
    { 
        public Reporte_Entradas_Producto()
        {
            InitializeComponent();
        }

        private void Reporte_Entradas_Load(object sender, EventArgs e)
        {
            string producto = Entradas_Modal._textbox;

            // TODO: This line of code loads data into the 'sys_inventarioDataSet6.EntradasProductoFiltro' table. You can move, or remove it, as needed.
            this.EntradasProductoFiltroTableAdapter.Fill(this.sys_inventarioDataSet6.EntradasProductoFiltro, producto);

            this.reportViewer1.RefreshReport();
        }
    }
}
