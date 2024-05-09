using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClases.Garage
{
    public class Coche : IAlquilable
    {
        public string Identificador { get; set; }
        public double PrecioHora { get; set; } = 4;
        public double Tiempo { get; set; }

        public double DameCoste()
        {
            return PrecioHora * Tiempo;
        }

        public override string? ToString()
        {
            return $"Hola soy un coche con precioHora {this.PrecioHora}";
        }
    }
}
