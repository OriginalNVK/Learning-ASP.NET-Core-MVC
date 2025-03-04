namespace MyFirstWebApp.Data
{
    public enum TinhTrangDonHang
    {
        New = 0, Paymented = 1, Complete = 2, Cancel = -1
    }
    public class DonHang
    {
        public Guid MaDh {  get; set; }

        public DateTime NgayDat { get; set; }

        public DateTime? NgayGiao { get; set; }

        public TinhTrangDonHang TinhTrang { get; set; }

        public string NguoiNhan { get; set; }

        public string DiaChiGiao { get; set; }

        public string SoDienThoai { get; set; }

        public ICollection<DonHangChiTiet> DonHangChiTiets { get; set; }

        public DonHang()
        {
            DonHangChiTiets = new List<DonHangChiTiet>();
        }
    }
}
