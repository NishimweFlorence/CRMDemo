namespace Domain.Entities
{
    public class SupportTicket
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public string TicketNumber { get; set; }
        public string category { get; set; }
        public string status { get; set; }
        public  string Description  { get; set; }

    }
}
