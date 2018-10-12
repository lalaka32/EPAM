using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_T2
{
    class PriceSummer
    {
        public static int GetSum(IEnumerable<IPriceable> priceables )
        {
            int sum = 0;
            foreach (IPriceable item in priceables)
            {
                sum += item.Price;
            }
            return sum;
        }
    }
}
