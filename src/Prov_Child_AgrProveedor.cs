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
    public partial class Prov_Child_AgrProveedor : Form
    {
        C_Proveedores objeto = new C_Proveedores();
        private string idProveedor = null;
        public Prov_Child_AgrProveedor()
        {
            InitializeComponent();
        }
        private void Prov_Child_AgrProveedor_Load(object sender, EventArgs e)
        {
            MostrarProvdor();
            ComboBoxTipo_Load();

            //SETTING DGV
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[5].Width = 180;
        }
        private void ComboBoxTipo_Load()
        {
            comboBxTipo.Items.Insert(0, "-- Selec. un item --");
            comboBxTipo.SelectedIndex = 0;
            comboBxTipo.Items.Add("Computadoras");
            comboBxTipo.Items.Add("Celulares & Tablets");
            comboBxTipo.Items.Add("Accesorios");
        }
        private void MostrarProvdor()
        {
            dataGridView1.DataSource = objeto.MostrarProv();
        }

        private void iconBtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                objeto.InsertarProv(textBoxNombre.Text, textBoxCedula.Text, textBoxTel.Text, textBoxEmail.Text, comboBxTipo.SelectedIndex);
                MessageBox.Show("se inserto correctamente");
                MostrarProvdor();
                CleanForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo insertar los datos por: " + ex);

            }
        }

        private void iconBtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                idProveedor = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                objeto.EditarProv(int.Parse(idProveedor), textBoxNombre.Text, textBoxCedula.Text, textBoxTel.Text, textBoxEmail.Text, comboBxTipo.SelectedIndex);
                MessageBox.Show("Actualizado correctamente");
                MostrarProvdor();
                CleanForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo insertar los datos por: " + ex);

            }
        }

        private void iconBtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                idProveedor = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                objeto.EliminarProv(idProveedor);
                MessageBox.Show("Eliminado correctamente");
                MostrarProvdor();
                CleanForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo insertar los datos por: " + ex);

            }
        }

        private void CleanForm()
        {
            textBoxNombre.Clear();
            textBoxCedula.Clear();
            textBoxEmail.Clear();
            textBoxTel.Clear();
            comboBxTipo.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBoxNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxCedula.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBoxEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBoxTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                comboBxTipo.SelectedItem = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void reporte_Click(object sender, EventArgs e)
        {
            Reporte_Proveedores reporte_Proveedores = new Reporte_Proveedores();
            reporte_Proveedores.ShowDialog();
        }
    }
}
