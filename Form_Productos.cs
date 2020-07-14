using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PROG1_PROYECTO_FINAL
{
    public partial class Form_Productos : Form
    {
        private Form currentFormChild;
        public Form_Productos()
        {
            InitializeComponent();


            //Config del Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void iconBtnBack_Click(object sender, EventArgs e)
        {
            Form_Main Main = new Form_Main();
            this.Hide();
            Main.Show();
        }

        //DRAG FORM
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null)
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

        private void panelTittleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0X112, 0XF012, 0);
        }

        private void iconBtnAgrProd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new P_Child_AgrProductos());
        }

        private void iconBtnEntradas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new P_Child_Entradas());
        }

        private void iconBtnInventario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new P_Child_Inventario());
        }
    }
}
