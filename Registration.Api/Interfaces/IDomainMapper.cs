using System.Collections.Generic;

namespace Registration.Api.Interfaces
{
    public interface IDomainMapper<TdomainObj, TviewModelObj>
    {
        TviewModelObj MapDomainToViewModel(TdomainObj domain);
        IEnumerable<TviewModelObj> MapDomainCollectionToViewModel(IEnumerable<TdomainObj> domainList);
    }
}
