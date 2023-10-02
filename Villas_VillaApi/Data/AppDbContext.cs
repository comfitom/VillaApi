using Microsoft.EntityFrameworkCore;
using Villas_VillaApi.Models;

namespace Villas_VillaApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> villaNumbers { get; set; }
        public DbSet<LocalUser> localUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...",
                    ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Funsplash.com%2Fs%2Fphotos%2Fvilla&psig=AOvVaw0pByoKewJvb4TImGr28PGO&ust=1694522629380000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCIDm_uvKooEDFQAAAAAdAAAAABAE",
                    Occupancy = 2,
                    Rate = 700,
                    Sqft = 600,
                    Amenity = "",
                    CreatedDate = DateTime.Now

                },
                new Villa
                {
                    Id = 2,
                    Name = "Royal Pool Villa",
                    Details = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...",
                    ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.istockphoto.com%2Fphotos%2Fvilla&psig=AOvVaw0pByoKewJvb4TImGr28PGO&ust=1694522629380000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCIDm_uvKooEDFQAAAAAdAAAAABAI",
                    Occupancy = 2,
                    Rate = 790,
                    Sqft = 650,
                    Amenity = "",
                    CreatedDate = DateTime.Now

                },
                new Villa
                {
                    Id = 3,
                    Name = "Premium Villa",
                    Details = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...",
                    ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fstock.adobe.com%2Fsearch%3Fk%3Dvilla&psig=AOvVaw0pByoKewJvb4TImGr28PGO&ust=1694522629380000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCIDm_uvKooEDFQAAAAAdAAAAABAQ",
                    Occupancy = 3,
                    Rate = 1000,
                    Sqft = 750,
                    Amenity = "",
                    CreatedDate = DateTime.Now

                },
                new Villa
                {
                    Id = 4,
                    Name = "Premium Pool Villa",
                    Details = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...",
                    ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.shutterstock.com%2Fsearch%2Fvilla&psig=AOvVaw0pByoKewJvb4TImGr28PGO&ust=1694522629380000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCIDm_uvKooEDFQAAAAAdAAAAABAY",
                    Occupancy = 3,
                    Rate = 1500,
                    Sqft = 1050,
                    Amenity = "",
                    CreatedDate = DateTime.Now

                },
                new Villa
                {
                    Id = 5,
                    Name = "Diamond Villa",
                    Details = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...",
                    ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Funsplash.com%2Fs%2Fphotos%2Fvilla&psig=AOvVaw0pByoKewJvb4TImGr28PGO&ust=1694522629380000&source=images&cd=vfe&opi=89978449&ved=0CBAQjRxqFwoTCIDm_uvKooEDFQAAAAAdAAAAABAg",
                    Occupancy = 4,
                    Rate = 2000,
                    Sqft = 1550,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                });
        }
    }
}
