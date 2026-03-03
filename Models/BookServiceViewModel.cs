using System.ComponentModel.DataAnnotations;

namespace Service_connect.Models
{
    public class BookServiceViewModel
    {
        [Required]
        public string? Location { get; set; }

        [Required]
        [MaxLength(500)]
        public string? Description { get; set; }
    }
}