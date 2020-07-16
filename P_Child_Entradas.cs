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
    public partial class P_Child_Entradas : Form
    {
        private Connection conexion = new Connection();
        C_Entradas objeto = new C_Entradas();
        private string query;
        SqlDataAdapter adpt;
        DataTable dt;
        public P_Child_Entradas()
        {
            InitializeComponent();
        }
        private void P_Child_Entradas_Load(object sender, EventArgs e)
        {
            ComboBoxProducto_Load();
            //comboBxProducto.SelectedIndex = -1;
        }

        private void iconBtnEntradas_Click(object sender, EventArgs e)
        {
            Entradas_Modal modal = new Entradas_Modal();
            modal.Owner = this; // we want the new form to float on top of this one
            modal.Show();
        }

        private void iconBtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                objeto.InsertarEntrada(comboBxProducto.Text, comboBxProveedor.Text, int.Parse(textBoxCantidad.Text));
                MessageBox.Show("se inserto correctamente");
                CleanForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo insertar los datos por: " + ex.Message);

            }
        }

        private void ComboBoxProducto_Load()
        {
            try
            {
                //PRODUCTOS

                query = "SELECT * FROM Productos";
                adpt = new SqlDataAdapter(query, conexion.AbrirConexion());
                dt = new DataTable();
                adpt.Fill(dt);
                comboBxProducto.DataSource = dt;
                comboBxProducto.DisplayMember = "nombre";
                comboBxProducto.ValueMember = "prod_id";
            }
            catch (Exception)
            {

            }
        }

        private void comboBxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //PROVEEDORES
                query = "SELECT Prov.nombre, Prod.nombre, Prov.prov_id FROM Proveedores AS Prov " +
                    $"INNER JOIN Productos AS Prod ON Prov.tipos_id = Prod.tipos_id WHERE Prod.nombre = '{comboBxProducto.Text}';";
                adpt = new SqlDataAdapter(query, conexion.AbrirConexion());
                dt = new DataTable();
                adpt.Fill(dt);
                comboBxProveedor.DataSource = dt;
                comboBxProveedor.DisplayMember = "nombre";
                comboBxProveedor.ValueMember = "prov_id";
            }
            catch (Exception)
            {

            }
        }

        private void CleanForm()
        {
            textBoxCantidad.Clear();
            comboBxProducto.SelectedIndex = -1;
            comboBxProveedor.SelectedIndex = -1;
        }
    }
}
