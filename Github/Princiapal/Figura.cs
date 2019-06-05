using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Princiapal
{
    abstract class Figura
    {
        private string nome;
        private string cor;

        Figura() { }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        abstract public double Area();


    }
}
