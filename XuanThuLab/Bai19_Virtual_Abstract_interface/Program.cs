using System;
using System.Reflection.Metadata.Ecma335;

namespace Bai19_Virtual_Abstract_Interface
{
    // virtual method la phuong thuc duoc dinh nghia trong lop co so va co the duoc ghi de trong lop ke thua
    abstract class Product
    {
        protected double Price { get; set; }

        public abstract void ProductInfo();

        public void Test() => ProductInfo();
    }

    class Iphone : Product
    {
        public Iphone() => Price = 500;

        // override - nap chong phuong thuc 
        // public override void ProductInfo()
        // {
        //     base.ProductInfo();
        //     Console.WriteLine("Iphone price: " + Price);
        // }
        public override void ProductInfo() => Console.WriteLine("Iphone price: " + Price);
    }

    // abstract class - lop truu tuong la lop khong duoc su dung de tao doi tuong
    // cac phuong thuc trong lop truu tuong co the la abstract hoac la virtual 
    // cac lop con ke thua lop truu tuong phai thuc hien trien khai cac phuong thuc truu tuong


    // interface - tuong tu abstract class khong duoc su dung de tao doi tuong chi lam co so 
    // cho cac lop ke thua
    interface IHinhHoc
    {
        public double TinhChuVi();

        public double TinhDienTich();
    }

    class HinhChuNhat : IHinhHoc
    {
        public double Dai { get; set; }

        public double Rong { get; set; }

        public HinhChuNhat(double dai, double rong)
        {
            this.Dai = dai;
            this.Rong = rong;
        }

        public double TinhChuVi() => (Dai + Rong) * 2;
        
        public double TinhDienTich() => Dai * Rong;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Iphone i = new Iphone();
            // i.Test();

            // Product p = new Product() // Khong duoc su dung de tao ra doi tuong 
            HinhChuNhat h = new HinhChuNhat(3, 4);

            Console.WriteLine($"Chu vi: {h.TinhChuVi()}");
            Console.WriteLine($"Dien tich: {h.TinhDienTich()}");
        }
    }
}