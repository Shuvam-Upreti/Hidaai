using System.ComponentModel.DataAnnotations;

namespace HidaaiAPI.Models.DTO
{
    public class UpdateRegionRequestDto
    {
        [Required]
        [MaxLength(5, ErrorMessage = "Max length is 5")]
        public string Code { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Max length is 100")]
        public string Name { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}
