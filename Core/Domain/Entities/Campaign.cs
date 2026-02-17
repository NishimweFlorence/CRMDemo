namespace Domain.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string type { get; set; }
        public string Description { get; set; }
        public DateTime  StartDate { get; set; }
        public  DateTime  EndDate { get; set; }


    }
}
