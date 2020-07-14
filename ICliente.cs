using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG1_PROYECTO_FINAL
{
    interface ICliente : IPersona
    {
        string Categoria { get; set; }
        double Descuento(double importe);
    }
}
