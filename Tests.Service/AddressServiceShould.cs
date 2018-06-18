using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Tests.Service
{
    public class AddressServiceShould : TestingBase
    {
        private readonly ITestOutputHelper console;

        public AddressServiceShould(ITestOutputHelper console)
        {
            this.console = console;
        }

        [Fact]
        [Trait("Integration", "Service")]
        public void ReturnAddressTypes()
        {
            // Arrange

            // Act
            var result = addressOptionService.GetAddressTypes();

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);

            // Analyze
            foreach (var item in result)
            {
                console.WriteLine("Result id: {0}, name: {1}", item.Id, item.Name);
            }
        }

        [Fact]
        [Trait("Integration", "Service")]
        public void ReturnSates()
        {
            // Arrange

            // Act
            var result = addressOptionService.GetStates();

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);

            // Analyze
            foreach (var item in result)
            {
                console.WriteLine("Result id: {0}, name: {1}", item.Id, item.Name);
            }
        }

        [Fact]
        [Trait("Integration", "Service")]
        public void ReturnRegistrants()
        {
            // Arrange

            // Act
            var result = registrationService.Get();

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);

            // Analyze
            foreach (var item in result)
            {
                console.WriteLine("Result id: {0}, name: {1}, {2}", item.Id, item.LastName, item.FirstName);
            }
        }
    }
}
