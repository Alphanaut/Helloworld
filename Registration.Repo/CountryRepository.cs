using System;
using System.Collections.Generic;
using System.Linq;
using Registration.DataLayer;
using Registration.Domain;
using Registration.Repo.Interfaces;

namespace Registration.Repo
{
    public class CountryRepository : ICountryRepository
    {
        private readonly RegistrationContext context;

        public CountryRepository(RegistrationContext context)
        {
            this.context = context;
        }
        public IEnumerable<Country> Get()
        {
            var countries = All;

            return countries;
        }

        public Country Get(int id)
        {
            if (id == default(int))
            {
                throw new ArgumentNullException(nameof(id), "The country id cannot be null.");
            }

            return Find(id);
        }

        private IQueryable<Country> All
        {
            get { return context.Countries.Where(x => x.Id != default(int)); }
        }

        private Country Find(int id)
        {
            return context.Countries.Find(id);
        }
    }
}
