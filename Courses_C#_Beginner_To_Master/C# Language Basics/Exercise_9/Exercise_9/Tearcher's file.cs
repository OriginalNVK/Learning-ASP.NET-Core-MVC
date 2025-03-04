class LoopsAssignment
{
    static void Main()
    {
        //loop for first 3 lines
        for (int i = 0; i < 3; i++)
        {
            //Print a line with 1 to 10 numbers (except 5 and 6)
            for (int j = 1; j < 11; j++)
            {
                //skip numbers 5 and 6 in line 1, 2, 3
                if (j == 5 || j == 6)
                {
                    continue;
                }
                System.Console.Write(j + " ");
            }
            System.Console.WriteLine();
        }

        //loop for line 4, 5, 6, 7, 8
        for (int i = 0; i < 5; i++)
        {
            //print 10 to 1 numbers in line 4, 5, 6, 7, 8
            for (int j = 10; j >= 1; j--)
            {
                if (i == 2) //line 6
                {
                    //skip numbers 2 and 1 in line 6
                    if (j == 2 || j == 1)
                    {
                        continue;
                    }
                }

                if (i == 4) //line 8
                {
                    //skip output '8' in line 8
                    if (j == 3)
                    {
                        continue;
                    }

                    //print '1' instead of '10'; '2' instead of '11' and so on up to '10' instead of '1'.
                    System.Console.Write((11 - j) + " ");
                    continue;
                }

                //line 4, 5, 7
                System.Console.Write(j + " ");
            }
            System.Console.WriteLine();
        }

        System.Console.ReadKey();
    }
}
