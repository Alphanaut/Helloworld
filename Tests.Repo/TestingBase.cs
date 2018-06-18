using Registration.DataLayer;
using Registration.Repo;
using Registration.Repo.Interfaces;

namespace Tests.Repo
{
    public class TestingBase
    {
        internal readonly RegistrationContext context;
        internal readonly ICountryRepository countryRepo;
        internal readonly IStateRepository stateRepo;
        internal readonly IRegistrantRepository registrantRepo;
        internal readonly IAddressTypeRepository addressTypeRepo;

        public TestingBase()
        {
            this.context = new RegistrationContext();
            this.countryRepo = new CountryRepository(context);
            this.stateRepo = new StateRepository(context);
            this.registrantRepo = new RegistrantRepository(context);
            this.addressTypeRepo = new AddressTypeRepository(context);
        }
    }
}