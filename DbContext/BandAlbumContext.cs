using BandAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandAPI.DBContext
{
    public class BandAlbumContext: DbContext
    {
        public BandAlbumContext(DbContextOptions<BandAlbumContext> options): 
            base (options)
        {
            
        }

        public DbSet<Band> Bands { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Band>().HasData(new Band()
            {
                Id = Guid.Parse("01060680-4444-4500-0581-010300377660"),
                Name = "Metalica",
                Founded = new DateTime(1980, 1, 1),
                MainGenre = "Heavy Metal"
            },
            new Band
            {
                Id = Guid.Parse("01060680-4444-4500-0581-010300377669"),
                Name = "Ross",
                Founded = new DateTime(1988, 2, 2),
                MainGenre = "Rap"
            });

            modelBuilder.Entity<Album>().HasData(new Album()
            {
                Id = Guid.Parse("01060680-4444-4500-0581-010300377668"),
                Title = "Master of Puppets",
                Description = "Bets album ever",
                BandId = Guid.Parse("01060680-4444-4500-0581-010300377660")
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
