using Domain.Entities;
using Application.DTO;
namespace Application.Services.Customers
{
    public interface ICustomerService
    {
        // Define methods related to customer operations here
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        void CreateCustomer(CustomerCreateDTO customerDTO);
        void UpdateCustomer(int id, CustomerUpdateDTO customerDTO);
    }
}