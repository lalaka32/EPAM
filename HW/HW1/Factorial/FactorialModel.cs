using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    class FactorialModel
    {
        public FactorialModel(int[] value, int size)
        {
            Values = value;
            Size = size;
        }

        public int[] Values { get; private set; }
        public int Size { get; private set; }

    }
}
