using System.Collections.Generic;

namespace Registration.Domain
{
    public class AddressType
    {
        public AddressType()
        {
            this.Addresses = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Position { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
