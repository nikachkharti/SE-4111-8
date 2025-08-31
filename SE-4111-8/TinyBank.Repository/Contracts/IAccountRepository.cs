using TinyBank.Models;

namespace TinyBank.Repository.Contracts
{
    public interface IAccountRepository
    {
        List<Account> GetAccounts();
        Account GetSingleAccount(int id);
        int AddAccount(Account newAccount);
        int UpdateAccount(Account account);
        int DeleteAccount(int id);
    }
}
