using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDemo
{
    class Program
    {
        enum Dogs { Lassie, Snoopy, Yeller, Fido };
        static void Main(string[] args)
        {
            var snoopy = Dogs.Fido;
            switch (snoopy)
            {
                case Dogs.Lassie:
                    Console.WriteLine("Hi");
                    // Hvis ingenting her, faller swithch igjennom til neste case og gjør denne
                    break;
                case Dogs.Snoopy:
                    Console.WriteLine("Hi");
                    break;
                case Dogs.Yeller:
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
