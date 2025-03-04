using System;
using System.Collections.Generic;

namespace HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> list = new HashSet<int>{1, 2, 3};
            HashSet<int> list2 = new HashSet<int> { 3, 2, 4};
            bool exist = list.Contains(2);
            Console.WriteLine(exist);

            bool isSubSet = list.IsSupersetOf(list2);
            Console.WriteLine(isSubSet);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
