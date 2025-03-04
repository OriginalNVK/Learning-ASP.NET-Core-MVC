using System;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float height = 5;
            float heightInCent = height * 2.54f;
            if(heightInCent < 150f)
            {
                Console.WriteLine("Dwarf");
            }    
            else if(heightInCent <= 165)
            {
                Console.WriteLine("Average Height");
            }    
            else if(heightInCent <= 195)
            {
                Console.WriteLine("Tall");
            }    
            else
            {
                Console.WriteLine("Abnormal height");
            }
        }
    }
}
