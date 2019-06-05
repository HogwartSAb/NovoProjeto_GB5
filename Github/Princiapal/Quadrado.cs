using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFigura
{
    class Quadrado : Figura
    {
        private double lado;

        public double Lado { set => lado = value; }

        override public double Area()
        {
            return (lado * lado);
        }
    }
}