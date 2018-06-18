using Registration.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registration.Domain;
using Registration.Repo.Interfaces;

namespace Registration.Service
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IRegistrantRepository registrantRepo;

        public RegistrationService(IRegistrantRepository registrantRepo)
        {
            this.registrantRepo = registrantRepo;
        }

        public IEnumerable<Registrant> Get()
        {
            // TODO: here we ought to include user authentication (in the service layer) for this "admin" function 

            return registrantRepo.Get();
        }

        public Registrant Get(Guid id)
        {
            if(id == Guid.Empty)
            {
                return new Registrant();
            }

            return registrantRepo.Get(id);
        }

        public Registrant Save(Registrant registrant)
        {
            if(registrant == null)
            {
                throw new ArgumentNullException(nameof(registrant), "The registrant object cannot be null.");
            }

            return registrantRepo.Insert(registrant);
        }
    }
}
