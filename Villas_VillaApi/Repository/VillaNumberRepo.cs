using Villas_VillaApi.Data;
using Villas_VillaApi.Models;
using Villas_VillaApi.Repository.IRepository;

namespace Villas_VillaApi.Repository
{
    public class VillaNumberRepo : Repo<VillaNumber>, IVillaNumberRepo
    {
        private AppDbContext _db;
        public VillaNumberRepo(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<VillaNumber> UpdateAsync(VillaNumber entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
