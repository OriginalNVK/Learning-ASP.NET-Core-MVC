using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(1000);   
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            int count = queue.Count;
            //Console.WriteLine(count);
            int[] array = queue.ToArray();
            foreach(int x in array)
            {
                Console.WriteLine(x);
            }
            queue.TrimExcess();
            int count2 = queue.Count;
            //Console.WriteLine(count2);
            int[] array2 = new int[queue.Count];
            queue.CopyTo(array2, 0);
            foreach(int x in array2)
            {
                Console.WriteLine(x);
            }
            bool exists = queue.Contains(4);
            Console.WriteLine(exists);
            for(int i = 0; i < count; i ++)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
