using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioRestaurante_main_SOLID.Interfaces;

namespace EjercicioRestaurante_main_SOLID.Models
{
    public class RestauranteServicio
    {
        private readonly IRepositorioOrdenes _repositorioOrdenes;
        private readonly List<Personal> _personal = new();
        private int _siguienteIdOrden = 1;

        public RestauranteServicio(IRepositorioOrdenes repositorioOrdenes)
        {
            _repositorioOrdenes = repositorioOrdenes;
        }

        public void AgregarPersonal(Personal personal)
        {
            _personal.Add(personal);
        }

        public Orden CrearOrden(string nombreCliente, Dictionary<Producto, int> productos, bool esADomicilio)
        {
            var orden = new Orden(_siguienteIdOrden++, nombreCliente, productos, esADomicilio);
            _repositorioOrdenes.GuardarOrden(orden);
            return orden;
        }
    }
}
