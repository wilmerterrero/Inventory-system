using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PROG1_PROYECTO_FINAL
{
    class C_Proveedores : Proveedor
    {
        private S_Proveedores obj = new S_Proveedores();
        public DataTable MostrarProv()
        {
            DataTable tabla = new DataTable();
            tabla = obj.Mostrar(tabla);
            return tabla;
        }

        public void InsertarProv(string nombre, string cedula, string telefono, string email, int tipo)
        {
            obj.Insertar(nombre, cedula, telefono, email, tipo);
        }

        public void EditarProv(int id, string nombre, string cedula, string telefono, string email, int tipo)
        {
            obj.Editar(id, nombre, cedula, telefono, email, tipo);
        }

        public void EliminarProv(string id)
        {
            obj.Eliminar(Convert.ToInt32(id));
        }
    }
}
