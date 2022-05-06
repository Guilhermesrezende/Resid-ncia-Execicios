using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula1
{
    public class Piramide
    {
        public int N = 0;

        public Piramide()
        {
            if (N >= 1)
            {



            }
            if (N < 1)
            {
                Console.WriteLine("Excecao");
            }
        }
        public void Desenha()
        {
            int N = 0;
            Console.Write("Digite o nnumero da Piramide: ");
            N = int.Parse(Console.ReadLine());

            int a, b;

            for (int i = 1; i <= N; i++)
            {
                for (a = 1; a <= (N - i); a++)
                    Console.Write(" ");
                for (b = 1; b <= i; b++)
                    Console.Write(b);
                for (b = (i - 1); b >= 1; b--)
                    Console.Write(b);
                Console.WriteLine();
            }
        }




    }
}

