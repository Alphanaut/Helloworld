using Registration.Domain;
using Registration.Repo.Interfaces;
using Registration.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Service
{
    public class AddressOptionService : IAddressOptionService
    {
        private readonly IAddressTypeRepository addressTypeRepo;
        private readonly ICountryRepository countryRepo;
        private readonly IStateRepository stateRepo;

        public AddressOptionService(IAddressTypeRepository addressTypeRepo, ICountryRepository countryRepo, IStateRepository stateRepo)
        {
            this.addressTypeRepo = addressTypeRepo;
            this.stateRepo = stateRepo;
            this.countryRepo = countryRepo; 
        }

        public IEnumerable<AddressType> GetAddressTypes()
        {
            return addressTypeRepo.Get();
        }

        public IEnumerable<Country> GetCountries()
        {
            return countryRepo.Get();
        }

        public IEnumerable<State> GetStates()
        {
            return stateRepo.Get();
        }
    }
}
