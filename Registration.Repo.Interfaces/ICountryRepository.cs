using System.Collections;
using System.Collections.Generic;
using Registration.Domain;

namespace Registration.Repo.Interfaces
{
    public interface ICountryRepository
    {
        IEnumerable<Country> Get();
        Country Get(int id);
    }
}