using Villas_VillaApi.Models;

namespace Villas_VillaApi.Repository.IRepository
{
    public interface IVillaRepo : IRepo<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);
    }
}
