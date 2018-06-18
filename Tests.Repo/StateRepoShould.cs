using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Tests.Repo
{
    public class StateRepoShould : TestingBase
    {
        private readonly ITestOutputHelper console;

        public StateRepoShould(ITestOutputHelper console)
        {
            this.console = console;
        }

        [Fact]
        [Trait("Integration", "Repo")]
        public void GetAllStates()
        {
            // Arrange

            
            // Act
            var result = stateRepo.Get().ToList();

            // Assert
            Assert.NotEmpty(result);


            // Analyze
            foreach (var state in result)
            {
                console.WriteLine("{0} is the postal service code for {1}", state.USPSCode, state.Name);
            }
        }
    }
}
