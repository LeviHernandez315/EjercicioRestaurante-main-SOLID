using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioRestaurante_main_SOLID.Diccionarios;
using EjercicioRestaurante_main_SOLID.Interfaces;

namespace EjercicioRestaurante_main_SOLID.Models
{
    public class Cocinero: Personal, IActividad
    {
        public Cocinero(string nombre, int id) : base(nombre, id) { }

        public void RealizarActividad()
        {
            Console.WriteLine($"{Nombre} está cocinando órdenes.");
        }

        public void PrepararOrden(Orden orden)
        {
            Console.WriteLine($"Cocinero {Nombre} está preparando la orden #{orden.Id}:");
            orden.Estado = EstadoOrden.EnCocina;

            orden.Estado = EstadoOrden.Lista;
            Console.WriteLine($"Orden #{orden.Id} lista para entrega");
        }
    }
}
