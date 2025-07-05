using TinyBank.Models;
using TinyBank.Repository.Contracts;
using TinyBank.Repository.Implementations;

namespace TinyBank.Tests
{
    public class CustomerRepository_Should
    {
        private readonly string _filePath = @"C:\Users\User\Desktop\IT STEP\SE-4111-8\SE-4111-8\TinyBank.Tests\Data\Customers.csv";
        private readonly ICustomerRepository _customerRepository;
        public CustomerRepository_Should()
        {
            _customerRepository = new CustomerRepository(_filePath);
        }


        [Fact]
        public void Get_AllCustomers()
        {
            var allCustomers = _customerRepository.GetCustomers();
        }

        [Fact]
        public void Get_SingleCustomer()
        {
            var actual = _customerRepository.GetSingleCustomer(1);
            var expected = new Customer()
            {
                Id = 1,
                Name = "Iakob Qobalia",
                IdentityNumber = "31024852345",
                PhoneNumber = "555337681",
                Email = "Iakob.Qobalia@gmail.com",
                CustomerType = CustomerType.Phyisical
            };

            Assert.Equal(expected.IdentityNumber, actual.IdentityNumber);
        }


        [Fact]
        public void Add_SingleCustomer()
        {
            var existedMaxId = _customerRepository.GetCustomers().Max(c => c.Id);

            var newCustomer = new Customer()
            {
                Name = "Manuchar Qobalia",
                IdentityNumber = "31024852346",
                PhoneNumber = "555337682",
                Email = "Manuchar.Qobalia@gmail.com",
                CustomerType = CustomerType.Phyisical
            };

            var newCustomerId = _customerRepository.AddCustomer(newCustomer);

            Assert.Equal(newCustomerId, existedMaxId += 1);
        }

        [Fact]
        public void Add_FirstCustomer()
        {
            var allCustomers = _customerRepository.GetCustomers();
            allCustomers.Clear(); // Clear Customers

            var newCustomer = new Customer()
            {
                Name = "Manuchar Qobalia",
                IdentityNumber = "31024852346",
                PhoneNumber = "555337682",
                Email = "Manuchar.Qobalia@gmail.com",
                CustomerType = CustomerType.Phyisical
            };

            var newCustomerId = _customerRepository.AddCustomer(newCustomer);

            Assert.Equal(expected: 1, actual: newCustomerId);
        }


        [Fact]
        public void Delete_SingleCustomer()
        {
            var allCustomersCount = _customerRepository.GetCustomers().Count();
            var actualCustomer = _customerRepository.GetSingleCustomer(11);

            var expectedCustomerId = _customerRepository.DeleteCustomer(11);

            Assert.Equal(expectedCustomerId, actualCustomer.Id);
        }

    }
}
