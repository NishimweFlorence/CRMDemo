namespace Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Names { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }= DateTime.Now;

        public  string City { get; set; }

        public string Address { get; set; }
    }
}
