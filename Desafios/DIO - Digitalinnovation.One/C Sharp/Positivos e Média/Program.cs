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

//leia 6 valores.em seguida, mostre quantos destes valores digitados foram positivos. na próxima linha,
//    deve-se mostrar a média de todos os valores positivos digitados, com um dígito após o ponto decimal.

//entrada
//a entrada contém 6 números que podem ser valores inteiros ou de ponto flutuante. pelo menos um destes números será positivo.

//saída
//o primeiro valor de saída é a quantidade de valores positivos. a próxima linha deve mostrar a média dos valores positivos digitados.

 
//exemplo de entrada	
//7
//-5
//6
//-3.4
//4.6
//12

//exemplo de saída
//4 valores positivos
//7.4