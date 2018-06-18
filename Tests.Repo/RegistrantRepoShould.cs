using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registration.Domain;
using Xunit;
using Xunit.Abstractions;

namespace Tests.Repo
{
    public class RegistrantRepoShould : TestingBase
    {
        private readonly ITestOutputHelper console;

        public RegistrantRepoShould(ITestOutputHelper console)
        {
            this.console = console;
        }

        [Fact]
        [Trait("Integration", "Repo - Exception")]
        public void ThrowExceptionOnGetIfIdIsNull()
        {
            // Arrange
            var userId = default(Guid);

            // Act
            var result = Record.Exception(() => registrantRepo.Get(userId));

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ArgumentNullException>(result);
        }

        [Fact]
        [Trait("Integration", "Repo - Exception")]
        public void ThrowsExceptionOnInsertIfNamesAreEmpty()
        {
            // Arrange
            var registrant = new Registrant();

            // Act
            var result = Record.Exception(() => registrantRepo.Insert(registrant));

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ArgumentNullException>(result);
        }

        [Fact]
        [Trait("Integration", "Repo - Exception")]
        public void ThrowsExceptionOnInsertIfIdIsNotNull()
        {
            // Arrange
            var registrant = new Registrant();
            registrant.Id = Guid.NewGuid();

            // Act
            var result = Record.Exception(() => registrantRepo.Insert(registrant));

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ArgumentNullException>(result);
        }

        [Fact]
        [Trait("Integration", "Repo")]
        public void AddNewRegistrant()
        {
            // Arrange
            var registrant = new Registrant
            {
                FirstName = "Anibal",
                LastName = "Tester"
            };

            // Act
            var result = registrantRepo.Insert(registrant);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(result.FirstName, registrant.FirstName);

            // Analyze
            console.WriteLine("First Name: {0}, Last Name: {1}", result.FirstName, result.LastName );
        }

        [Fact]
        [Trait("Integration", "Repo")]
        public void AddNewRegistrantWithAddress()
        {
            // Arrange
            var registrant = new Registrant
            {
                FirstName = "Anibal",
                LastName = "Tester",
                Addresses =
                {
                    new Address
                    {
                        Street = "Liskov",
                        City = "Cambridge",
                        StateId = 22,
                        CountryId = 1,
                        ZipCode = "02139",
                        AddressTypeId = 1
                    }
                }
            };

            // Act
            var result = registrantRepo.Insert(registrant);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(result.FirstName, registrant.FirstName);

            // Analyze
            console.WriteLine("First Name: {0}, Last Name: {1}", result.FirstName, result.LastName);
        }

        [Theory]
        [InlineData("A32DA957-868C-48F8-83F8-11E5AE5263E2")]
        [InlineData("415280A8-C4DE-400E-A673-C5FD0198FEA8")]
        [InlineData("5B54C1F4-5114-4C8B-8891-5B42420188E5")]
        [InlineData("3C0CAD4C-8FD6-42FB-8E00-5DE9C66BB15B")]
        [Trait("Integration", "Repo")]
        public void GetRegistrantById(string registrantId)
        {
            // Arrange
            var registrantGuid = Guid.Parse(registrantId); // here we've selected a known db entry

            // Act
            var result = registrantRepo.Get(registrantGuid);

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void GetAllRegistrants()
        {
            // Arrange


            // Act
            var result = registrantRepo.Get();

            // Assert
            Assert.NotEmpty(result);
            Assert.NotNull(result);

            // Analyze
            foreach (var item in result)
            {
                console.WriteLine(item.Addresses.FirstOrDefault(x => x.AddressTypeId == 1).State.Name);
            }
        }
    }
}
