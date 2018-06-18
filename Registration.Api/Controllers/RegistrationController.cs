using AutoMapper;
using Registration.Api.Models;
using Registration.Domain;
using Registration.Service.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using Registration.Api.Interfaces;

namespace Registration.Api.Controllers
{
    [RoutePrefix("api/Registration")]
    [EnableCors("*", "*", "*")]
    public class RegistrationController : ApiController
    {
        // Here we would probably rename this controller to something like 'Account' controller 
        // This controller wuould be used to handle  anything related to user registration and login functionality
        // After implementing user authentication (e.g., Identity, Ownin Auth) we would annotate methods to restrict access by user role, for example.

        private readonly IMappingEngine mapper;
        private readonly IRegistrationService registrationService;
        private readonly IAddressOptionService addressOptionService;
        private readonly IRegistrantMapper registrantMapper;
        private readonly IRegistrationFormMapper registrationFormMapper;

        public RegistrationController(IMappingEngine mapper, IRegistrationService registrationService, IAddressOptionService addressOptionService, IRegistrantMapper registrantMapper, IRegistrationFormMapper registrationFormMapper)
        {
            this.mapper = mapper;
            this.registrationService = registrationService;
            this.addressOptionService = addressOptionService;
            this.registrantMapper = registrantMapper;
            this.registrationFormMapper = registrationFormMapper;
        }


        [HttpGet]
        [Route("Admin/Listing")]
        [ResponseType(typeof(IEnumerable<RegistrationViewModel>))]
        public IHttpActionResult GetAdminListing()
        {
            var errorMessage = "There was a problem retrieving the list of registrants.";
            
            try
            {
                /*********************************************************************
                // TODO: create services to make sure that the current (logged in) user
                // is in the right role and has the right permissions to execute request.
                var currentUserId = someUtility.GetUserId(User;
                var isAdmin = someService.AuthenticateeUser(currentUserId);

                if(!isAdmin)
                {
                    return Unauthorized();
                } ********************************************************************/

                var result = registrantMapper.MapDomainCollectionToViewModel(registrationService.Get()).OrderByDescending(x => x.CreatedDate);

                return Ok(result);
            }
            catch (Exception)
            {
                // TODO: Add logging to capture specific exception
                return BadRequest(errorMessage);
            }
        }


        [HttpGet]
        [Route("Options/States")]
        [ResponseType(typeof(IEnumerable<DropDownOption>))]
        public IHttpActionResult GetStateOptions()
        {
            const string errorMessage = "There was a problem retrieving the State Options.";

            try
            {
                var result = mapper.Mapper.Map<IEnumerable<DropDownOption>>(addressOptionService.GetStates());

                return Ok(result);
            }
            catch (Exception)
            {
                // TODO: Add logging to capture specific exception
                return BadRequest(errorMessage);
            }
        }

        [HttpGet]
        [Route("Options/Countries")]
        [ResponseType(typeof(IEnumerable<DropDownOption>))]
        public IHttpActionResult GetCountryOptions()
        {
            const string errorMessage = "There was a problem retrieving the Country Options.";

            try
            {
                var result = mapper.Mapper.Map<IEnumerable<DropDownOption>>(addressOptionService.GetCountries());

                return Ok(result);
            }
            catch (Exception)
            {
                // TODO: Add logging to capture specific exception
                return BadRequest(errorMessage);
            }
        }

        [HttpGet]
        [Route("Options/AddressTypes")]
        [ResponseType(typeof(IEnumerable<DropDownOption>))]
        public IHttpActionResult GetAddressTypeOptions()
        {
            const string errorMessage = "There was a problem retrieving the AddressType Options.";

            try
            {
                var result = mapper.Mapper.Map<IEnumerable<DropDownOption>>(addressOptionService.GetAddressTypes());

                return Ok(result);
            }
            catch (Exception)
            {
                // TODO: Add logging to capture specific exception
                return BadRequest(errorMessage);
            }
        }


        // POST: api/Registration
        [HttpPost]
        [Route("")]
        [ResponseType(typeof(RegistrationViewModel))]
        public IHttpActionResult Post([FromBody]RegistrationBindingModel model)
        {
            const string errorMessage = "The was a problem submitting the registration.";

            try
            {
                var domainModel = registrationService.Save(mapper.Mapper.Map<Registrant>(model));
                //var result = mapper.Mapper.Map<RegistrationViewModel>(domainModel);
                var result = registrantMapper.MapDomainToViewModel(domainModel);

                if (result == null)
                {
                    return BadRequest(errorMessage);
                }

                return Ok(result);
            }
            catch (Exception) 
            {
                // TODO: Add logging to capture specific exception
                return BadRequest(errorMessage);
            }
        }


        [HttpGet]
        [Route("")]
        [ResponseType(typeof(RegistrationFormViewModel))]
        public IHttpActionResult Get()
        {
            const string errorMessage = "There was a problem loading the registration data.";

            try
            {
                var registrant = new Registrant();
                var result = registrationFormMapper.MapDomainToViewModel(registrant);

                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest(errorMessage);
            }
        }

        [HttpGet]
        [Route("")]
        [ResponseType(typeof(RegistrationFormViewModel))]
        public IHttpActionResult Get(Guid id)
        {
            const string errorMessage = "There was a problem loading the registration data.";

            try
            {
                var registrant = registrationService.Get(id);
                var result = registrationFormMapper.MapDomainToViewModel(registrant);

                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest(errorMessage);
            }
        }

    }
}
