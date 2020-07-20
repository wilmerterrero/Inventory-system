using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PROG1_PROYECTO_FINAL
{
    class S_Entradas : Entradas
    {
        private Connection conexion = new Connection();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public override DataTable Mostrar(DataTable tabla)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarEntradasProductos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public override void Insertar(string producto, string proveedor, decimal cantidad, string fecha)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarEntradasProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@prod_id", producto);
            comando.Parameters.AddWithValue("@prov_id", proveedor);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
