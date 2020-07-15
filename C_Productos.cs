using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PROG1_PROYECTO_FINAL
{
    class C_Productos : Productos
    {
        private S_Productos obj = new S_Productos();
        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = obj.Mostrar(tabla);
            return tabla;
        }
        public void InsertarProd(string nombre, string marca, double precio)
        {
            obj.Insertar(nombre, marca, Convert.ToDouble(precio));
        }

        public void EditarProd(string id, string nombre, string marca, double precio)
        {
            obj.Editar(Convert.ToInt32(id), nombre, marca, Convert.ToDouble(precio));
        }

        public void EliminarProd(string id)
        {
            obj.Eliminar(Convert.ToInt32(id));
        }
    }
}
