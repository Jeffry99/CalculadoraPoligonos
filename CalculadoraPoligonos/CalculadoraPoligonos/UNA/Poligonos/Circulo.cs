using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Circulo : Poligono
    {
        public double Radio
        {
            get;
            set;
        }

        public override double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }
}