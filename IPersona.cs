using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG1_PROYECTO_FINAL
{
    interface IPersona
    {
        string Id { get; set; }
        string Cedula { get; set; }
        string Nombre { get; set; }
        string Telefono { get; set; }
        string Email { get; set; }
    }
}
