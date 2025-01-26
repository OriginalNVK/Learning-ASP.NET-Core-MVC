using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstWebApp.Data
{
    [Table("NguoiDung")]
    public class NguoiDung
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(250)]
        public string Password { get; set; }

        [Required]
        [MaxLength(150)]
        public string HoTen {  get; set; }

        [Required]
        [MaxLength(150)]
        public string Email { get; set; }
    }
}
