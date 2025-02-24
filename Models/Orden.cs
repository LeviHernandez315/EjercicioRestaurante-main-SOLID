using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioRestaurante_main_SOLID.Diccionarios;

namespace EjercicioRestaurante_main_SOLID.Models
{
    public class Orden
    {
        public int Id { get; private set; }
        public string NombreCliente { get; private set; }
        public Dictionary<Producto, int> Productos { get; private set; }
        public bool EsADomicilio { get; private set; }
        public EstadoOrden Estado { get; set; }
        public DateTime FechaCreacion { get; private set; }

        public Orden(int id, string nombreCliente, Dictionary<Producto, int> productos, bool esADomicilio)
        {
            Id = id;
            NombreCliente = nombreCliente;
            Productos = productos ?? new Dictionary<Producto, int>();
            EsADomicilio = esADomicilio;
            Estado = EstadoOrden.Creada;
            FechaCreacion = DateTime.Now;
        }

    }
}
