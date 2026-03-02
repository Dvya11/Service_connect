using System.ComponentModel.DataAnnotations;

namespace Service_connect.Models
{
    public class ServiceExpert
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Category { get; set; }

        public string? Location { get; set; }

        public double Distance { get; set; }

        public double Rating { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }
    }
}