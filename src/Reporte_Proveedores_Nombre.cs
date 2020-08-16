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
    public partial class Reporte_Proveedores_Nombre : Form
    {
        public Reporte_Proveedores_Nombre()
        {
            InitializeComponent();
        }

        private void Reporte_Proveedores_Nombre_Load(object sender, EventArgs e)
        {
            string nombre = Search_Proveedor._textbox;
            // TODO: This line of code loads data into the 'Filtro_Proveedor_Nombre.ProveedorNombreFiltro' table. You can move, or remove it, as needed.
            this.ProveedorNombreFiltroTableAdapter.Fill(this.Filtro_Proveedor_Nombre.ProveedorNombreFiltro, nombre);

            this.reportViewer1.RefreshReport();
        }
    }
}
