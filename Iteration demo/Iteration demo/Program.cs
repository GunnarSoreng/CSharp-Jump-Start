using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0, j=0; i < 10; i++, j+=10)
            {
                Console.WriteLine("  {0} - {1}",i ,j);
            }
            Console.WriteLine();

            var list = new[] { 1, 2, 3, 4, 5, 6, 7 };
            //var list3 = new int[7] { 1, 2, 3, 4, 5, 6, 7 };

            // kan også skrives fullt ut på denne måten:

            //int[] list2 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            foreach (var item in list)
            {
                Console.Write("  {0}", item);


                // Sjekk for partall, '%' er modulus operator, gir restverdi ved deling.
                if (item %  2 == 0)
                {
                    Console.WriteLine();
                    // Hopper ut til neste iterasjon i løkken hvis true (partall)
                    continue;

                }
                Console.WriteLine(" - oddetall");

                // Hopper ut av løkken hvis 5
                if (item == 5)
                    break;

                // Hopper helt ut av metoden hvis 6:
                if (item == 6)
                {
                    Console.ReadLine();
                    return;

                }

                /*
                // Kan også hoppe helt ut av applikasjonen (hvis denne excetion ikke er håndtert annet sted.): 
                if (item == 7)
                    throw new Exception();
                    */


            }
            Console.WriteLine("  Etter løkken.");
            Console.ReadLine();
        }
    }
}
