using Domain.Entities;
using Application.Interfaces;
using Infrastructure.Data;
using Application.DTO;

namespace Infrastructure.Repositories
{
public class CustomerRepository : ICustomer
    {
        private readonly ApplicationDbContext _dBcontext;
        public CustomerRepository(ApplicationDbContext dBcontext)
        {
            _dBcontext = dBcontext;
        }
        public List<Customer> GetAllCustomers()
        {
         List<Customer> customers = _dBcontext.Customers.ToList();
            return customers;
        }
        public Customer GetCustomerById(int id)
        {
            return _dBcontext.Customers.FirstOrDefault(c => c.Id == id);
        }

        public void CreateCustomer(CustomerCreateDTO customerDTO)
        {
            Customer customer = new Customer
            {
                Names = customerDTO.Names,
                Email = customerDTO.Email,
                Phone= customerDTO.Phone,
                City = customerDTO.City,
                Address= customerDTO.Address,
                // CreatedAt = DateTime.Now,
                // CreatedById=1 
                
            };
            _dBcontext.Customers.Add(customer);
            _dBcontext.SaveChanges();
        }
        public void UpdateCustomer(int id, CustomerUpdateDTO customerDTO)
        {
            var customer = _dBcontext.Customers.Find(id);
            if (customer != null)
            {
                customer.Names = customerDTO.Names;
                customer.Phone = customerDTO.Phone;
                customer.City = customerDTO.City;
                customer.Address = customerDTO.Address;
               

                _dBcontext.SaveChanges();
            }
        }
    }}