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
    public partial class Reportes_Clientes : Form
    {
        public Reportes_Clientes()
        {
            InitializeComponent();
        }

        private void Reportes_Clientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sys_inventarioDataSet.MostrarClientes' table. You can move, or remove it, as needed.
            this.MostrarClientesTableAdapter.Fill(this.sys_inventarioDataSet.MostrarClientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
