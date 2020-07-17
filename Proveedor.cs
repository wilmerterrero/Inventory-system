using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PROG1_PROYECTO_FINAL
{
    abstract class Proveedor : IPersona
    {
        public virtual DataTable Mostrar(DataTable table)
        {
            return table;
        }
        public virtual void Insertar(string nombre, string cedula, string telefono, string email, int tipo) { }
        public virtual void Editar(int id, string nombre, string cedula, string telefono, string email, int tipo) { }
        public virtual void Eliminar(int id) { }
    }
}
