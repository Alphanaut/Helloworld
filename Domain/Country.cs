using System.Collections.Generic;

namespace Registration.Domain
{
    public class Country
    {
        public Country()
        {
            this.Addresses = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
