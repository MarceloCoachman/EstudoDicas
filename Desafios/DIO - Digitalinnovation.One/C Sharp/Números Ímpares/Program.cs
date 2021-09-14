using System;

namespace Números_Ímpares
{
    class Program
    {
        public static void Main()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            //complete seu codigo
            for ( int j = 1;j <= n; j++ ) //complete seu codigo
            {
                if (j%2 != 0)
                Console.WriteLine(j);
            }

            
        }

    }
}
