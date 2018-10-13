using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            BigNumer big = -10;
            big.Multiply(2);
            big = "-13";
            big.Multiply(2L);
            Console.WriteLine(big.ToString());
            Console.Read();
        }
    }
}
