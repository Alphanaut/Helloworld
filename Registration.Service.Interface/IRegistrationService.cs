using Registration.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Service.Interfaces
{
    public interface IRegistrationService
    {
        Registrant Save(Registrant registrant);
        IEnumerable<Registrant> Get();
        Registrant Get(Guid id);
    }
}
