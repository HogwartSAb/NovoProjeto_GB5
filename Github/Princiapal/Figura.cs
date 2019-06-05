using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace principal
{
    abstract class Figura
    {
        private string nome;
        private string cor;

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
