using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPriceable> Bouquet =  new List<IPriceable>{
                new Rose(10),
                new Rose(11),
                new Cactus(20),
                new Tulip(5),
                new Carnation(7)
            };
            Console.WriteLine(PriceSummer.GetSum(Bouquet));
            Console.Read();
        }
    }
}
