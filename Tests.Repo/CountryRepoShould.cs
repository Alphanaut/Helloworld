using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Tests.Repo
{
    public class CountryRepoShould : TestingBase
    {
        private readonly ITestOutputHelper console;

        public CountryRepoShould(ITestOutputHelper console)
        {
            this.console = console;
        }

        [Fact]
        [Trait("Integration", "Repo")]
        public void GetAllCountries()
        {
            // Arranage
            

            // Act
            var result = countryRepo.Get().ToList();

            // Assert
            Assert.NotEmpty(result);
            
            // Analyze
            foreach (var country in result)
            {
                console.WriteLine("The country code for {0} is {1}", country.Name, country.CountryCode);
            }
        }
    }
}
