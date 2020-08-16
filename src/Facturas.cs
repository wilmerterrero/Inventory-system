using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PROG1_PROYECTO_FINAL
{
    class Facturas
    {
        //DB
        private Connection conexion = new Connection();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar(DataTable tabla)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarFactura";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarFacturas()
        {
            DataTable tabla = new DataTable();
            tabla = Mostrar(tabla);
            return tabla;
        }

        public void Crear(string cl_id, string prod_id, decimal cantidad, double importe, double total_descuento, string fecha, float total)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "GenerarFactura";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cl_id", cl_id);
            comando.Parameters.AddWithValue("@prod_id", prod_id);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@importe", importe);
            comando.Parameters.AddWithValue("@total_descuento", total_descuento);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@total", total);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
