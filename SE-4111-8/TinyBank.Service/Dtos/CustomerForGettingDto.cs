using TinyBank.Models;

namespace TinyBank.Service.Dtos
{
    public record CustomerForGettingDto
    {
        public int Id;
        public string Name;
        public string IdentityNumber;
        public string PhoneNumber;
        public string Email;
        public CustomerType CustomerType;

        public override string ToString() => $"{Id} {Name}";
    }
}
