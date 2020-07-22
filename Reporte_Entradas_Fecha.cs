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
    public partial class Reporte_Entradas_Fecha : Form
    {
        public Reporte_Entradas_Fecha()
        {
            InitializeComponent();
        }

        private void Reporte_Entradas_Fecha_Load(object sender, EventArgs e)
        {
            string fecha = Entradas_Modal._textbox;

            // TODO: This line of code loads data into the 'Filtro_Entrada_Fecha.EntradasFechaFiltro' table. You can move, or remove it, as needed.
            this.EntradasFechaFiltroTableAdapter.Fill(this.Filtro_Entrada_Fecha.EntradasFechaFiltro, fecha);

            this.reportViewer1.RefreshReport();
        }
    }
}
