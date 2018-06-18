using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using Registration.DataLayer;
using Registration.Domain;
using Registration.Repo.Interfaces;

namespace Registration.Repo
{
    public class AddressTypeRepository : IAddressTypeRepository
    {
        private readonly RegistrationContext context;

        public AddressTypeRepository(RegistrationContext context)
        {
            this.context = context;
        }

        public IEnumerable<AddressType> Get()
        {
            var addressTypes = All;

            return addressTypes;
        }

        public AddressType Get(int id)
        {
            if (id == default(int))
            {
                throw new ArgumentNullException(nameof(id), "The addressType id cannot be null.");
            }

            return Find(id);
        }

        private IQueryable<AddressType> All
        {
            get { return context.AddressTypes.Where(x => x.Id != default(int)); }
        }

        private AddressType Find(int id)
        {
            return context.AddressTypes.Find(id);
        }
    }
}