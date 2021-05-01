using System;

namespace CoxinhaDeBueno
{
    class CoxinhaDeBuenoResolvido
    {
        static void Main()
        {
            String[] line = Console.ReadLine().Split(" ");
        
            float a = Int32.Parse(line[0]);
            float b = Int32.Parse(line[1]);
        
            float total = (a / b);
        
            if (a % b != 0)
                Console.WriteLine(Math.Round(total, 2).ToString("0.00"));
            
            else
                Console.WriteLine(total.ToString("0.00"));

        }
    }
}