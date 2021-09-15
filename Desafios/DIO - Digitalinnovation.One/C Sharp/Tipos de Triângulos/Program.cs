using System;

namespace Tipos_de_Triângulos
{
    class Program
    {
        public static void Main()
        {
            string[] s = Console.ReadLine().Split(' ');
            double a = double.Parse(s[0]);
            double b = double.Parse(s[1]);
            double c = double.Parse(s[2]);
            double t; // temporaria para ordenação

            
            if (b > a && b > c)
            {
                t = a;
                a = b;
                b = t;
            }
            else if (c > a)
            {
                t = a;
                a = c;
                c = t;
            }
            //continue a solucao
            if (a >= ( b + c ))
                Console.WriteLine("NAO FORMA TRIANGULO");
            else if (( a * a ) == ( b * b + c * c ))
                Console.WriteLine("TRIANGULO RETANGULO");
            else if (( a * a ) > ( b * b + c * c ))
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else if (( a * a ) < ( b * b + c * c))
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if ( a == b && b == c )
                Console.WriteLine("TRIANGULO EQUILATERO");
            if ((a == b && a != c) || (a == c && a != b) || (b == c && a != c))
                Console.WriteLine("TRIANGULO ISOSCELES");

            //Console.ReadLine();
        }
    }
}
