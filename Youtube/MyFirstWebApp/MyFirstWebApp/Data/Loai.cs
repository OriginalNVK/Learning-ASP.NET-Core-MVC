using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstWebApp.Data
{
    [Table("Loai")]
    public class Loai
    {
        [Key]
        public int MaLoai {  get; set; }

        [Required]
        [MaxLength(50)]
        public string TenLoai { get; set; }

        public virtual ICollection<HangHoa>? HangHoas { get; set; }

    }
}
