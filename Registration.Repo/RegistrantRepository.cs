using System;
using System.Collections.Generic;
using System.Linq;
using Registration.DataLayer;
using Registration.Domain;
using Registration.Repo.Interfaces;

namespace Registration.Repo
{
    public class RegistrantRepository : IRegistrantRepository
    {
        private readonly RegistrationContext context;

        public RegistrantRepository(RegistrationContext context)
        {
            this.context = context;
        }
        public IEnumerable<Registrant> Get()
        {
            try
            {
                var registrants = All;

                return registrants.AsEnumerable();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //private void GetStateAttributeIfNull(IEnumerable<Registrant> registrants)
        //{
        //    if(!registrants.Any())
        //    {
        //        return;
        //    }

        //    foreach (var item in registrants)
        //    {
        //        if(item.Addresses)
        //    }
        //}

        public Registrant Get(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(id), "The registrant id cannot be null.");
            }

            return Find(id);
        }

        public Registrant Insert(Registrant registrant)
        {
            if (registrant == null)
            {
                throw new ArgumentNullException(nameof(registrant), "The registrant object cannot be null.");
            }

            if(string.IsNullOrEmpty(registrant.FirstName))
            {
                throw new ArgumentNullException(nameof(registrant.FirstName), "The FirstName cannot be null.");
            }

            if(string.IsNullOrEmpty(registrant.LastName))
            {
                throw new ArgumentNullException(nameof(registrant.LastName), "The LastName cannot be null.");
            }

            if (registrant.Id != Guid.Empty)
            {
                throw new ArgumentOutOfRangeException(nameof(registrant.Id), "The registrant Id is invalid.");
            }

            var entityRegistrant = BuildRegistrant(registrant);
            entityRegistrant.Id = Guid.NewGuid();
            entityRegistrant.CreatedDate = DateTime.Now;
            context.Registrants.Add(entityRegistrant);

            if (registrant.Addresses != null)
            {
                var addresses = registrant.Addresses.ToList();
                if (addresses.Any())
                {
                    foreach (var address in addresses)
                    {
                        ValidateAddressEntry(address);
                        address.AddressType = BuildAddressType(address.AddressTypeId);
                        address.State = BuildState(address.StateId);
                        address.Country = BuildCountry(address.CountryId);

                        entityRegistrant.Addresses.Add(address);
                    }
                }
            }

            context.SaveChanges();
            return Find(entityRegistrant.Id);
        }

        public bool Delete(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(id), "The registrant id cannot be null.");
            }

            var registrant = Find(id);

            if (registrant == null)
            {
                return false;
            }

            context.Registrants.Remove(registrant);
            return true;
        }

        private IQueryable<Registrant> All
        {
            get { return context.Registrants.Where(x => x.Id != Guid.Empty); }
        }

        private Registrant Find(Guid id)
        {
            return context.Registrants.Find(id);
        }

        private AddressType BuildAddressType(int addressTypeId)
        {
            if (addressTypeId == default(int))
            {
                throw new ArgumentNullException(nameof(addressTypeId), "The addressTypeId cannot be null.");
            }

            var addressType = context.AddressTypes.Find(addressTypeId);

            if (addressType == null)
            {
                throw new Exception("The addressType was not found.");
            }

            return addressType;
        }

        private State BuildState(int stateId)
        {
            if (stateId == default(int))
            {
                throw new ArgumentNullException(nameof(stateId), "The stateId cannot be null.");
            }

            var state = context.States.Find(stateId);

            if (state == null)
            {
                throw new Exception("The state was not found.");
            }

            return state;
        }

        private Country BuildCountry(int countryId)
        {
            if (countryId == default(int))
            {
                throw new ArgumentNullException(nameof(countryId), "The countryId cannot be null.");
            }

            var country = context.Countries.Find(countryId);

            if (country == null)
            {
                throw new Exception("The country was not found.");
            }

            return country;
        }

        private Registrant BuildRegistrant(Registrant registrant)
        {
            var entityRegistrant = new Registrant
            {
                Id = registrant.Id,
                FirstName = registrant.FirstName,
                LastName = registrant.LastName
            };

            return entityRegistrant;
        }

        private void ValidateAddressEntry(Address address)
        {
            if (string.IsNullOrEmpty(address.Street))
            {
                throw new ArgumentNullException(nameof(address.Street), "The Street cannot be null.");
            }

            if (string.IsNullOrEmpty(address.City))
            {
                throw new ArgumentNullException(nameof(address.City), "The City cannot be null.");
            }

            if (string.IsNullOrEmpty(address.ZipCode))
            {
                throw new ArgumentNullException(nameof(address.ZipCode), "The ZipCode cannot be null.");
            }
        }
    }
}