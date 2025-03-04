using System;
using System.Collections.Generic;
using System.Collections;

namespace ArrayList2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList() { 1, 2, 3};

            ArrayList list2  = new ArrayList(list);

            list.Add("Original NVK");
            List<string> list3 = new List<string>() { "Nguyen", "Van", "Khanh" };

            list.AddRange(list3);

            foreach(var s in list)
            {
                Console.WriteLine(s);
            }

            list.RemoveRange(0, 3);
            foreach (var s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
