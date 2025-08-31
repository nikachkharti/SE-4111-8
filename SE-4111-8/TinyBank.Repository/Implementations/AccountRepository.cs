using System.Text.Json;
using TinyBank.Models;
using TinyBank.Repository.Contracts;

namespace TinyBank.Repository.Implementations
{
    public class AccountRepository : IAccountRepository
    {
        private readonly string _filePath;
        private List<Account> _accounts;

        public AccountRepository(string filePath)
        {
            _filePath = filePath;
            _accounts = LoadData();
        }

        public List<Account> GetAccounts() => _accounts;
        public Account GetSingleAccount(int id) => _accounts.FirstOrDefault(a => a.Id == id);
        public int AddAccount(Account newAccount)
        {
            newAccount.Id = _accounts.Any() ? _accounts.Max(c => c.Id) + 1 : 1;
            _accounts.Add(newAccount);
            SaveData();

            return newAccount.Id;
        }
        public int DeleteAccount(int id)
        {
            var account = _accounts.FirstOrDefault(a => a.Id == id);

            _accounts.Remove(account);
            SaveData();

            return account.Id;
        }
        public int UpdateAccount(Account account)
        {
            var index = _accounts.FindIndex(a => a.Id == account.Id);

            if (index >= 0)
            {
                _accounts[index] = account;
                SaveData();
            }

            return account.Id;
        }


        #region HELPERS
        private List<Account> LoadData()
        {
            if (!File.Exists(_filePath))
                return new List<Account>();

            var accounts = new List<Account>();

            using (var reader = new StreamReader(_filePath))
            {
                reader.ReadLine(); //Skip the line 1
                string line = string.Empty;

                while ((line = reader.ReadLine()) != null)
                {
                    var account = FromJson(line);
                    if (account != null) // skip invalid lines
                        accounts.Add(account);
                }
            }

            return accounts;
        }
        private Account FromJson(string line) => JsonSerializer.Deserialize<Account>(line, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        private string ToJson(Account account) => JsonSerializer.Serialize(account, new JsonSerializerOptions() { WriteIndented = true });
        private void SaveData()
        {
            using (var writer = new StreamWriter(_filePath, append: false)) // 'false' to overwrite the file
            {
                writer.WriteLine("Id,Iban,Currency,Balance,CustomerId,Destination");

                foreach (var account in _accounts)
                {
                    writer.WriteLine(ToJson(account));
                }
            }
        }
        #endregion

    }
}
