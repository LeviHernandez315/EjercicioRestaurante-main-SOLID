using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioRestaurante_main_SOLID.Diccionarios;

namespace EjercicioRestaurante_main_SOLID.Models
{
    public class Marcacion
    {
        public DateTime Tiempo { get; }
        public TipoMarcacion Tipo { get; }
        public string NombreEmpleado { get; }

        public Marcacion(string nombreEmpleado, TipoMarcacion tipo)
        {
            Tiempo = DateTime.Now;
            Tipo = tipo;
            NombreEmpleado = nombreEmpleado;
        }
    }
}
