﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace PROG1_PROYECTO_FINAL
{
    public partial class Form_Main : Form
    {
        Form_Productos Productos = new Form_Productos();
        Form_Proveedores Proveedores = new Form_Proveedores();
        Form_Clientes Clientes = new Form_Clientes();
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Config del Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void iconBtnProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Productos.Show();
        }

        private void iconBtnProveedores_Click(object sender, EventArgs e)
        {
            this.Hide();
            Proveedores.Show();
        }

        private void iconBtnClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes.Show();
        }

        //DRAG FORM
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTittleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0X112, 0XF012, 0);
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
