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
    public partial class Reporte_Clientes_Nombre : Form
    {
        public Reporte_Clientes_Nombre()
        {
            InitializeComponent();
        }

        private void Reporte_Clientes_Nombre_Load(object sender, EventArgs e)
        {
            string nombre = Search_Clientes._textbox;
            // TODO: This line of code loads data into the 'Filtro_Clientes_Nombre.ClientesNombreFiltro' table. You can move, or remove it, as needed.
            this.ClientesNombreFiltroTableAdapter.Fill(this.Filtro_Clientes_Nombre.ClientesNombreFiltro, nombre);

            this.reportViewer1.RefreshReport();
        }
    }
}
