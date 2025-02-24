using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioRestaurante_main_SOLID.Diccionarios;
using EjercicioRestaurante_main_SOLID.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjercicioRestaurante_main_SOLID.Models
{
    public class Mesero: Personal, IActividad
    {
        public Mesero(string nombre, int id) : base(nombre, id) { }

        public void RealizarActividad()
        {
            Console.WriteLine($"{Nombre} está atendiendo a los clientes.");
        }

        public void TomarOrden(Orden orden)
        {
            Console.WriteLine($"Mesero {Nombre} ha tomado la orden #{orden.Id} del cliente {orden.NombreCliente}");
            orden.Estado = EstadoOrden.EnProceso;
        }
    }
}
