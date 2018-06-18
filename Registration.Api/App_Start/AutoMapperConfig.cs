using AutoMapper;
using Registration.Api.Models;
using Registration.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;

namespace Registration.Api
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg =>
            {
                ///// -------- DropDownOptions
                cfg.CreateMap<AddressType, DropDownOption>()
                .ForMember(dest => dest.Value, map => map.MapFrom(src => src.Id.ToString()))
                .ForMember(dest => dest.Display, map => map.MapFrom(src => src.Name));

                cfg.CreateMap<State, DropDownOption>()
                .ForMember(dest => dest.Value, map => map.MapFrom(src => src.Id.ToString()))
                .ForMember(dest => dest.Display, map => map.MapFrom(src => src.USPSCode));

                cfg.CreateMap<Country, DropDownOption>()
                .ForMember(dest => dest.Value, map => map.MapFrom(src => src.Id.ToString()))
                .ForMember(dest => dest.Display, map => map.MapFrom(src => src.CountryCode));


                ///// -------- Registrant
                cfg.CreateMap<Registrant, RegistrationViewModel>()
                .ForMember(dest => dest.Address1, map => map.MapFrom(src => src.Addresses.Any() && src.Addresses != null && src.Addresses.Select(x => x.AddressType.Name == "Address1") != null ?
                    $@"{src.Addresses.FirstOrDefault(x => x.AddressType.Name == "Address1").Street},
                       {src.Addresses.FirstOrDefault(x => x.AddressType.Name == "Address1").City},
                       {src.Addresses.FirstOrDefault(x => x.AddressType.Name == "Address1").State},
                       {src.Addresses.FirstOrDefault(x => x.AddressType.Name == "Address1").ZipCode}" : string.Empty))
                .ForMember(dest => dest.Country1, map => map.MapFrom(src => src.Addresses.Any() && src.Addresses != null && src.Addresses.Select(x => x.AddressType.Name == "Address1") != null ? src.Addresses.First(x => x.AddressType.Name == "Address 1").Country.Name : "N/A"))
                .ForMember(dest => dest.Address2, map => map.MapFrom(src => src.Addresses.Any() && src.Addresses != null && src.Addresses.Select(x => x.AddressType.Name == "Address2") != null ?
                    $@"{src.Addresses.FirstOrDefault(x => x.AddressType.Name == "Address2").Street},
                       {src.Addresses.FirstOrDefault(x => x.AddressType.Name == "Address2").City},
                       {src.Addresses.FirstOrDefault(x => x.AddressType.Name == "Address2").State},
                       {src.Addresses.FirstOrDefault(x => x.AddressType.Name == "Address2").ZipCode}" : string.Empty))
                 .ForMember(dest => dest.Country1, map => map.MapFrom(src => src.Addresses.Any() && src.Addresses != null && src.Addresses.Select(x => x.AddressType.Name == "Address2") != null ? src.Addresses.First(x => x.AddressType.Name == "Address 2").Country.Name : "N/A"));


                cfg.CreateMap<RegistrationBindingModel, Registrant>()
                .ForMember(dest => dest.Addresses, map => map.MapFrom(src => new List<Address> { new Address { Street = src.Street1, City = src.City1, StateId = src.StateId1, ZipCode = src.ZipCode1, CountryId = src.CountryId1, AddressTypeId = 1 }, new Address { Street = src.Street2, City = src.City2, StateId = src.StateId2, ZipCode = src.ZipCode2, CountryId = src.CountryId2, AddressTypeId = 2 } }))
                //.ForMember(dest => dest.Addresses, map => map.MapFrom(src => new List<Address> { new Address { Street = src.Street2, City = src.City2, StateId = src.StateId2, ZipCode = src.ZipCode2, CountryId = src.CountryId2, AddressTypeId = 2 } }))
                .ForMember(dest => dest.Id, map => map.MapFrom(src => Guid.Parse(src.Id)));
            });

            UnityConfig.GetConfiguredContainer().RegisterInstance(Mapper.Instance);
        }
    }
}