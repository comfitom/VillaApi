using Villas_VillaApi.Models;

namespace Villas_VillaApi.Repository.IRepository
{
    public interface IVillaNumberRepo : IRepo<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}
