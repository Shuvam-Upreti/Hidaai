using System.ComponentModel.DataAnnotations;

namespace HidaaiAPI.Models.DTO
{
    public class AddRegionRequestDto
    {
        [Required]
        [MaxLength(5,ErrorMessage ="Max length is 5" )]
        public string Code { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Max length is 5")]

        public string Name { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}
