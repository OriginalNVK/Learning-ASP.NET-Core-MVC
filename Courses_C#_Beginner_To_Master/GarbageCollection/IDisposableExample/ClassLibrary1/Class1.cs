using System;

namespace ClassLibrary1
{
    public class Sample: System.IDisposable
    {
        // constructor
        public Sample()
        {
            Console.WriteLine("Database Connected");
        }

        //method
        public void DisplayDataFromDatabase()
        {
            Console.WriteLine("Reading data from database");
        }

        public void Dispose()
        {
            Console.WriteLine("Database disconnected");
        }

    }
}
