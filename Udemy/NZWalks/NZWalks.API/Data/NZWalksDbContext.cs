using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext:DbContext
    {
        public NZWalksDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
            
        }

        public DbSet<Difficulty> Difficulties { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Data for Difficulties
            // Easy, Medium, Hard
            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("e5880302-5f64-4bed-be75-7d0e7ed8e245"),
                    Name = "Easy"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("7de173ce-0945-4eba-82c1-c9b32e020caa"),
                    Name = "Medium"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("0016d473-a860-4f6f-8fbf-2c3757ba01f2"),
                    Name = "Hard"
                },
            };

            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            // Seed data for Regions
            var regions = new List<Region>()
            {
                new Region()
                {
                    Id = Guid.Parse("63310c5b-a26c-4f90-b8a6-5d2911b07f74"),
                    Code = "NVK01",
                    Name = "DakLak",
                    RegionImageUrl = "Daklak.jpg",
                },
                new Region()
                {
                    Id = Guid.Parse("85307016-8c38-4197-82c8-943714d45354"),
                    Code = "NVK02",
                    Name = "DaNang",
                    RegionImageUrl = "Danang.jpg",
                },
                new Region()
                {
                    Id = Guid.Parse("d7af3233-58f9-40d0-8e60-6850918bc277"),
                    Code = "NVK03",
                    Name = "SaiGon",
                    RegionImageUrl = "Saigon.jpg",
                },
                new Region()
                {
                    Id = Guid.Parse("c4b20e04-651a-4a51-82a5-aded128f062a"),
                    Code = "NVK04",
                    Name = "VungTau",
                    RegionImageUrl = "Vungtau.jpg",
                },
                new Region()
                {
                    Id = Guid.Parse("fb581494-3eb5-44e4-b220-3849c1a99bfd"),
                    Code = "NVK05",
                    Name = "LamDong",
                    RegionImageUrl = "Dalat.jpg",
                },
            };
            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
