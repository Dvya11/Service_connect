namespace Service_connect.Models
{
    public class VisitRequest
    {
        public int Id { get; set; }

        public string? CustomerName { get; set; }

        public string? Address { get; set; }

        public string? Description { get; set; }

        public string? Status { get; set; }
    }
}