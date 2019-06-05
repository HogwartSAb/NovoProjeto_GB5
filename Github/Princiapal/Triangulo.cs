using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace principal
{
    class Triangulo : Figura
    {
        private double alturaT;
        private double baseT;

        public double AlturaT { set => alturaT = value; }
        public double BaseT { set => baseT = value; }

        override public double Area()
        {
            return (baseT * alturaT) / 2;
        }
    }
}