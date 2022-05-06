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

            //Console.Write("enter the level:");
            //num = Convert.ToInt32(Console.ReadLine());
            //for (i = 1; i <= num; i++)
            //{
            //    for (j = 1; j < num - i + 1; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (k = 1; k <= i; k++)
            //    {
            //        Console.Write(i);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();

            //}

            //Console.WriteLine("enter a number:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int x = i; x <= n; x++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*" + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
            //int N = 0;
            //Console.Write("Digite o Vertice: ");
            //N = int.Parse(Console.ReadLine());


            // Piramide N;

            // N = new Piramide();

            //int num, i, j, k;

            //int n,x, largura, esp, numero;

            //  Console.Write("Digite o tamanho da Piramide: ");

            //  n = Convert.ToInt32(Console.ReadLine());

            //   x = n;

            // for (largura = 1; largura <= n; largura++)
            // {
            //     for (esp = 0; esp < n - largura; esp++)
            //     {
            //         Console.Write(" ");
            //     }
            //     for (numero = 0; numero < (largura * 2) - 1; numero++)
            //     {
            //         if (numero == 0)
            //             Console.Write(1);
            //         if (numero == 1)
            //         {
            //             if (largura == 2)
            //                 Console.Write(largura);
            //             else
            //            if (largura == 3)
            //                 Console.Write(largura - 1);
            //         }
            //         if (numero == 2)
            //             Console.Write(numero - 1);

            //     }
            //     Console.WriteLine();
            // }
            // Console.ReadKey();

            // //if(n == 1)
            // //    Console.Write(1);
            // //if (n == 2)
            // //{
            // //    largura = n;
            // //    for (esp = 0; esp < n - largura; esp++)
            // //    {
            // //        Console.Write(" ");
            // //    }
            // //    for (numero = 0; numero < (largura * 2) - 1; numero++)
            // //    {
            // //        if (numero <2 )
            // //        Console.Write(numero +1);

            // //    }
            // //    Console.WriteLine();
            // //}

            // //    for (largura = 1; largura <= n; largura++)
            // //{
            // //    for (esp = 0; esp < n - largura; esp++)
            // //    {
            // //        Console.Write(" ");
            // //    }
            // //    for (numero = 0; numero < (largura * 2) - 1; numero++)
            // //    {
            // //        if (numero == 0)
            // //            Console.Write(1);
            // //        if (numero == 1)
            // //        {
            // //            if (largura == 2)
            // //                Console.Write(largura);
            // //            else
            // //           if (largura == 3)
            // //                Console.Write(largura - 1);
            // //        }
            // //        if (numero == 2)
            // //            Console.Write(numero - 1);

            // //    }
            // //Console.WriteLine();
            // // }

            // //  Console.ReadKey();



        }
    }
}
