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
    public partial class Entradas_Modal : Form
    {
        private Connection conexion = new Connection();
        SqlCommand cmd;
        private string query;
        SqlDataAdapter adpt;
        DataTable dt;

        //INSTANSEAS
        C_Entradas objeto = new C_Entradas();

        //TEXTBOX PARA HACER REPORTE
        public static string _textbox = "";

        public Entradas_Modal()
        {
            InitializeComponent();
        }
        private void Entradas_Modal_Load(object sender, EventArgs e)
        {
            MostrarEntries();
            ComboBoxTipo_Load();
        }
        private void MostrarEntries()
        {
            dataGridView1.DataSource = objeto.MostrarEntradas();
        }
        private void ComboBoxTipo_Load()
        {
            comboBxTipo.Items.Insert(0, "Selec. un item");
            comboBxTipo.SelectedIndex = 0;
            comboBxTipo.Items.Add("Producto");
            comboBxTipo.Items.Add("Fecha");
            comboBxTipo.Items.Add("Proveedor");
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void iconBtnSearch_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                try
                {
                    switch (comboBxTipo.Text)
                    {
                        case "Producto":

                            query = $"EntradasProductoFiltro";
                            cmd = new SqlCommand(query, conexion.AbrirConexion());
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@producto", textBox.Text);
                            cmd.ExecuteNonQuery();
                            dt = new DataTable();
                            adpt = new SqlDataAdapter(cmd);
                            adpt.Fill(dt);
                            dataGridView1.DataSource = dt;
                            conexion.CerrarConexion();

                            break;

                        case "Fecha":

                            query = $"EntradasFechaFiltro";
                            cmd = new SqlCommand(query, conexion.AbrirConexion());
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@fecha", textBox.Text);
                            cmd.ExecuteNonQuery();
                            dt = new DataTable();
                            adpt = new SqlDataAdapter(cmd);
                            adpt.Fill(dt);
                            dataGridView1.DataSource = dt;
                            conexion.CerrarConexion();

                            break;

                        case "Proveedor":

                            query = $"EntradasProveedorFiltro";
                            cmd = new SqlCommand(query, conexion.AbrirConexion());
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@proveedor", textBox.Text);
                            cmd.ExecuteNonQuery();
                            dt = new DataTable();
                            adpt = new SqlDataAdapter(cmd);
                            adpt.Fill(dt);
                            dataGridView1.DataSource = dt;
                            conexion.CerrarConexion();

                            break;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void iconBtnReload_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarEntries();
                textBox.Clear();
            }
            catch (Exception err)
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
                        case "Producto":

                            Reporte_Entradas_Producto filtro_producto = new Reporte_Entradas_Producto();
                            filtro_producto.ShowDialog();

                            break;

                        case "Fecha":

                            Reporte_Entradas_Fecha filtro_fecha = new Reporte_Entradas_Fecha();
                            filtro_fecha.ShowDialog();

                            break;

                        case "Proveedor":

                            Reporte_Entradas_Proveedor filtro_prveedor = new Reporte_Entradas_Proveedor();
                            filtro_prveedor.ShowDialog();

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
