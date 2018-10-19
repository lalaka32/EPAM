using System;
using System.Collections.Generic;
using System.Linq;

namespace Net18MarfitinLesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>(1,20);
            list.Add(2);
            list.Add(2);
            list.Add(2);
            list.Add(2);
            list.Add(2);

            Console.WriteLine(list.Capacity);
            list.Add(3, 2);
            Console.WriteLine(list.GetValue(4));

            Console.WriteLine(list.Capacity);
            
            Console.ReadKey();
        }
    }
}
