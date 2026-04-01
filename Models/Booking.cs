namespace Service_connect.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public string Service { get; set; }

        public DateTime Date { get; set; }   // ✅ must be DateTime

        public string Time { get; set; }

        public string Status { get; set; }

        public string Image { get; set; }    // ✅ required
    }
}