using System;
using System.Collections;
using System.Collections.Generic;
using Registration.Domain;

namespace Registration.Repo.Interfaces
{
    public interface IRegistrantRepository
    {
        IEnumerable<Registrant> Get();
        Registrant Get(Guid id);
        Registrant Insert(Registrant registrant);
        bool Delete(Guid id);
    }
}