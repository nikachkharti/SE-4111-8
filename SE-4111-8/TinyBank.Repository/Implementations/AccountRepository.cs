﻿using System.Text.Json;
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

            var accounts = FromJson(File.ReadAllText(_filePath));

            return accounts ?? new List<Account>();
        }
        private List<Account> FromJson(string line) =>
            JsonSerializer.Deserialize<List<Account>>(line, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        private string ToJson(List<Account> accounts) =>
            JsonSerializer.Serialize(accounts, new JsonSerializerOptions() { WriteIndented = true });
        private void SaveData() =>
            File.WriteAllText(_filePath, ToJson(_accounts));
        #endregion

    }
}
