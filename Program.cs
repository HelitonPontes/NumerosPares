using System;

namespace NumerosPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int intInicial = 1;
            int intFinal = 100;

            for (int x = intInicial; x <= intFinal; x++)
            {
                //Se quiser imprimir os pares
                if (x % 2 == 0)  //ou if (x % 2 == 1) //Se quiser imprimir os impares
                {
                    Console.WriteLine(x);

                    
                }
                //Console.ReadKey();
            }
        }
    }
}
