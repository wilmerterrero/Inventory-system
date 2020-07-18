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
    public partial class C_Child_Pedidos : Form
    {
        private Connection conexion = new Connection();
        C_Entradas objeto = new C_Entradas();
        private string query;
        SqlDataAdapter adpt;
        DataTable dt;
        public C_Child_Pedidos()
        {
            InitializeComponent();
            ComboBoxCliente_Load();
            ComboBoxProducto_Load();
        }
        private void ComboBoxCliente_Load()
        {
            try
            {
                //CLIENTES

                query = "SELECT * FROM Clientes";
                adpt = new SqlDataAdapter(query, conexion.AbrirConexion());
                dt = new DataTable();
                adpt.Fill(dt);
                comboBxCliente.DataSource = dt;
                comboBxCliente.DisplayMember = "nombre";
                comboBxCliente.ValueMember = "cl_id";
            }
            catch (Exception)
            {

            }
        }

        private void ComboBoxProducto_Load()
        {
            try
            {
                //PRODUCTOS

                query = "SELECT Prod.nombre, E.prod_id FROM Entradas AS E " +
                    $"INNER JOIN Productos AS Prod ON E.prod_id = Prod.prod_id;";
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
                //ENTRADAS

                query = "SELECT E.cantidad, E.prod_id, Prod.nombre FROM Productos AS Prod " +
                    $"INNER JOIN Entradas AS E ON E.prod_id = Prod.prod_id WHERE Prod.nombre = '{comboBxProducto.Text}';";
                adpt = new SqlDataAdapter(query, conexion.AbrirConexion());
                dt = new DataTable();
                adpt.Fill(dt);
                comboBxCantidad.DataSource = dt;
                comboBxCantidad.ValueMember = "prod_id";              
                foreach(var i in comboBxCantidad.DisplayMember = "cantidad")
                {
                    comboBxCantidad.Items.Add(i);
                }
            }
            catch (Exception)
            {

            }
        }

        private void iconBtnInsert_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBxProducto.SelectedItem.ToString());
        }
    }
}
