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
    public partial class C_Child_AgrClientes : Form
    {
        C_Clientes objeto = new C_Clientes();
        private string idCliente = null;
        public C_Child_AgrClientes()
        {
            InitializeComponent();
        }
        private void C_Child_AgrClientes_Load(object sender, EventArgs e)
        {
            ComboBoxTipo_Load();
            MostrarClients();
        }

        private void MostrarClients()
        {
            dataGridView1.DataSource = objeto.MostrarClientes();
        }
        private void ComboBoxTipo_Load()
        {
            comboBxTipo.Items.Insert(0, "-- Selec. un item --");
            comboBxTipo.SelectedIndex = 0;
            comboBxTipo.Items.Add("Regular");
            comboBxTipo.Items.Add("Premium");
        }

        private void iconBtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                objeto.InsertarClient(textBoxNombre.Text, textBoxCedula.Text, textBoxTel.Text, textBoxEmail.Text, comboBxTipo.SelectedIndex);
                MessageBox.Show("se inserto correctamente");
                MostrarClients();
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
                idCliente = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                objeto.EditarClient(int.Parse(idCliente), textBoxNombre.Text, textBoxCedula.Text, textBoxTel.Text, textBoxEmail.Text, comboBxTipo.SelectedIndex);
                MessageBox.Show("Actualizado correctamente");
                MostrarClients();
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
                idCliente = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                objeto.EliminarClient(idCliente);
                MessageBox.Show("Eliminado correctamente");
                MostrarClients();
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
            Reportes_Clientes reportes_Clientes = new Reportes_Clientes();
            reportes_Clientes.ShowDialog();
        }
    }
}
