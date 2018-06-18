using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Registration.Api.Models
{
    public class RegistrationBindingModel
    {
        [Required]
        [StringLength(36, ErrorMessage = "The {0} must be {} characters long.", MinimumLength = 36)]
        public string Id { get; set; }

        [Required(ErrorMessage = "A FirstName is required.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "A LastName is required.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "A Street is required.")]
        public string Street1 { get; set; }

        [Required(ErrorMessage = "A City is required.")]
        public string City1 { get; set; }

        [Required(ErrorMessage = "A StateId is required.")]
        public int StateId1 { get; set; }

        [Required(ErrorMessage = "A CountryId is required.")]
        public int CountryId1 { get; set; }

        [Required(ErrorMessage = "A ZipCode is required.")]
        public string ZipCode1 { get; set; }

        //[Required(ErrorMessage = "An AddressTypeId is required.")]
        //public int AddressTypeId1 { get; set; }

        [Required(ErrorMessage = "A Street is required.")]
        public string Street2 { get; set; }

        [Required(ErrorMessage = "A City is required.")]
        public string City2 { get; set; }

        [Required(ErrorMessage = "A State is required.")]
        public int StateId2 { get; set; }

        [Required(ErrorMessage = "A Country is required.")]
        public int CountryId2 { get; set; }

        [Required(ErrorMessage = "A ZipCode is required.")]
        public string ZipCode2 { get; set; }

        //[Required(ErrorMessage = "An AddressTypeId is required.")]
        //public int AddressTypeId2 { get; set; }
    }
}