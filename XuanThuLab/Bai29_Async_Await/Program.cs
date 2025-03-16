using System;

namespace Bai29
{
    // Lap trinh bat dong bo asynchronous: Tao ra ung dung co kha nang chay da luong
    // multi thread

    class Program
    {
        static void DoSomeThing(int second, string message, ConsoleColor color)
        {
            lock (Console.Out)
            {
                Console.ForegroundColor = color;
                Console.WriteLine("Start");
                Console.ResetColor();
            }

            for (int i = 0; i < second; i++)
            {
                lock (Console.Out)
                {
                    Console.ForegroundColor = color;
                    Console.WriteLine($"{message,10}: {i,2}");
                    Console.ResetColor();
                }
                Thread.Sleep(1000);
            }
            lock (Console.Out)
            {
                Console.ForegroundColor = color;
                Console.WriteLine("End");
                Console.ResetColor();
            }

        }

        static async Task Task1()
        {
            Task t1 = new Task(() => DoSomeThing(11, "Hello", ConsoleColor.Green));
            t1.Start();
            await t1; // giống phương thức wait nhưng không block thread
            // t1.Wait();
            Console.WriteLine("Task1 Complete");

        }

        static async Task Task2()
        {
            Task t2 = new Task(() => DoSomeThing(13, "Hello", ConsoleColor.Blue));
            t2.Start();
            // t2.Wait();
            await t2;
            Console.WriteLine("Task2 Complete");
            // return t2;
        }
        // Su dung tu khoa async va await 
        static void Main(string[] args)
        {
            // Console.ResetColor();
            // Synchronous
            // lap trinh dong bo: khi ung dung co nhieu tac vu, thi cac tac vu nay se thuc hien tuan tu
            // tac vu 1 thuc hien xong thi den tac vu 2
            // DoSomeThing(5, "Hello", ConsoleColor.Green);
            // DoSomeThing(3, "World", ConsoleColor.Red);
            // DoSomeThing(4, "C#", ConsoleColor.Yellow);
            // Console.WriteLine("End");

            // Asynchronous
            // lap trinh bat dong bo: khi ung dung co nhieu tac vu, thi cac tac vu nay se thuc hien song song
            // Task: Dung de bieu dien mot tac vu bat dong bo
            Task t1 = Task1();
            Task t2 = Task2();

            // t1.Start();// Thread khac
            // t2.Start();// Thread khac
            DoSomeThing(4, "C#", ConsoleColor.Yellow); // Main Thread
                                                       // khi main thread dung thi cac thread khac cung dung
                                                       // t1.Wait();
                                                       // t2.Wait();
                                                       // Co the thay bang
            Task.WaitAll(t1, t2);
            Console.WriteLine("End");
        }
    }
}