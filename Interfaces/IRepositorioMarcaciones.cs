using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioRestaurante_main_SOLID.Models;

namespace EjercicioRestaurante_main_SOLID.Interfaces
{
    public interface IRepositorioMarcaciones
    {
        void GuardarMarcacion(Marcacion marcacion);
    }
}
