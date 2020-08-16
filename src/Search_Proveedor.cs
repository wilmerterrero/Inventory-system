using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PROG1_PROYECTO_FINAL
{
    public partial class Search_Proveedor : Form
    {
        private Connection conexion = new Connection();
        SqlCommand cmd;
        private string query;
        SqlDataAdapter adpt;
        DataTable dt;

        //INSTANSEA
        C_Proveedores objeto = new C_Proveedores();

        //TEXTBOX PARA HACER REPORTE
        public static string _textbox = "";

        public Search_Proveedor()
        {
            InitializeComponent();
        }

        private void Search_Proveedor_Load(object sender, EventArgs e)
        {
            MostrarProveedores();
            ComboBoxTipo_Load();
        }

        private void MostrarProveedores()
        {
            dataGridView1.DataSource = objeto.MostrarProv();
        }

        private void ComboBoxTipo_Load()
        {
            comboBxTipo.Items.Insert(0, "Selec. un item");
            comboBxTipo.SelectedIndex = 0;
            comboBxTipo.Items.Add("Nombre");
            comboBxTipo.Items.Add("Email");
        }

        private void iconBtnSearch_Click(object sender, EventArgs e)
        {
            if(textBox.Text != "")
            {
                try
                {
                    switch (comboBxTipo.Text)
                    {
                        case "Nombre":

                            query = $"ProveedorNombreFiltro";
                            cmd = new SqlCommand(query, conexion.AbrirConexion());
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@nombre", textBox.Text);
                            cmd.ExecuteNonQuery();
                            dt = new DataTable();
                            adpt = new SqlDataAdapter(cmd);
                            adpt.Fill(dt);
                            dataGridView1.DataSource = dt;
                            conexion.CerrarConexion();

                            break;

                        case "Email":

                            query = $"ProveedorEmailFiltro";
                            cmd = new SqlCommand(query, conexion.AbrirConexion());
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@email", textBox.Text);
                            cmd.ExecuteNonQuery();
                            dt = new DataTable();
                            adpt = new SqlDataAdapter(cmd);
                            adpt.Fill(dt);
                            dataGridView1.DataSource = dt;
                            conexion.CerrarConexion();

                            break;
                    }
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void iconBtnReload_Click(object sender, EventArgs e)
        {
            try
            {
                textBox.Clear();
                MostrarProveedores();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void reporte_Click(object sender, EventArgs e)
        {
            //PASO VALOR PARA REALIZAR REPORTE
            _textbox = textBox.Text;

            if (textBox.Text != "")
            {
                try
                {
                    switch (comboBxTipo.Text)
                    {
                        case "Nombre":

                            Reporte_Proveedores_Nombre filtro_nombre = new Reporte_Proveedores_Nombre();
                            filtro_nombre.ShowDialog();

                            break;

                        case "Email":

                            Reporte_Proveedores_Email filtro_email = new Reporte_Proveedores_Email();
                            filtro_email.ShowDialog();

                            break;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
    }
}
