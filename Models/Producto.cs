using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRestaurante_main_SOLID.Models
{
    public class Producto
    {
        public string Descripcion { get; }
        public decimal Precio { get; }

        public Producto(string descripcion, decimal precio)
        {
            Descripcion = descripcion;
            Precio = precio;
        }

    }
}
