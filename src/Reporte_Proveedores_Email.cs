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
    public partial class Reporte_Proveedores_Email : Form
    {
        public Reporte_Proveedores_Email()
        {
            InitializeComponent();
        }

        private void Reporte_Proveedores_Email_Load(object sender, EventArgs e)
        {
            string email = Search_Proveedor._textbox;
            // TODO: This line of code loads data into the 'Filtro_Proveedor_Email.ProveedorEmailFiltro' table. You can move, or remove it, as needed.
            this.ProveedorEmailFiltroTableAdapter.Fill(this.Filtro_Proveedor_Email.ProveedorEmailFiltro, email);

            this.reportViewer1.RefreshReport();
        }
    }
}
