﻿using System;
using System.Globalization;

namespace Coordenadas_de_um_Ponto
{
    class Program
    {
        static void Main(string[] args)
        {
            //complete os espaços em branco com sua solução para o problema

            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if ( x == 0.0 && y == 0.0  )
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0  )
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0  )
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0   && y >  0.0  )
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }

        }

    }
}
