using TinyBank.Service.Dtos.Accounts;

namespace TinyBank.Service.Interfaces
{
    public interface IAccountService
    {
        List<AccountForGettingDto> GetAllAccountsOfCustomer(int customerId)
    }
}
