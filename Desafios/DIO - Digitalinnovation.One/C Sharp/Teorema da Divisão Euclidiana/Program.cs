using System;

namespace Teorema_da_Divisão_Euclidiana
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int q, r;

            //complete o código aqui

            q = a / b;
            r = a % b;

            if (r < 0)
            {
                double Q, R = 0;

                R = r + Math.Sqrt(b * b);
                Q = (a - R) / b;
                Console.WriteLine("{0} {1}", Q, R);
                //Console.WriteLine("um");
            }
            else
            {
                Console.WriteLine("{0} {1}", q, r);
                //Console.WriteLine("dois");
            }
        }
    }
}
