using Mapster;
using TinyBank.Repository.Contracts;
using TinyBank.Service.Dtos.Accounts;
using TinyBank.Service.Interfaces;

namespace TinyBank.Service.Implementations
{
    public class AccountService(ICustomerService customerService, IAccountRepository accountRepository) : IAccountService
    {
        public List<AccountForGettingDto> GetAllAccountsOfCustomer(int customerId)
        {
            ValidateCustomerId(customerId);
            ValidateCustomerExists(customerId);

            var result = accountRepository.GetAccountsOfCustomer(customerId);
            return result.Adapt<List<AccountForGettingDto>>();
        }

        private void ValidateCustomerId(int customerId)
        {
            if (customerId <= 0)
                throw new ArgumentException($"CustomerId can't be a negative number");
        }
        private void ValidateCustomerExists(int customerId)
        {
            var result = customerService.GetSingleCustomer(customerId);

            if (result is null)
                throw new ArgumentException($"Customer with id: {customerId} not found.");
        }
    }
}
