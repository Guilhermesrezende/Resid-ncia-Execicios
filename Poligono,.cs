using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class Poligno
    {
        public Vertice a { get; set; }
        public Vertice b { get; set; }
        public Vertice c { get; set; }

        public Poligno(Vertice a, Vertice b, Vertice c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }


    }
}
