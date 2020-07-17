using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG1_PROYECTO_FINAL
{
    interface IPersona
    {
        void Insertar(string nombre, string cedula, string telefono, string email, int categoria);
        void Editar(int id, string nombre, string cedula, string telefono, string email, int categoria);
        void Eliminar(int id);
    }
}