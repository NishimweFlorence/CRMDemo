namespace Domain.Entities
{ public class SupportTicketCreateDTO{
       public int userId { get; set; }
        public string TicketNumber { get; set; }
        public string category { get; set; }
        public string status { get; set; }
        public  string Description  { get; set; }
}
public class SupportTicketUpdateDTO{
       public string category { get; set; }
        public string status { get; set; }
        public  string Description  { get; set; }
}

}