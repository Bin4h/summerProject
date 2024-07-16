using Ardalis.Specification;
using Data_Base.Entities;

namespace Data_Base.Specifications;

internal class GetUserByLogin : Specification<User>
{
    public GetUserByLogin(string login)
    {
        Query.AsNoTracking().Where(s => s.Login == login);
    }
}
