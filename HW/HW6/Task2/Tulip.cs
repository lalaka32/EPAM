using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_T2
{
    class Tulip : IPriceable
    {
        public int Price { get; private set; }

        public Tulip(int price)
        {
            Price = price;
        }
    }
}
