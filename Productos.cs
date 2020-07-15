using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PROG1_PROYECTO_FINAL
{
    abstract class Productos
    {
        public virtual DataTable Mostrar(DataTable table)
        {
            return table;
        }

        public virtual void Insertar(string nombre, string marca, double precio) { }
        public virtual void Editar(int id, string nombre, string marca, double precio) { }
        public virtual void Eliminar(int id) { }
    }
}
