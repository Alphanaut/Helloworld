using System.Collections.Generic;
using Registration.Domain;

namespace Registration.Repo.Interfaces
{
    public interface IAddressTypeRepository
    {
        IEnumerable<AddressType> Get();
        AddressType Get(int id);
    }
}