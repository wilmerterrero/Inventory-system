using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PROG1_PROYECTO_FINAL
{
    class C_Entradas : Entradas
    {
        private S_Entradas obj = new S_Entradas();
        public DataTable MostrarEntradas()
        {
            DataTable tabla = new DataTable();
            tabla = obj.Mostrar(tabla);
            return tabla;
        }
        public void InsertarEntrada(string producto, string proveedor, decimal cantidad, string fecha)
        {
            obj.Insertar(producto, proveedor, cantidad, fecha);
        }
    }
}
