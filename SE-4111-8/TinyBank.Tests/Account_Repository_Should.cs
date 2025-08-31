using TinyBank.Models;
using TinyBank.Repository.Contracts;
using TinyBank.Repository.Implementations;

namespace TinyBank.Tests
{
    public class Account_Repository_Should
    {
        private readonly string _filePath = "C:\\Users\\User\\Desktop\\IT STEP\\SE-4111-8\\SE-4111-8\\TinyBank.Tests\\Data\\Accounts.json";
        private readonly IAccountRepository _accountRepository;
        public Account_Repository_Should()
        {
            _accountRepository = new AccountRepository(_filePath);
        }

        [Fact]
        public void Get_AllAccounts()
        {
            var allAccounts = _accountRepository.GetAccounts();
        }

        [Fact]
        public void Get_SingleAccount()
        {
            var actual = _accountRepository.GetSingleAccount(1);
            var expected = new Account()
            {
                Id = 1,
                Iban = "GE94SB5621487456325158",
                Currency = "USD",
                Balance = 6712.12m,
                CustomerId = 1,
                Destination = null
            };

            Assert.Equal(expected.Id, actual.Id);
        }


        [Fact]
        public void Add_SingleAccount()
        {
            var existedMaxId = _accountRepository.GetAccounts().Max(c => c.Id);

            var newAccount = new Account()
            {
                Iban = "GE94SB5621487456325159",
                Currency = "XYN",
                Balance = 520.00m,
                CustomerId = 1,
                Destination = null
            };

            var newAccountId = _accountRepository.AddAccount(newAccount);

            Assert.Equal(newAccountId, existedMaxId += 1);
        }

        [Fact]
        public void Delete_SingleAccount()
        {
            var accountIdToDelete = 30;

            var actualAccount = _accountRepository.GetSingleAccount(accountIdToDelete);
            var expectedAccountId = _accountRepository.DeleteAccount(accountIdToDelete);

            Assert.Equal(expectedAccountId, actualAccount.Id);
        }


        [Fact]
        public void Update_SingleAccount()
        {
            var updatedAccount = new Account()
            {
                Id = 30,
                Iban = "GE94SB5621487456325159",
                Currency = "ZYN",
                Balance = 520.00m,
                CustomerId = 1,
                Destination = null
            };

            var newAccountId = _accountRepository.UpdateAccount(updatedAccount);

            Assert.Equal(updatedAccount.Id, newAccountId);
        }
    }
}
