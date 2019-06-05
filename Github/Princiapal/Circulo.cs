using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Princiapal
{
    class Circulo : Figura
    {
        private double raio;

        public double Raio { set => raio = value; }

        override public double Area()
        {
            return 3.14 * raio;
        }
    }
}
