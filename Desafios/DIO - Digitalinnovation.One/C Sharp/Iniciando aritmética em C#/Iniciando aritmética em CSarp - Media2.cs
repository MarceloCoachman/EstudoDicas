using System;


    class Media2
    {
        static void Main(string[] args)
        {
            double A, B, C, mediaP;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            mediaP = ((A*2)+(B*3)+(C*5))/10;
            
            Console.WriteLine("MEDIA = {0}", mediaP.ToString("0.0"));
            //Console.ReadKey();
        }
    }
