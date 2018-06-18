using System;
using System.Collections.Generic;

namespace Registration.Domain
{
    public class Registrant
    {
        public Registrant()
        {
            Addresses = new HashSet<Address>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedDate { get; set; }
    

        // Navigation Property
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
