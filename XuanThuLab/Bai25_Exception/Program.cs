using System;
using System.Globalization;

namespace Bai25
{
    class Program
    {
        class phepChia
        {
            public double a;
            public double b;

            public phepChia(double a, double b)
            {
                this.a = a;
                this.b = b;
            }   
            public double chia()
            {
                if (b == 0)
                {
                    throw new Exception("Chia cho 0 mat roi");

                }
                return a / b;
            }
        }
        static void Main(string[] args)
        {
            double a = 4;
            double b = 0;
            // exception
            // khi chuong trinh co loi xay ra thi se phat sinh ra doi tuong thuoc lop exception hoac lop ke thua tu exception

            try
            {
                // cac lenh
                // neu co loi thi se dieu huong sang catch
                phepChia c = new phepChia(a, b);
                Console.WriteLine(c.chia());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); // thong bao loi
            }
        }
    }
}