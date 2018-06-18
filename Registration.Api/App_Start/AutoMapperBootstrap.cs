using AutoMapper;
using Registration.Api.Models;
using Registration.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using Unity;


namespace Registration.Api.App_Start
{
    public class AutoMapperBootstrap : Profile
    {
        public AutoMapperBootstrap()
        {
            ///// -------- DropDownOptions
            CreateMap<AddressType, DropDownOption>()
            .ForMember(dest => dest.Value, map => map.MapFrom(src => src.Id.ToString()))
            .ForMember(dest => dest.Display, map => map.MapFrom(src => src.Name));

            CreateMap<State, DropDownOption>()
            .ForMember(dest => dest.Value, map => map.MapFrom(src => src.Id.ToString()))
            .ForMember(dest => dest.Display, map => map.MapFrom(src => src.USPSCode));

            CreateMap<Country, DropDownOption>()
            .ForMember(dest => dest.Value, map => map.MapFrom(src => src.Id.ToString()))
            .ForMember(dest => dest.Display, map => map.MapFrom(src => src.CountryCode));


            ///// -------- Registrant
            CreateMap<Registrant, RegistrationViewModel>()
            .ForMember(dest => dest.Address1, map => map.MapFrom(src => src.Addresses.Any() && src.Addresses != null ?
                $"{src.Addresses.First(x => x.AddressType.Name == "Address 1").Street}, " +
                $"{src.Addresses.First(x => x.AddressType.Name == "Address 1").City}, +" +
                $"{src.Addresses.First(x => x.AddressType.Name == "Address 1").State}, " +
                $"{src.Addresses.First(x => x.AddressType.Name == "Address 1").ZipCode}" : string.Empty))
            .ForMember(dest => dest.Country1, map => map.MapFrom(src => src.Addresses.Any() && src.Addresses != null ? src.Addresses.First(x => x.AddressType.Name == "Address 1").Country.Name : "N/A"))
            .ForMember(dest => dest.Address2, map => map.MapFrom(src => src.Addresses.Any() && src.Addresses != null ?
                $"{src.Addresses.First(x => x.AddressType.Name == "Address 2").Street}, " +
                $"{src.Addresses.First(x => x.AddressType.Name == "Address 2").City}, +" +
                $"{src.Addresses.First(x => x.AddressType.Name == "Address 2").State}, " +
                $"{src.Addresses.First(x => x.AddressType.Name == "Address 2").ZipCode}" : string.Empty))
             .ForMember(dest => dest.Country1, map => map.MapFrom(src => src.Addresses.Any() && src.Addresses != null ? src.Addresses.First(x => x.AddressType.Name == "Address 2").Country.Name : "N/A"));


            CreateMap<RegistrationBindingModel, Registrant>()
            .ForMember(dest => dest.Addresses, map => map.MapFrom(src => new List<Address> { new Address { Street = src.Street1, City = src.City1, StateId = src.StateId1, ZipCode = src.ZipCode1, CountryId = src.CountryId1 } }))
            .ForMember(dest => dest.Addresses, map => map.MapFrom(src => new List<Address> { new Address { Street = src.Street2, City = src.City2, StateId = src.StateId2, ZipCode = src.ZipCode2, CountryId = src.CountryId2 } }))
            .ForMember(dest => dest.Id, map => map.MapFrom(src => Guid.Parse(src.Id)));
        }
    }
}