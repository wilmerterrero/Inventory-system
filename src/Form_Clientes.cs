﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PROG1_PROYECTO_FINAL
{
    public partial class Form_Clientes : Form
    {
        private Form currentFormChild;
        public Form_Clientes()
        {
            InitializeComponent();

            //Config del Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                //open only form
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelWindow.Controls.Add(childForm);
            panelWindow.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Form_Main Main = new Form_Main();
            this.Hide();
            Main.Show();
        }

        private void iconBtnAgrClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new C_Child_AgrClientes());
        }

        private void iconBtnPedidos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new C_Child_Pedidos());
        }

        private void iconBtnSearch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Search_Clientes());
        }
    }
}
