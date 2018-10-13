using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class BigNumer
    {
        const int DOZEN = 10;

        public int[] Values { get; private set; } 
        public int Size { get; private set; }
        public bool IsNegative { get; set; }

        public static implicit operator BigNumer(long d)
        {
            return new BigNumer(d);
        }

        public static implicit operator BigNumer(string d)
        {
            return new BigNumer(d);
        }

        public BigNumer(long num)
        {
            StringInitilaze(num.ToString());
        }

        public BigNumer(string str)
        {

            StringInitilaze(str);
        }

        private void StringInitilaze(string num)
        {
            Values = new int[9999999];
            Size = num.Length;
            for (int i = num.Length - 1; i >= 0; i--)
            {
                try
                {
                    Values[num.Length - 1 - i] = Convert.ToInt32(num[i].ToString());
                }
                catch (FormatException ex)
                {
                    Size--;
                }
            }
            if (num.Contains("-")&& Size>0)
            {
                IsNegative = true;
            }
        }

        public BigNumer Multiply(long x)
        {
            long carry = 0;
            for (int i = 0; i < Size; i++)
            {
                long multiplied = Values[i] * x + carry;
                Values[i] = (int)(multiplied % DOZEN);
                carry = multiplied / DOZEN;
            }
            while (carry != 0)
            {
                Values[Size] = (int)(carry % DOZEN);
                carry = carry / DOZEN;
                Size++;
            }
            return this;
        }

        public override string ToString()
        {
            string str = "";
            if (IsNegative)
            {
                str += "-";
            }
            for (int i = Size - 1; i >= 0; i--)
            {
                str += Values[i];
            }
            return str;
        }
    }
}
