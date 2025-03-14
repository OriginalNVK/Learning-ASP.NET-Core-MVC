using System;

namespace Bai21_Lambda
{
    /*
    Lambda - anonymous method hoac la anonymous function co the nhan nhung tham so dau vao giong function 
    1) (int a, int b) => bieu_thuc;
    2) (tham_so) => {
        Bieuthuc chi lenh;
    }

    co the gan cho mot bien kieu delegate nhung phai phu hop ve bien va kieu tra ve

    */
    public class Program
    {
        static void Main()
        {
            // Action<string> thongbao;
            // thongbao = (string s) => Console.WriteLine($"String {s}");

            // thongbao.Invoke("Hello");
            // (int a, int b) =>
            // {
            //     int kq = a + b;
            //     return kq;
            // };
            // Action thongbao;
            // thongbao = () => Console.WriteLine("Hello"); 
            // thongbao.Invoke(); 

            // Action<string, string> thongbao;
            // thongbao = (string s1, string s2) =>
            // {
            //     Console.ForegroundColor = ConsoleColor.Blue;
            //     Console.WriteLine($"Hello from {s1} to {s2}");
            //     Console.ResetColor();
            // };

            // thongbao.Invoke("Khanh", "Ha");  

            // Func<int, int, int> tinhTong;
            // tinhTong = (a, b) =>
            // {
            //     int kq = a + b;
            //     return kq;
            // };

            // // tinhTong.Invoke(3, 4);
            // Console.WriteLine(tinhTong.Invoke(3, 4));

            int[] mang = { 2, 4, 6, 8, 16, 32 };

            // var kq = mang.Select((int x) => Math.Sqrt(x));

            // foreach(var item in kq)
            // {
            //     Console.WriteLine(item);
            // }

            mang.ToList().ForEach(x =>
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
            });
            
        }


    }
}