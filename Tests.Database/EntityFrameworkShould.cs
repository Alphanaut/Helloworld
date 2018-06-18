using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registration.DataLayer;
using Registration.DataLayer.Migrations;
using Registration.Domain;
using Xunit;
using Xunit.Abstractions;

namespace Tests.DataLayer
{
    public class EntityFrameworkShould
    {
        private readonly ITestOutputHelper console;

        public EntityFrameworkShould(ITestOutputHelper console)
        {
            this.console = console;
        }

        [Fact]
        public void InitializeDatabaseWithUser()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<RegistrationContext, Configuration>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<RegistrationContext>());
            // Arrange
            var context = new RegistrationContext();

            var user = new Registrant
            {
                Id = Guid.NewGuid(),
                FirstName = "Anibal",
                LastName = "Tester"
            };

            // Act
            context.Registrants.Add(user);
            context.SaveChanges();

            // Assert
        }
    }
}
