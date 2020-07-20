using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PROG1_PROYECTO_FINAL
{
    class Connection
    {
        //CONEXION
        private SqlConnection Conexion = new SqlConnection("Data source= WILMER-LAPTOP; Initial Catalog=sys_inventario; Integrated Security=True");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed) Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open) Conexion.Close();
            return Conexion;
        }
    }
}
