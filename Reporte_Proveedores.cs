﻿using System;
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
    public partial class Reporte_Proveedores : Form
    {
        public Reporte_Proveedores()
        {
            InitializeComponent();
        }

        private void Reporte_Proveedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetProveedores.MostrarProveedores' table. You can move, or remove it, as needed.
            this.MostrarProveedoresTableAdapter.Fill(this.DataSetProveedores.MostrarProveedores);

            this.reportViewer1.RefreshReport();
        }
    }
}
