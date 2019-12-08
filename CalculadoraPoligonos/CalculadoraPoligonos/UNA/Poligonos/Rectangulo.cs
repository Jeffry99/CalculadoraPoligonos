using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Rectangulo : Poligono
    {
        public double Base
        {
            get;
            set;
        }

        public double Altura
        {
            get;
            set;
        }

        public override double CalcularArea()
        {
            return Base * Altura;
        }

        public override double CalcularPerimetro()
        {
            return Base * 2 + Altura * 2;
        }
    }
}