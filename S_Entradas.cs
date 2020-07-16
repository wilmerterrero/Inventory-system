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

        public override void Insertar(string producto, string proveedor, int cantidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Entradas VALUES ((SELECT prod_id FROM Productos WHERE nombre = @producto), " +
                "(SELECT prov_id FROM Proveedores WHERE nombre = @proveedor), @cantidad, getdate())";
            comando.Parameters.AddWithValue("@producto", producto);
            comando.Parameters.AddWithValue("@proveedor", proveedor);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
