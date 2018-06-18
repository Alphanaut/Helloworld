using Registration.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Service.Interfaces
{
    public interface IAddressOptionService
    {
        IEnumerable<AddressType> GetAddressTypes();
        IEnumerable<Country> GetCountries();
        IEnumerable<State> GetStates();
    }
}
