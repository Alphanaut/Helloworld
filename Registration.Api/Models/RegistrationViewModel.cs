using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Registration.Api.Models
{
    public class RegistrationViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; } // concat result in automapper
        public string Country1 { get; set; } // concat result in automapper
        public string Address2 { get; set; }
        public string Country2 { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}