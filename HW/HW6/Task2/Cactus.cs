using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_T2
{
    class Cactus : IPriceable
    {
        public int Price { get; private set; }

        public Cactus(int price)
        {
            Price = price;
        }
    }
}
