using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class Vertice
    {
        public float x { get; set; }
        public float y { get; set; }
        public double a { get; set; }
        public double b { get; set; }


        public Vertice(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Vertice()
        {
        }

        public void Distancia (double x1, double x2, double y1, double y2)
        {                       
                this.a = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
                Console.WriteLine(this.a);           
        }

        public void Move (double x2, double y2)
        {
            this.b = Math.Sqrt((Math.Pow(this.x - x2, 2) + Math.Pow(this.y - y2, 2)));
            Console.WriteLine(this.b);
        }
        public void Igual()
        {
           if (this.a != this.b)
            {
                Console.WriteLine("Diferente");
            }
            else
            {
                Console.WriteLine("Igual");
            }
            
        }


    }   
}
