using System;

namespace O_Maior
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            //complete declarando as variáveis
            int a = Int32.Parse(vet[0]);
            int b = Int32.Parse(vet[1]);
            int c = Int32.Parse(vet[2]);

            int MAIORAB = (a + b +Math.Abs(a - b)) / 2;

            int MAIOR = (MAIORAB + c + Math.Abs(MAIORAB - c)) / 2;

            Console.WriteLine($"{MAIOR} eh o maior");

        }
    }
}
