using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Registration.Api.Models
{
    public class RegistrationFormViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street1 { get; set; }
        public string City1 { get; set; }
        public string StateId1 { get; set; }
        public string ZipCode1 { get; set; }
        public string CountryId1 { get; set; }
        public string Street2 { get; set; }
        public string City2 { get; set; }
        public string StateId2 { get; set; }
        public string ZipCode2 { get; set; }
        public string CountryId2 { get; set; }
    }
}