using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class Triangulo
    {
        public double x { get; set; }
        public double y { get; set; }
        public double a { get; set; }

        public Triangulo(double x, double y, double a)
        {
            this.x = x;
            this.y = y;
            this.a = a;
           
        }
        public double Area()
        {
            double p = (this.x + this.y  + this.a) / 2.0;
            return Math.Sqrt(p * (p - this.x) * (p - this.y) * (p - this.a));
        }
        public double Perimetro(double a, double b, double c)
        {
            return (a + b + c);

        }
        public enum Tipo
        {
            equilatero,
            isosceles, 
            escaleno
        }


        public void trian(int a, int b, int c)
        {


            if (a == b && b == c)
            {              

                Console.Write(Tipo.equilatero);
            }
            else if (a == b || a == c || b == c)
            {
                Console.Write(Tipo.isosceles);
            }
            else
            {
                Console.Write(Tipo.escaleno);
            }
            
            
        }
        public double RetornaArea(double S, double a, double b, double c)
        {
            return Math.Sqrt( S * (S - a) * (S - b) * (S - c));

        }



    }
}
