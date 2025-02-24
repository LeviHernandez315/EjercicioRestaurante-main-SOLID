using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioRestaurante_main_SOLID.Diccionarios;
using EjercicioRestaurante_main_SOLID.Interfaces;

namespace EjercicioRestaurante_main_SOLID.Models
{
    public abstract class Personal: IRegistro, IConsultaMarcaciones
    {
        public string Nombre { get; set; }
        public int Id { get; set; }
        protected List<Marcacion> Marcaciones;

        protected Personal(string nombre, int id)
        {
            Nombre = nombre;
            Id = id;
            Marcaciones = new List<Marcacion>();
        }

        public virtual void RegistrarMarcacion(TipoMarcacion tipo)
        {
            var marcacion = new Marcacion(Nombre, tipo);
            Marcaciones.Add(marcacion);
            Console.WriteLine(marcacion);
        }

        public List<Marcacion> ObtenerMarcaciones()
        {
            return new List<Marcacion>(Marcaciones);
        }
    }
}
