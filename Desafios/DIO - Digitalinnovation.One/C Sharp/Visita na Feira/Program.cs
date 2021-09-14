using System;

namespace Visita_na_Feira
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x;
            string[] valores = Console.ReadLine().Split();
            a = Convert.ToInt32(valores[0]);
            b = Convert.ToInt32(valores[1]);

            x = a + b; //complete o código de acordo com o cálculo esperado

            Console.WriteLine("X = {0}", x);
        }
    }
}
