using Registration.DataLayer;
using Registration.Repo;
using Registration.Repo.Interfaces;
using Registration.Service;
using Registration.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Service
{
    public class TestingBase
    {
        internal readonly RegistrationContext registrationContext;
        internal readonly IRegistrantRepository registrantRepo;
        internal readonly IAddressTypeRepository addressRepo;
        internal readonly ICountryRepository countryRepo;
        internal readonly IStateRepository stateRepo;
        internal IRegistrationService registrationService;
        internal IAddressOptionService addressOptionService;

        public TestingBase()
        {
            this.registrationContext = new RegistrationContext();
            this.registrantRepo = new RegistrantRepository(registrationContext);
            this.addressRepo = new AddressTypeRepository(registrationContext);
            this.countryRepo = new CountryRepository(registrationContext);
            this.stateRepo = new StateRepository(registrationContext);
            this.registrationService = new RegistrationService(registrantRepo);
            this.addressOptionService = new AddressOptionService(addressRepo, countryRepo, stateRepo);
        }
    }
}
