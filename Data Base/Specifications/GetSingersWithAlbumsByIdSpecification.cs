using Ardalis.Specification;
using Data_Base.Entities;

namespace Data_Base.Specifications;

internal class GetSingersWithAlbumsByIdSpecification : Specification<Singer>
{
    public GetSingersWithAlbumsByIdSpecification(int id)
    {
        Query.AsNoTracking().Where(s => s.Id == id).Include(s => s.Albums);
    }
}
