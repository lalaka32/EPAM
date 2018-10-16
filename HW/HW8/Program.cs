using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8
{
    class Program
    {
        private static void Main()
        {
            IEnumerable<string> res = SlogParser.GetSlogs("пороход");
            foreach (string re in res)
                Console.Write(re);
            Console.ReadKey();
        }

        
    }
}
