using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioRestaurante_main_SOLID.Diccionarios;

namespace EjercicioRestaurante_main_SOLID.Interfaces
{
    public interface IRegistro
    {
        void RegistrarMarcacion(TipoMarcacion tipo);
    }
}
