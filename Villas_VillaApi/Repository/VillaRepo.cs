using Villas_VillaApi.Data;
using Villas_VillaApi.Models;
using Villas_VillaApi.Repository.IRepository;

namespace Villas_VillaApi.Repository
{
    public class VillaRepo : Repo<Villa>, IVillaRepo
    {
        private readonly AppDbContext _db;
        public VillaRepo(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Villa> UpdateAsync(Villa entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
