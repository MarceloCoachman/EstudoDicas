using System;

namespace Média_do_Automóvel
{
    class Program {
        static void Main(string[] args) {

            int distancia;
            double combustivelGasto, consumoMedio;

            distancia = Convert.ToInt32(Console.ReadLine());
            combustivelGasto = Convert.ToDouble(Console.ReadLine());

            consumoMedio =  distancia/(.1*combustivelGasto); //atribua a formula para que o codigo funcione corretamente

            Console.WriteLine("{0:0.000} km/l", consumoMedio);

        }

    }
}