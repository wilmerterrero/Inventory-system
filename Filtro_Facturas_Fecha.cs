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
    public partial class Filtro_Facturas_Fecha : Form
    {
        public Filtro_Facturas_Fecha()
        {
            InitializeComponent();
        }

        private void Filtro_Facturas_Fecha_Load(object sender, EventArgs e)
        {
            string fecha = Facturas_Modal._textbox;
            // TODO: This line of code loads data into the 'Filtro_Factura_Fecha.FiltroFacturaFecha' table. You can move, or remove it, as needed.
            this.FiltroFacturaFechaTableAdapter.Fill(this.Filtro_Factura_Fecha.FiltroFacturaFecha, fecha);

            this.reportViewer1.RefreshReport();
        }
    }
}
