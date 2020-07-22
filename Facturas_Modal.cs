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
    public partial class Facturas_Modal : Form
    {
        private Connection conexion = new Connection();
        SqlCommand cmd;
        private string query;
        SqlDataAdapter adpt;
        DataTable dt;

        //INSTANSEAS
        Facturas facturas = new Facturas();

        public Facturas_Modal()
        {
            InitializeComponent();
        }

        private void Facturas_Modal_Load(object sender, EventArgs e)
        {
            MostrarFacturs();
            ComboBoxTipo_Load();
        }

        private void MostrarFacturs()
        {
            dataGridView1.DataSource = facturas.MostrarFacturas();
        }
        private void ComboBoxTipo_Load()
        {
            comboBxTipo.Items.Insert(0, "Selec. un item");
            comboBxTipo.SelectedIndex = 0;
            comboBxTipo.Items.Add("Fecha");
            comboBxTipo.Items.Add("Cliente");
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
                        case "Fecha":

                            query = $"SELECT cli.nombre AS 'CLIENTE', prodc.nombre AS 'PRODUCTO', f.cantidad AS 'CANTIDAD', f.importe AS 'ITBIS', f.fecha AS 'FECHA', " +
                                $"f.total_descuento AS 'TOTAL SIN ITBIS', f.total 'TOTAL' FROM Facturacion AS f " +
                                $"INNER JOIN Clientes AS cli ON cli.cl_id = f.cl_id " +
                                $"INNER JOIN Productos AS prodc ON prodc.prod_id = f.prod_id WHERE f.fecha LIKE '%{textBox.Text}%';";
                            cmd = new SqlCommand(query, conexion.AbrirConexion());
                            cmd.ExecuteNonQuery();
                            dt = new DataTable();
                            adpt = new SqlDataAdapter(cmd);
                            adpt.Fill(dt);
                            dataGridView1.DataSource = dt;
                            conexion.CerrarConexion();

                            break;

                        case "Cliente":

                            query = $"SELECT cli.nombre AS 'CLIENTE', prodc.nombre AS 'PRODUCTO', f.cantidad AS 'CANTIDAD', f.importe AS 'ITBIS', f.fecha AS 'FECHA', " +
                                $"f.total_descuento AS 'TOTAL SIN ITBIS', f.total 'TOTAL' FROM Facturacion AS f " +
                                $"INNER JOIN Clientes AS cli ON cli.cl_id = f.cl_id " +
                                $"INNER JOIN Productos AS prodc ON prodc.prod_id = f.prod_id WHERE cli.nombre LIKE '%{textBox.Text}%';";
                            cmd = new SqlCommand(query, conexion.AbrirConexion());
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
                MostrarFacturs();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
