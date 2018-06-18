using Registration.Api.Models;
using Registration.Domain;

namespace Registration.Api.Interfaces
{
    public interface IRegistrationFormMapper : IDomainMapper<Registrant, RegistrationFormViewModel>
    {
    }
}
