using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PROG1_PROYECTO_FINAL
{
    public partial class P_Child_Inventario : Form
    {
        private Connection conexion = new Connection();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        public P_Child_Inventario()
        {
            InitializeComponent();
        }
        private void P_Child_Inventario_Load(object sender, EventArgs e)
        {
            MostrarInven();
        }
        private DataTable Mostrar(DataTable tabla)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarInventario";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        private DataTable MostrarInventario()
        {
            DataTable tabla = new DataTable();
            tabla = Mostrar(tabla);
            return tabla;
        }

        private void MostrarInven()
        {
            dataGridView1.DataSource = MostrarInventario();
        }

        private void reporte_Click_1(object sender, EventArgs e)
        {
            Reporte_Producto_Inventario reporte_inventario = new Reporte_Producto_Inventario();
            reporte_inventario.ShowDialog();
        }
    }
}
