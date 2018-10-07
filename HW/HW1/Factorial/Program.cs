using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    class Program
    {
        const int Dozen = 10;

        public static FactorialModel Factorial(int n)
        {
            int[] values = new int[99999999];
            values[0] = 1;
            int values_size = 1;
            for (int x = 2; x <= n; x++)
            {
                values_size = Multiply(x, values, values_size);
            }
            return new FactorialModel(values, values_size);
        }

        public static int Multiply(int x, int[] values, int values_size)
        {
            int carry = 0;
            for (int i = 0; i < values_size; i++)
            {
                int multiplied = values[i] * x + carry;
                values[i] = multiplied % Dozen;
                carry = multiplied / Dozen;
            }
            while (carry != 0)
            {
                values[values_size] = carry % Dozen;
                carry = carry / Dozen;
                values_size++;
            }
            return values_size;
        }
        private static void ViewFactorial(FactorialModel view)
        {
            for (int i = view.Size - 1; i >= 0; i--)
            {
                Console.Write(view.Values[i]);
            }
        }

        static void Main(string[] args)
        {
            ViewFactorial(Factorial(1000));
            Console.Read();
        }
    }
}
