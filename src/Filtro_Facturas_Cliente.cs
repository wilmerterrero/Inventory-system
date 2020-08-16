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
    public partial class Filtro_Facturas_Cliente : Form
    {
        public Filtro_Facturas_Cliente()
        {
            InitializeComponent();
        }

        private void Filtro_Facturas_Cliente_Load(object sender, EventArgs e)
        {
            string cliente = Facturas_Modal._textbox;
            // TODO: This line of code loads data into the 'Filtro_Factura_Cliente.FiltroFacturaCliente' table. You can move, or remove it, as needed.
            this.FiltroFacturaClienteTableAdapter.Fill(this.Filtro_Factura_Cliente.FiltroFacturaCliente, cliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
