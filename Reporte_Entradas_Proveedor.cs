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
    public partial class Reporte_Entradas_Proveedor : Form
    {
        public Reporte_Entradas_Proveedor()
        {
            InitializeComponent();
        }

        private void Reporte_Entradas_Proveedor_Load(object sender, EventArgs e)
        {
            string proveedor = Entradas_Modal._textbox;
            // TODO: This line of code loads data into the 'Filtro_Entrada_Proveedor.EntradasProveedorFiltro' table. You can move, or remove it, as needed.
            this.EntradasProveedorFiltroTableAdapter.Fill(this.Filtro_Entrada_Proveedor.EntradasProveedorFiltro, proveedor);

            this.reportViewer1.RefreshReport();
        }
    }
}
