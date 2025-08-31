using TinyBank.Service.Dtos.Customer;

namespace TinyBank.Service.Interfaces
{
    public interface ICustomerService
    {
        List<CustomerForGettingDto> GetAllCustomers();
        CustomerForGettingDto GetSingleCustomer(int customerId);
        int AddCustomer(CustomerForCreatingDto model);
        int UpdateCustomer(CustomerForUpdatingDto model);
        int DeleteCustomer(int customerId);
    }
}
