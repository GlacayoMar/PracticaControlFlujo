using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba1.models
{
    internal class Estudiante
    {
        public string NombreCompleto { get; set; }

        public Estudiante(string nombreCompleto)
        {
            NombreCompleto = nombreCompleto;
        }

        public bool EsNombreLargo()
        {
            return NombreCompleto.Length > 25;
        }
    }
}
