using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Circulo : Poligono
    {
        public const double PI = 3.14159265358979;
        public double Radio
        {
            get;
            set;
        }

        public override double CalcularArea()
        {
            return PI*Radio*Radio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * PI * Radio;
        }
    }
}