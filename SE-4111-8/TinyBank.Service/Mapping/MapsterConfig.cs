using Mapster;
using TinyBank.Models;
using TinyBank.Service.Dtos;

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
        }
    }
}
