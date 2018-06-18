using System.Collections;
using System.Collections.Generic;
using Registration.Domain;

namespace Registration.Repo.Interfaces
{
    public interface IStateRepository
    {
        IEnumerable<State> Get();
        State Get(int id);
    }
}