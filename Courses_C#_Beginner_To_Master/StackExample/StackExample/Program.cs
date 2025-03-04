using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Array array = stack.ToArray();
            Console.WriteLine(stack.Count);
            int count = stack.Count;
            bool contain = stack.Contains(count);
            Console.WriteLine(contain);
            for (int i = 0; i < count; i++)
            {
                int x = stack.Pop();
                Console.WriteLine(stack.Count);
                Console.WriteLine(x);
            }
            
            foreach(int i in array) 
                Console.WriteLine(i);
        }
    }
}
