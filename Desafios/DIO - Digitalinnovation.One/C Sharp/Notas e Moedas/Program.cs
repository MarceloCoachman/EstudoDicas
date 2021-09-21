using System;
using System.Globalization;

namespace Notas_e_Moedas
{
    class Program
    {
        static void Main(string[] args) {
            
            decimal inteiro;

            inteiro = decimal.Parse(Console.ReadLine());
                      
            Console.WriteLine("NOTAS:");
            Console.WriteLine("{0} nota(s) de R$ 100.00",((int)  inteiro/100));
            inteiro = inteiro % 100;
                        
            Console.WriteLine("{0} nota(s) de R$ 50.00", (int)inteiro /50);
            inteiro = (inteiro % 50);
                        
            Console.WriteLine("{0} nota(s) de R$ 20.00", (int)inteiro /20);
            inteiro = (inteiro % 20);
                        
            Console.WriteLine("{0} nota(s) de R$ 10.00", (int)inteiro /10);
            inteiro = (inteiro % 10);
                        
            Console.WriteLine("{0} nota(s) de R$ 5.00", (int)inteiro /5);
            inteiro = (inteiro % 5);
                        
            Console.WriteLine("{0} nota(s) de R$ 2.00", (int)inteiro /2);
            inteiro = (inteiro % 2);

            inteiro *= 100;
            Console.WriteLine("MOEDAS:");
            Console.WriteLine("{0} moeda(s) de R$ 1.00", (int)inteiro / 100);
            inteiro %= 100;
            
            Console.WriteLine("{0} moeda(s) de R$ 0.50", (int)inteiro / 50);
            inteiro %= 50;
                        
            Console.WriteLine("{0} moeda(s) de R$ 0.25", (int)inteiro / 25);
            inteiro %= 25;
                        
            Console.WriteLine("{0} moeda(s) de R$ 0.10", (int)inteiro / 10);
            inteiro %= 10;
                        
            Console.WriteLine("{0} moeda(s) de R$ 0.05", (int)inteiro / 5);
            inteiro %= 5;
                        
            Console.WriteLine("{0} moeda(s) de R$ 0.01", (int)inteiro / 1);
           
            //complete o codigo

    }

}
}
