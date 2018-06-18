using Registration.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Registration.Api.Models;
using Registration.Domain;
using Registration.Domain.OptionTypes;

namespace Registration.Api.Services.Mapper
{
    public class RegistrantMapper : IRegistrantMapper
    {
        public IEnumerable<RegistrationViewModel> MapDomainCollectionToViewModel(IEnumerable<Registrant> domainList)
        {
            // NOTE: A linq query in the repo could also have been used to return a the "ViewModel" or a view model styled domain object.
            // We have chose to use a custom mapper instead, to build the required view model.
            return domainList.Select(x => new RegistrationViewModel
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                CreatedDate = x.CreatedDate,
                Address1 = AddressBuilder(x?.Addresses, AddressTypes.Address1.ToString()),
                Address2 = AddressBuilder(x?.Addresses, AddressTypes.Address2.ToString()),
                Country1 = CountryBuilder(x?.Addresses, AddressTypes.Address1.ToString()),
                Country2 = CountryBuilder(x?.Addresses, AddressTypes.Address2.ToString())
            });
        }

        public RegistrationViewModel MapDomainToViewModel(Registrant domain)
        {
            return new RegistrationViewModel
            {
                Id = domain.Id,
                FirstName = domain.FirstName,
                LastName = domain.LastName,
                CreatedDate = domain.CreatedDate,
                Address1 = AddressBuilder(domain?.Addresses, AddressTypes.Address1.ToString()),
                Address2 = AddressBuilder(domain?.Addresses, AddressTypes.Address2.ToString()),
                Country1 = CountryBuilder(domain?.Addresses, AddressTypes.Address1.ToString()),
                Country2 = CountryBuilder(domain?.Addresses, AddressTypes.Address2.ToString())
            };
        }

        private string AddressBuilder(IEnumerable<Address> addresses, string type)
        {
            const string resultNotFound = "N/A";

            if (!addresses.Any() || addresses == null)
            {
                return resultNotFound;
            }

            var addressObject = addresses.FirstOrDefault(x => x.AddressType.Name.Equals(type));

            if (addressObject == null)
            {
                return resultNotFound;
            }

            var address = addressObject == null ? resultNotFound : $@"{addressObject.Street}, {addressObject.City}, {addressObject.State?.Name}, {addressObject.ZipCode}";
            return address;
        }

        private string CountryBuilder(IEnumerable<Address> addresses, string type)
        {
            const string resultNotFound = "N/A";

            if (!addresses.Any() || addresses == null)
            {
                return resultNotFound;
            }

            var addressObject = addresses.FirstOrDefault(x => x.AddressType.Name.Equals(type));

            if (addressObject == null)
            {
                return resultNotFound;
            }

            var country = addressObject == null ? resultNotFound : $@"{addressObject.Country.CountryCode}";
            return country;
        }

        // TODO: Add "State" attribute builder as temp fix.
    }
}