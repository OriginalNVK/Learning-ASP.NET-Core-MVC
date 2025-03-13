using System;
// delegate: (type) bien = phuong thuc 

namespace Bai20_Delegate
{
    public delegate void ShowLog(string message);
    class Program
    {

        static void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Info: " + message);
            Console.ResetColor();
        }
        
        static void Warning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Warning: " + message);
            Console.ResetColor();
        }

        static int Tong(int a, int b)
        {
            return a + b;
        }

        static int Hieu(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            // ShowLog log = new ShowLog(Info);
            // // if (log != null)
            // // {
            // //     log("Xin chao");
            // // } // delegate co the tham chiu den nhieu phuong thuc cung luc

            // log+= Warning;

            // log?.Invoke("Hello");

            //Action, Func: delegate - generic
            // Action action; // delegate void KIEU();
            // Action<string, int> action1; // delegate void KIEU(string, int);
            // Action<string> action2;
            // action2 = Warning;
            // action2 += Info;
            // action2?.Invoke("Thong bao tu Action");


            // Function
            Func<int> f1; // delegate int KIEU();
            Func<string, int, string> f2; // delegate string KIEU(string, int); 
                                          // Func thi phai co kieu tra ve va kieu tra ve la tham so cuoi cung
            Func<int, int, int> f3;
            f3 = Tong;
            f3 += Hieu;
            Console.WriteLine(f3?.Invoke(5, 3));    

        }
    }
}