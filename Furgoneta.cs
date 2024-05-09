using ConsoleAppClases.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClases.Garage
{
    public class Furgoneta : IAlquilable
    {
        public string Identificador { get; set; }
        public double PrecioHora { get; set; } = 5;
        public double Tiempo { get; set; }

        public double dameCoste()
        {
            return PrecioHora * Tiempo;
        }

        public override string? ToString()
        {
            return $"Hola soy una Furgoneta con precioHora {this.PrecioHora}";
        }
    }
}
