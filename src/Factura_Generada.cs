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
    public partial class Factura_Generada : Form
    {
        public Factura_Generada()
        {
            InitializeComponent();
        }

        private void Factura_Generada_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Reporte_Factura.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.Reporte_Factura.DataTable1);
            // TODO: This line of code loads data into the 'Reporte_Factura.GenerarFactura' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
