namespace Application.DTO
{
    public class CustomerCreateDTO
    {
        public string Names{ get; set;} 
        public string Email { get; set;}
        public string Phone { get; set;}
        public string City { get;set;}
        public string Address { get; set;}

    }
    public class CustomerUpdateDTO
    {
        public string Names {get;set;}
        public string Phone {get;set;}
        public string City {get;set;}
        public string Address {get;set;}
    }
}