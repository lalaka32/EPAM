using System;
using System.Collections.Generic;
using System.Linq;

namespace Net18MarfitinLesson2
{
    class Program
    {

        static void Main(string[] args)
        {
            Polynom firstPolinom =  new Polynom( new int[]{ 1, 0, -4, -100 });
            Polynom secondPolinom = new Polynom(new int[] { -21, 0, -4, -100 });

            ViewPolynom(firstPolinom.arguments);
            ViewPolynom(secondPolinom.arguments);
            ViewPolynom(firstPolinom.SumOfPolynoms(secondPolinom).arguments);
            Console.Read();
        }

        
        private static void ViewPolynom(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] < 0)
                {
                    Console.Write("{0}*x^{1} - ", Math.Abs(nums[i]), i);
                }
                else
                {
                    Console.Write("{0}*x^{1} + ", Math.Abs(nums[i]), i);
                }
            }
            Console.WriteLine("{0}*x^{1} ", Math.Abs(nums.Last()), nums.Length);
        }
    }
}
