using System;

namespace Tipo_de_Combustível
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a=0, g=0, d=0, c = 0;
            do
            {
                

                 c = Convert.ToInt32(Console.ReadLine());

                switch (c)
                {
                    case 1: //Álcool
                         a++;
                        break;
                    case 2: //Gasolina
                        g++;
                        break;
                    case 3: //Disel
                         d++;
                        break;
                    case 4: //Fim
                        
                        break;
                    default:  
                        continue;
                }
            }

            while ( c != 4);
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: {0}", a);
            Console.WriteLine("Gasolina: {0}", g);
            Console.WriteLine("Diesel: {0}", d);

        }

    }
}



using System; 

class URI
{

    static void Main(string[] args)
    {

        do
        {


                 = Convert.ToInt32(Console.ReadLine());

            switch ()
            {
                case 1:

                case 2:

                case 3:

                case 4:

                    break;
                default:
                    continue;
            }
        }

        while ( );

    }

}