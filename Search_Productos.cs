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
    public partial class Search_Productos : Form
    {
        private Connection conexion = new Connection();
        SqlCommand cmd;
        private string query;
        SqlDataAdapter adpt;
        DataTable dt;

        //INSTANSEA
        C_Productos objeto = new C_Productos();

        //TEXTBOX PARA HACER REPORTE
        public static string _textbox = "";
        public Search_Productos()
        {
            InitializeComponent();
        }

        private void Search_Productos_Load(object sender, EventArgs e)
        {
            MostrarProdctos();
        }

        private void MostrarProdctos()
        {
            dataGridView1.DataSource = objeto.MostrarProd();
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                query = $"FiltroProductos";
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

        private void iconBtnReload_Click(object sender, EventArgs e)
        {
            MostrarProdctos();
        }

        private void reporte_Click(object sender, EventArgs e)
        {
            //PASO VALOR PARA REALIZAR REPORTE
            _textbox = textBoxNombre.Text;

            try
            {
                Reporte_Producto_Nombre filtro_producto = new Reporte_Producto_Nombre();
                filtro_producto.ShowDialog();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
