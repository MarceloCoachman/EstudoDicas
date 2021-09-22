using System;

namespace Positivos_e_Média
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b = 0, avg;
            int postive = 0;

            for (int i = 0; i < 6; i++ )
            {
                a = double.Parse(Console.ReadLine());

                if ( a > 0 )
                {
                    postive += 1;
                    b += a;
                }
            }
            avg = b / postive;
            Console.WriteLine(avg);
            Console.WriteLine("{0} valores positivos", postive);
            //Console.WriteLine("{0:f1}",avg);
            //Console.WriteLine("{0}", Math.Round(avg, 1);
            //Console.WriteLine("{0}", Math.Round(avg, 1, MidpointRounding.AwayFromZero).ToString("0.0"));
            //Console.WriteLine("{0}", Math.Round(avg, 1, MidpointRounding.ToEven).ToString("0.0"));
            Console.ReadLine();
        }

    }
}
