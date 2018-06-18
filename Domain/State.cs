using System.Collections.Generic;

namespace Registration.Domain
{
    public class State
    {
        public State()
        {
            this.Addresses = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string USPSCode { get; set; }
        public int Position { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
