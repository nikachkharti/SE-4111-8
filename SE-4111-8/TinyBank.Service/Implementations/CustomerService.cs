using Mapster;
using TinyBank.Models;
using TinyBank.Repository.Contracts;
using TinyBank.Service.Dtos.Customer;
using TinyBank.Service.Interfaces;

namespace TinyBank.Service.Implementations
{
    public class CustomerService(ICustomerRepository customerRepository) : ICustomerService
    {
        public int AddCustomer(CustomerForCreatingDto model)
        {
            var customer = model.Adapt<Customer>();
            return customerRepository.AddCustomer(customer);
        }

        public int DeleteCustomer(int customerId)
        {
            var result = customerRepository.DeleteCustomer(customerId);
            return result;
        }

        public List<CustomerForGettingDto> GetAllCustomers()
        {
            var result = customerRepository.GetCustomers();
            return result.Adapt<List<CustomerForGettingDto>>();
        }

        public CustomerForGettingDto GetSingleCustomer(int customerId)
        {
            var result = customerRepository.GetSingleCustomer(customerId);
            return result.Adapt<CustomerForGettingDto>();
        }

        public int UpdateCustomer(CustomerForUpdatingDto model)
        {
            var customer = model.Adapt<Customer>();
            return customerRepository.UpdateCustomer(customer);
        }



    }
}
