using System;

namespace Programa_para_Validação_de_Notas
{
    class Programa_para_Validação_de_Notas_Resolvido
    {
        static void Main()
        {
            double x,y, media;
            int op=0;
            
            while (op != 1 || op != 2)
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                op = int.Parse(Console.ReadLine());
            }
                        
            if (op == 2) return;
            

            if ((op == 1))
            {           
                x = int.Parse(Console.ReadLine());
                    if ( x < 0 || x > 10 ){
                        Console.WriteLine("nota invalida");
                        return;
                    }

                y = int.Parse(Console.ReadLine());
                    if ( y < 0 || y > 10 ){
                        Console.WriteLine("nota invalida");
                        return;
                    }
            media = (x+y)/2;

            Console.Write("media = ");
            Console.WriteLine(media.ToString("N2"));
                    
                return;    
                   
            }     
        }        
    }
}