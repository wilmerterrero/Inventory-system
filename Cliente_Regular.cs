﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG1_PROYECTO_FINAL
{
    class Cliente_Regular : ICliente
    {
        public string Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Categoria
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

        public double Descuento(double importe)
        {
            return importe;
        }
    }
}