
using Microsoft.AspNetCore.Identity;

namespace  Infrastructure.Identity
{
    public class User : IdentityUser<int>
    {
        // You can add additional properties here if needed
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}
    
    }
}