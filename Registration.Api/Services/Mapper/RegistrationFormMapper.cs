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
    public class RegistrationFormMapper : IRegistrationFormMapper
    {
        public IEnumerable<RegistrationFormViewModel> MapDomainCollectionToViewModel(IEnumerable<Registrant> domainList)
        {
            throw new NotImplementedException();
        }

        public RegistrationFormViewModel MapDomainToViewModel(Registrant domain)
        {
            if(domain == null)
            {
                throw new ArgumentNullException(nameof(domain), "The registrant domain object cannot be null.");
            }

            var address1 = new Address();
            var address2 = new Address();

            if(domain.Addresses.Any())
            {
                address1 = domain.Addresses.FirstOrDefault(x => x.AddressType.Name.Equals(AddressTypes.Address1.ToString()));
                address2 = domain.Addresses.FirstOrDefault(x => x.AddressType.Name.Equals(AddressTypes.Address2.ToString()));
            }

            return new RegistrationFormViewModel
            {
                Id = domain.Id,
                FirstName = domain.FirstName,
                LastName = domain.LastName,
                Street1 = address1.Street,
                City1 = address1.City,
                StateId1 = address1.StateId == default(int) ? "1" : address1.StateId.ToString(),
                ZipCode1 = address1.ZipCode,
                CountryId1 = address1.CountryId == default(int) ? "1" : address1.CountryId.ToString(),
                Street2 = address2.Street,
                City2 = address2.City,
                StateId2 = address2.StateId == default(int) ? "1" : address1.StateId.ToString(),
                ZipCode2 = address2.ZipCode,
                CountryId2 = address2.CountryId == default(int) ? "1" : address1.CountryId.ToString(),
            };
        }

    }
}