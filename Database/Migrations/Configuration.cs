using Registration.Domain;

namespace Registration.DataLayer.Migrations
{
    using System.Data.Entity.Migrations;

    //internal sealed class Configuration : DbMigrationsConfiguration<Registration.DataLayer.RegistrationContext>
    public class Configuration : DbMigrationsConfiguration<Registration.DataLayer.RegistrationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Registration.DataLayer.RegistrationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.AddressTypes.AddOrUpdate(
                p => p.Name,
                    new AddressType { Name = "Address1", Description = "Address 1" , Position = 1 },
                    new AddressType { Name = "Address2", Description = "Address 2" , Position = 2 }
                );

            context.Countries.AddOrUpdate(
                p => p.Name,
                    new Country { Name = "United States", CountryCode = "USA" }
                );

            context.States.AddOrUpdate(
                p => p.Name,
                new State { USPSCode = "AL", Name = "Alabama", Position = 1 },
                new State { USPSCode = "AK", Name = "Alaska", Position = 2 },
                new State { USPSCode = "AZ", Name = "Arizona", Position = 3 },
                new State { USPSCode = "AR", Name = "Arkansas", Position = 4 },
                new State { USPSCode = "CA", Name = "California", Position = 5 },
                new State { USPSCode = "CO", Name = "Colorado", Position = 6 },
                new State { USPSCode = "CT", Name = "Connecticut", Position = 7 },
                new State { USPSCode = "DE", Name = "Delaware", Position = 8 },
                new State { USPSCode = "DC", Name = "District of Columbia", Position = 9 },
                new State { USPSCode = "FL", Name = "Florida", Position = 10 },
                new State { USPSCode = "GA", Name = "Georgia", Position = 11 },
                new State { USPSCode = "HI", Name = "Hawaii", Position = 12 },
                new State { USPSCode = "ID", Name = "Idaho", Position = 13 },
                new State { USPSCode = "IL", Name = "Illinois", Position = 14 },
                new State { USPSCode = "IN", Name = "Indiana", Position = 15 },
                new State { USPSCode = "IA", Name = "Iowa", Position = 16 },
                new State { USPSCode = "KS", Name = "Kansas", Position = 17 },
                new State { USPSCode = "KY", Name = "Kentucky", Position = 18 },
                new State { USPSCode = "LA", Name = "Louisiana", Position = 19 },
                new State { USPSCode = "ME", Name = "Maine", Position = 20 },
                new State { USPSCode = "MD", Name = "Maryland", Position = 21 },
                new State { USPSCode = "MA", Name = "Massachusetts", Position = 22 },
                new State { USPSCode = "MI", Name = "Michigan", Position = 23 },
                new State { USPSCode = "MN", Name = "Minnesota", Position = 24 },
                new State { USPSCode = "MS", Name = "Mississippi", Position = 25 },
                new State { USPSCode = "MO", Name = "Missouri", Position = 26 },
                new State { USPSCode = "MT", Name = "Montana", Position = 27 },
                new State { USPSCode = "NE", Name = "Nebraska", Position = 28 },
                new State { USPSCode = "NV", Name = "Nevada", Position = 29 },
                new State { USPSCode = "NH", Name = "New Hampshire", Position = 30 },
                new State { USPSCode = "NJ", Name = "New Jersey", Position = 31 },
                new State { USPSCode = "NM", Name = "New Mexico", Position = 32 },
                new State { USPSCode = "NY", Name = "New York", Position = 33 },
                new State { USPSCode = "NC", Name = "North Carolina", Position = 34 },
                new State { USPSCode = "ND", Name = "North Dakota", Position = 35 },
                new State { USPSCode = "OH", Name = "Ohio", Position = 36 },
                new State { USPSCode = "OK", Name = "Oklahoma", Position = 37 },
                new State { USPSCode = "OR", Name = "Oregon", Position = 38 },
                new State { USPSCode = "PA", Name = "Pennsylvania", Position = 39 },
                new State { USPSCode = "RI", Name = "Rhode Island", Position = 40 },
                new State { USPSCode = "SC", Name = "South Carolina", Position = 41 },
                new State { USPSCode = "SD", Name = "South Dakota", Position = 42 },
                new State { USPSCode = "TN", Name = "Tennessee", Position = 43 },
                new State { USPSCode = "TX", Name = "Texas", Position = 44 },
                new State { USPSCode = "UT", Name = "Utah", Position = 45 },
                new State { USPSCode = "VT", Name = "Vermont", Position = 46 },
                new State { USPSCode = "VA", Name = "Virginia", Position = 47 },
                new State { USPSCode = "WA", Name = "Washington", Position = 48 },
                new State { USPSCode = "WV", Name = "West Virginia", Position = 49 },
                new State { USPSCode = "WI", Name = "Wisconsin", Position = 50 },
                new State { USPSCode = "WY", Name = "Wyoming", Position = 51 }
                );
        }
    }
}
