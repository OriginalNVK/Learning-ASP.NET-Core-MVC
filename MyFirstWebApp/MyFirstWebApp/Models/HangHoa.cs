using System.ComponentModel.DataAnnotations;

namespace MyFirstWebApp.Models
{
    public class HangHoaVM
    {
        public string? TenHH { get; set; }    

        public double Gia { get; set; }

    }

    public class HangHoa : HangHoaVM
    {
       public Guid MaHh { get; set; }
    }

    public class HangHoaModel
    {
        public Guid MaHh { get; set; }
        public string TenHH { get; set; }
        public double GiaHH { get; set; }
        public string TenLoai { get; set; }
    }


}
