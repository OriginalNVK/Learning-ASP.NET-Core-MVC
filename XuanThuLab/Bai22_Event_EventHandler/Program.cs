using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace Bai22
{
    public delegate void SuKienNhapSo(int x);

    class DuLieuNhap : EventArgs
    {
        public int data { get; set; }

        public DuLieuNhap(int x)
        {
            data = x;
        }
    }
    // publisher
    class UserInput
    {
        // public event SuKienNhapSo suKienNhapSo; // Khi gan event thi sukiennhapso chi co the them vao va bot di
        // tuc la chi thuc hien duoc phep toan += -= 

        // C# ho tro thuc hien doi tuong la eventhandler
        // khai bao
        public event EventHandler suKienNhapSo; // khi khai bao nhu vay
                                                // co nghia la delegate void Kieu(object sender, EventArgs args)
                                                // thong thuong lop EventArg thi khong chua gi vi vay de thoa man thi phai khai bao mot lop ke thua tu eventArg

        public void Input()
        {
            while (true)
            {
                Console.Write("Nhap so: ");
                string? s = Console.ReadLine();
                int i = Int32.Parse(s);
                // phat su kien
                suKienNhapSo?.Invoke(this, new DuLieuNhap(i));
            }
        }
    }

    // subcriber
    class CanBac2
    {
        public void Sub(UserInput userInput)
        {
            userInput.suKienNhapSo += Can;
        }
        public void Can(object? sender, EventArgs e)
        {
            DuLieuNhap duLieuNhap = (DuLieuNhap)e;
            int i = duLieuNhap.data;
            Console.WriteLine($"Can bac 2 cua {i} la {Math.Sqrt(i)}");
        }
    }

    class TinhBinhPhuong
    {
        public void Sub(UserInput userInput)
        {
            userInput.suKienNhapSo += BinhPhuong;
        }
        public void BinhPhuong(object? sender, EventArgs e)
        {
            DuLieuNhap duLieuNhap = (DuLieuNhap)e;
            int i = duLieuNhap.data;
            Console.WriteLine($"Binh phuong cua {i} la: {Math.Pow(i, 2)}");
        }
    }
    class Program
    {
        static void Main()
        {
            // Console.CancelKeyPress += (sender, e) =>
            // {
            //     Console.WriteLine();
            //     Console.WriteLine("Thoat ung dung");
            // };
            // publisher -> class - phat su kien 
            // subcriber -> class - nhan su kien 
            // publisher 
            UserInput userInput = new UserInput();

            // subcriber
            CanBac2 tinhcan = new CanBac2();
            tinhcan.Sub(userInput);

            TinhBinhPhuong tinhBinhPhuong = new TinhBinhPhuong();
            tinhBinhPhuong.Sub(userInput);
            // su kien chi nhan dang ki tu mot lop 
            // de thuc hien dki nhieu lop phai dung event

            userInput.suKienNhapSo += (object? sender, EventArgs e) =>
            {
                DuLieuNhap duLieuNhap = (DuLieuNhap)e;
                int x = duLieuNhap.data;
                Console.WriteLine($"So vua nhap la: {x}");
            };
            userInput.Input();

            
        }
    }
}