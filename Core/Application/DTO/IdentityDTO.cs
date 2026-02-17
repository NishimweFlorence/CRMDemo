using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace Application.DTO
{
    public class RegisterUserDTO
    {
        [ Required (ErrorMessage=" First Name is required")]
        public string FirstName { get; set; } = string.Empty;
          [ Required (ErrorMessage=" Last Name is required")]
        public string LastName { get; set; } = string.Empty;
          [ Required (ErrorMessage=" Email is required")]
        public string Email { get; set; } = string.Empty;

          [ Required (ErrorMessage=" PhoneNumber is required")]
        public string PhoneNumber { get; set; } = string.Empty;

          [ Required (ErrorMessage=" Password is required")]
        public string Password { get; set; } = string.Empty;
    }

    public class UserDetailDTO
    {
        public int Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}  
        public string? PhoneNumber {get; set;}
         public bool EmailConfirmed {get; set;}
         public DateTime CreatedAt {get; set;}
         public DateTime UpdatedAt {get; set;}
    }
    public class UserUpdateDTO
    {
         public string FirstName {get; set;}
        public string? PhoneNumber {get; set;}
         public string Password { get; set; } 
        public string LastName {get; set;}
        public DateTime CreatedAt {get; set;}
         public DateTime UpdatedAt {get; set;}
        
    }
    public class LoginDTO
  {
    [ Required( ErrorMessage ="Email id required")]
    [ EmailAddress(ErrorMessage ="Invalid email address")]
    public string  Email {get;set;}

    [Required(ErrorMessage = "Password is required")]
    public  string Password {get;set;}
    public bool RememberMe {get;set;}= false;


  }
    }
    