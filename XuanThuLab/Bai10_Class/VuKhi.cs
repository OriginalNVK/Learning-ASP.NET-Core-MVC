using System;

namespace Bai10_Class
{
    class VuKhi
    {
        // Dữ liệu:
        public string name = "TenVuKhi"; // ko ghi gì thì mặc định là private
        public int doSatThuong;

        // Thuộc tính
        public int SatThuong
        {
            // Truy cập
            get
            {
                return doSatThuong;
            }

            // =
            set
            {
                Console.WriteLine("Set the value to the doSatThuong attribute");
                Console.WriteLine(value);
                doSatThuong = value;
            }
        }

        // Các phương thức khởi tạo
        public VuKhi()
        {
            doSatThuong = 1;
            name = "VuKhiMoi";
            Console.WriteLine("Đây là vũ khí");
        }

        public VuKhi(string abc)
        {
            Console.WriteLine(abc);
        }

        // Phương thức
        public void ThietLapDoSatThuong(int doSatThuong)
        {
            this.doSatThuong = doSatThuong;
        }

        public void TanCong()
        {
            Console.WriteLine(this.name);
            for (int i = 0; i < doSatThuong; i++)
            {
                Console.WriteLine("Tan cong");
            }
        }

        // Hàm hủy
        // Được gọi tự động khi một đối tượng được giải phóng
        // khi bị thu hồi bộ nhớ
        
    }
}