using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG1_PROYECTO_FINAL
{
    class Cliente_Premium : Cliente
    {
        public override string Categoria
        {
            get
            {
                return Categoria;
            }

            set
            {
                Categoria = "Premium";
            }
        }

        public override double Descuento(double importe)
        {
            importe -= importe * 0.05;
            return importe;
        }
    }
}
