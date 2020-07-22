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
    public partial class Search_Clientes : Form
    {
        private Connection conexion = new Connection();
        SqlCommand cmd;
        private string query;
        SqlDataAdapter adpt;
        DataTable dt;

        //INSTANSEA
        C_Clientes objeto = new C_Clientes();

        //TEXTBOX PARA HACER REPORTE
        public static string _textbox = "";

        public Search_Clientes()
        {
            InitializeComponent();
        }

        private void Search_Clientes_Load(object sender, EventArgs e)
        {
            MostrarClients();
        }

        private void MostrarClients()
        {
            dataGridView1.DataSource = objeto.MostrarClientes();
        }

        private void MostrarCategoriasClients()
        {
            dataGridView1.DataSource = objeto.MostrarCategoriasClientes();
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                query = $"ClientesNombreFiltro";
                cmd = new SqlCommand(query, conexion.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", textBoxNombre.Text);
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                conexion.CerrarConexion();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void iconBtnCategorias_Click(object sender, EventArgs e)
        {
            MostrarCategoriasClients();
        }

        private void reporte_Click(object sender, EventArgs e)
        {
            //PASO VALOR PARA REALIZAR REPORTE
            _textbox = textBoxNombre.Text;

            if (textBoxNombre.Text != "")
            {
                try
                {
                    Reporte_Clientes_Nombre reporte_nombre = new Reporte_Clientes_Nombre();
                    reporte_nombre.ShowDialog();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
    }
}
