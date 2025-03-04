using System;
using ClassLibrary1;

namespace IDisposableExample
{

    internal class Program
    {
        static void Main()
        {
            //Create object using "using structure
            using(Sample s = new Sample())
            {
                s.DisplayDataFromDatabase();
            }

            Console.WriteLine("Some other work");
            Console.ReadKey();
        }
    }
}
