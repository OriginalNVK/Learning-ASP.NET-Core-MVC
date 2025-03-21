using System.ComponentModel.DataAnnotations;

namespace NZWalks.API.Models.DTOs
{
    public class UpdateRegionRequestDTO
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Max length of the Code is 10 characters")]

        public string Code { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Max length of the Name field is 100 characters")]
        public string Name { get; set; }

        public string? RegionImageUrl { get; set; }
    }
}
