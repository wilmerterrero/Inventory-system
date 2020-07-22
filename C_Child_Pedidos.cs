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
        //DB
        private Connection conexion = new Connection();
        private string query;
        SqlDataAdapter adpt;
        DataTable dt;

        //INSTANSEAS
        Cliente cliente = new Cliente_Regular();
        Facturas facturas = new Facturas();
        public C_Child_Pedidos()
        {
            InitializeComponent();
        }
        private void C_Child_Pedidos_Load(object sender, EventArgs e)
        {
            ComboBoxCliente_Load();
            ComboBoxProducto_Load();
            CleanForm();
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

                query = "SELECT Prod.nombre, I.prod_id FROM Inventario AS I " +
                    $"INNER JOIN Productos AS Prod ON I.prod_id = Prod.prod_id;";
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
                //CANTIDAD DEL PRODUCTO

                query = "SELECT I.cantidad FROM Productos AS Prod " +
                    $"INNER JOIN Inventario AS I ON I.prod_id = Prod.prod_id WHERE Prod.nombre = '{comboBxProducto.Text}';";

                SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion());
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    cantidadProducto.Text = data.GetValue(0).ToString();
                }
                conexion.CerrarConexion();
            }
            catch (Exception)
            {

            }
        }

        private void comboBxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //CATEGORIAS
                 
                query = "SELECT Cat.nombre FROM Clientes AS Cliente " +
                    $"INNER JOIN CategoriasClientes AS Cat ON Cliente.categoria_id = Cat.categoria_id WHERE cl_id = {comboBxCliente.SelectedValue};";

                SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion());
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    categoriaCliente.Text = data.GetValue(0).ToString();
                }
                conexion.CerrarConexion();
            }
            catch (Exception)
            {

            }
        }

        private void getTotal()
        {
            query = $"SELECT SUM({cantidad.Value}*p.precio) FROM Productos AS p WHERE prod_id = {comboBxProducto.SelectedValue}";

            SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion());
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                precioXcantidad.Text = data.GetValue(0).ToString();
            }
            conexion.CerrarConexion();
        }

        private void iconBtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                getTotal();

                switch (categoriaCliente.Text)
                {
                    case "Premium":
                        cliente = new Cliente_Premium();
                        MessageBox.Show("PREMIUM!!");
                        break;
                    case "Regular":
                        cliente = new Cliente_Regular();
                        MessageBox.Show("REGULAR!!");
                        break;
                    default:
                        MessageBox.Show("Elija un cliente hasta que cambie el tipo");
                        break;
                }
                facturas.Crear(comboBxCliente.SelectedValue.ToString(), comboBxProducto.SelectedValue.ToString(), cantidad.Value, 0, cliente.Descuento(Convert.ToDouble(precioXcantidad.Text)), "", 0);
                CleanForm();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void CleanForm()
        {
            comboBxCliente.SelectedIndex = -1;
            comboBxProducto.SelectedIndex = -1;
        }

        private void iconBtnEntradas_Click(object sender, EventArgs e)
        {
            Facturas_Modal modal = new Facturas_Modal();
            modal.Owner = this; // we want the new form to float on top of this one
            modal.Show();
        }
    }
}
