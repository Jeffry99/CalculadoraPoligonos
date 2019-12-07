using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Cuadrado : Poligono
    {
        public int Lado
        {
            get;
            set;
        }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }

        public override double CalcularPerimetro()
        {
            return Lado * 4;
        }
    }
}