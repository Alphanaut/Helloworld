using Xunit;
using Xunit.Abstractions;

namespace Tests.Repo
{
    public class AddressTypeRepoShould : TestingBase
    {
        private readonly ITestOutputHelper console;

        public AddressTypeRepoShould(ITestOutputHelper console)
        {
            this.console = console;
        }

        [Fact]
        [Trait("Integration", "Repo")]
        private void GetAllAddressTypes()
        {
            // Arrange


            // Act
            var result = addressTypeRepo.Get();

            // Assert
            Assert.NotEmpty(result);

            // Analyze
            foreach (var addressType in result)
            {
                console.WriteLine("Address Type: {0}; Sort Order: {1}", addressType.Name, addressType.Position );
            }
        }
    }
}