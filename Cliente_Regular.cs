using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG1_PROYECTO_FINAL
{
    class Cliente_Regular : Cliente
    {
        public override string Categoria
        {
            get
            {
                return Categoria;
            }

            set
            {
                Categoria = "Regular";
            }
        }

        public override double Descuento(double importe)
        {
            return importe;
        }
    }
}
