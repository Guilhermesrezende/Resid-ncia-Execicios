using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;



namespace Aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            double x1 = 12;
            double x2 = 13;
            double y1 = 11;
            double y2 = 10;
            double RetornoPerimetro = 0;
            double RetoArea = 0;

            Piramide N2 = new Piramide();
            N2.Desenha();

            Vertice vertice1111 = new  Vertice(10,11);

            vertice1111.Distancia(x1,x2,y1,y2);

            vertice1111.Move (x2, y2);

            vertice1111.Igual();

            Triangulo N = new Triangulo( x1, y1, y2);
            N.Area();

            RetornoPerimetro= N.Perimetro(x1, y1, y2);
            Console.WriteLine(RetornoPerimetro);

            N.trian(10, 11, 13);
            Console.WriteLine();

            RetoArea = N.RetornaArea(RetornoPerimetro/2,10,15,13);
            Console.WriteLine(RetoArea);

            Console.ReadLine();

            



        }
    }
}
