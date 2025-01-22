using Microsoft.EntityFrameworkCore;
namespace RecordShop
{
    public class RecordShopDbContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        
        public RecordShopDbContext(DbContextOptions<RecordShopDbContext> options) : base(options) { 
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Album>().HasData(
        //        new Album
        //        {
        //            id = 1,
        //            artistName = "Aviators",
        //            albumName = "The Fallen Kingdom",
        //            Songs = {   "Burn",
        //                        "The Fallen Kingdom" }
        //        },
        //         new Album
        //         {
        //             id = 2,
        //             artistName = "Aviators",
        //             albumName = "GodHunter",
        //             Songs = {   "GodHunter",
        //                        "Caste On The Sea"
        //             }
        //         }

        //    );
        //}
    }
}
