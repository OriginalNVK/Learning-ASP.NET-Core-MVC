using System;
using namespace1;

namespace DelegateExample
{
    internal class Program
    {
        static void Main()
        {
            Sample s = new Sample();

            MyDelegateType myDelegate;
            myDelegate = new MyDelegateType(s.add);
            Console.WriteLine(myDelegate.Invoke(30, 40));
            Console.ReadKey();
        }
    }
}
