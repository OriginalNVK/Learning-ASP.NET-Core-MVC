using namespace1;
using System;

namespace MultipleDelegateExample
{
    internal class Program
    {
        static void Main()
        {
            Sample s = new Sample();

            MyMultipleDelegate myMultiple = s.Add;
            myMultiple += s.Multiple;
            myMultiple.Invoke(40, 10);  
        }
    }
}
