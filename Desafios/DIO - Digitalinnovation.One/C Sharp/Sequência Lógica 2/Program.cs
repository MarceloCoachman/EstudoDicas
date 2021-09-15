using System;

namespace Sequência_Lógica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] vet = Console.ReadLine().Split(" ") ;
            int x = Int32.Parse(vet[0]); // itens por linha 
            int y = Int32.Parse(vet[1]); // numero total
            
            //complete o código com sua solução

            for ( int i = 1; i <=  y; i++ )
            {
                Console.Write(i);
                if (i % x == 0             )
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }
}

