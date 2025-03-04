using Abc;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // var result = tinhToan.tong(1, 2);
            // Console.WriteLine(result);
            // float a = 1.2f;
            // float b = 2.3f;
            // Console.WriteLine(tinhToan.tong(a, b));
            // xinChao("Van A", "Nguyen");
            // xinChao(ho:"Nguyen Van", ten: "A");
            // xinChao("Xuan");
            int a;
            BinhPhuong(4, out a);

        }

        // static void xinChao(string ten, string ho = "Nguyen")
        // {
        //     string fullname;
        //     fullname = ho + " " + ten;
        //     Console.WriteLine("Xin chao " + fullname);
        // }

        static void BinhPhuong(int x) // Truyền tham số kiểu tham trị có nghĩa là biến a chỉ được dùng để gán cho biến tạo cục bộ trong hàm BinhPhuong
        {
            x = x * x;
            Console.WriteLine(x);
        }

        static void BinhPhuong(ref int x) // Truyền tham số kiểu tham Chiếu (ref) có nghĩa là biến x được trỏ đến ô nhớ của biến a nên giá trị của a sẽ thay đổi
        {
            x = x * x;
            Console.WriteLine(x);
        }

        static void BinhPhuong(int x, out int kq) // Truyền tham số kiểu out thì biến không cần được khởi tạo trước và biến này phải được gán giá trị trong hàm
        {
            kq = x * x;
            Console.WriteLine(kq);
        }
    }


}