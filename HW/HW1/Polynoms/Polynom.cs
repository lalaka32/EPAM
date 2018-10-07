using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net18MarfitinLesson2
{
    class Polynom
    {
        public int[] arguments { get; private set; }

        public Polynom(int[] arguments)
        {
            this.arguments = arguments;
        }
        public Polynom SumOfPolynoms(Polynom firstPolynom)
        {
            Polynom sumOfPolinoms = new Polynom(new int [Math.Max(firstPolynom.arguments.Length, arguments.Length)]);

            for (int i = 0; i < firstPolynom.arguments.Length; i++)
            {
                sumOfPolinoms.arguments[i] += firstPolynom.arguments[i];
            }
            for (int i = 0; i < arguments.Length; i++)
            {
                sumOfPolinoms.arguments[i] += arguments[i];
            }
            return sumOfPolinoms;
        }
    }
}
