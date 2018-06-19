using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Registration.Service.Interfaces;
using Registration.Service;
using Registration.Repo.Interfaces;
using Registration.Repo;
using AutoMapper;
using System.Web.Http;
using Unity.WebApi;
using Registration.Api.Controllers;
using Registration.Api.Interfaces;
using Registration.Api.Services.Mapper;
using Registration.Api.Services;

namespace Registration.Api
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below. Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your types here
            container.RegisterType<IMappingEngine>(new InjectionFactory(_ => Mapper.Engine));
            container.RegisterType<ILog, NLogService>();
            
            container.RegisterType<IRegistrationService, RegistrationService>();
            container.RegisterType<IAddressOptionService, AddressOptionService>();
            container.RegisterType<IRegistrantMapper, RegistrantMapper>();
            container.RegisterType<IRegistrationFormMapper, RegistrationFormMapper>();

            container.RegisterType<IAddressTypeRepository, AddressTypeRepository>();
            container.RegisterType<ICountryRepository, CountryRepository>();
            container.RegisterType<IRegistrantRepository, RegistrantRepository>();
            container.RegisterType<IStateRepository, StateRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}
