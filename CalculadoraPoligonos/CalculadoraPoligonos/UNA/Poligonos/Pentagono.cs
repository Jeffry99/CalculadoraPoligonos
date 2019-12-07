using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Pentagono : Poligono
    {
        public int Lado
        {
            get;
            set;
        }

        public int Apotema
        {
            get;
            set;
        }

        public override double CalcularArea()
        {
            return (CalcularPerimetro() * Apotema) / 2;
        }

        public override double CalcularPerimetro()
        {
            return Lado * 5;
        }
    }
}