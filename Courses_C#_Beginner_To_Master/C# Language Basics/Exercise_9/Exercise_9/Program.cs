using System;

class program
{
    static void Main()
    {
        for(int i = 0; i < 3; i++)
        {
            for(int j = 1; j <= 10; j++)
            {
                if(j == 5 || j == 6)
                {
                    continue;
                }    
                Console.Write(j + " ");
            }    
            Console.WriteLine();
        }
        for (int i = 0; i < 2; i++)
        {
            for (int j = 10; j >= 1; j--)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
        for(int i = 10; i >= 0; i--)
        {
            if (i == 2)
                break;
            Console.Write(i + " ");
        }
        Console.WriteLine();

        for (int i = 10; i >= 1; i--)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        for(int i = 1; i <= 10; i++)
        {
            if (i == 8) continue;
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}