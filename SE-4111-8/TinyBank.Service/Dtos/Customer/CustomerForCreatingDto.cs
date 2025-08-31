using TinyBank.Models;

namespace TinyBank.Service.Dtos.Customer
{
    public record CustomerForCreatingDto
    {
        public string Name;
        public string IdentityNumber;
        public string PhoneNumber;
        public string Email;
        public CustomerType CustomerType;
    }
}
