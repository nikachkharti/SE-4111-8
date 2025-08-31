using Mapster;
using TinyBank.Models;
using TinyBank.Service.Dtos.Accounts;
using TinyBank.Service.Dtos.Customer;

namespace TinyBank.Service.Mapping
{
    public static class MapsterConfig
    {
        public static void RegisterMappings()
        {
            TypeAdapterConfig<Customer, CustomerForGettingDto>.NewConfig()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.IdentityNumber, src => src.IdentityNumber)
                .Map(dest => dest.PhoneNumber, src => src.PhoneNumber)
                .Map(dest => dest.Email, src => src.Email)
                .Map(dest => dest.CustomerType, src => src.CustomerType);

            TypeAdapterConfig<CustomerForCreatingDto, Customer>.NewConfig()
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.IdentityNumber, src => src.IdentityNumber)
                .Map(dest => dest.PhoneNumber, src => src.PhoneNumber)
                .Map(dest => dest.Email, src => src.Email)
                .Map(dest => dest.CustomerType, src => src.CustomerType);

            TypeAdapterConfig<CustomerForUpdatingDto, Customer>.NewConfig()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.IdentityNumber, src => src.IdentityNumber)
                .Map(dest => dest.PhoneNumber, src => src.PhoneNumber)
                .Map(dest => dest.Email, src => src.Email)
                .Map(dest => dest.CustomerType, src => src.CustomerType);

            TypeAdapterConfig<Account, AccountForGettingDto>.NewConfig()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.Iban, src => src.Iban)
                .Map(dest => dest.Currency, src => src.Currency)
                .Map(dest => dest.Balance, src => src.Balance)
                .Map(dest => dest.CustomerId, src => src.CustomerId)
                .Map(dest => dest.Destination, src => src.Destination);

            TypeAdapterConfig<AccountForCreatingDto, Account>.NewConfig()
                .Map(dest => dest.Iban, src => src.Iban)
                .Map(dest => dest.Currency, src => src.Currency)
                .Map(dest => dest.Balance, src => src.Balance)
                .Map(dest => dest.CustomerId, src => src.CustomerId)
                .Map(dest => dest.Destination, src => src.Destination);
        }
    }
}
