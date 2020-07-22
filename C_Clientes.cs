using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PROG1_PROYECTO_FINAL
{
    class C_Clientes : Cliente
    {
        private S_Cliente obj = new S_Cliente();

        public DataTable MostrarClientes()
        {
            DataTable tabla = new DataTable();
            tabla = obj.Mostrar(tabla);
            return tabla;
        }
        public DataTable MostrarCategoriasClientes()
        {
            DataTable tabla = new DataTable();
            tabla = obj.MostrarCategorias(tabla);
            return tabla;
        }
        public void InsertarClient(string nombre, string cedula, string telefono, string email, int categoria)
        {
            obj.Insertar(nombre, cedula, telefono, email, categoria);
        }

        public void EditarClient(int id, string nombre, string cedula, string telefono, string email, int categoria)
        {
            obj.Editar(id, nombre, cedula, telefono, email, categoria);
        }

        public void EliminarClient(string id)
        {
            obj.Eliminar(Convert.ToInt32(id));
        }
    }
}
