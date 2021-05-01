using System;

    class Validacaodenotas
    {
        static void Main() {

        double x=0;
        int i=0;
        bool caso;

        while (i < 2 ) {

            caso = true;
            double nota = double.Parse(Console.ReadLine());

            if ( nota < 0 || nota > 10 ) {
                Console.WriteLine("nota invalida");

            } else if ( i == 0 ) {
                x = nota;
                i++;
           
            } else if ( i == 1 ) {
                    double media = (x + nota)/2;
                    Console.Write("media = ");
                    Console.WriteLine(media.ToString("N2"));
                    Console.WriteLine();
                
                    while ( caso == true ){
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    double op = double.Parse(Console.ReadLine());
            
                        if ( op == 1 ) {
                            caso = false;
                            i = 0;
                    
                        } else if ( op == 2 ) {
                            caso = false; 
                            i++;
                        }
                    }
                } 
            }
        }
    }
