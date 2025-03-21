using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NZWalks.API.Data
{
    public class NZWalksAuthDbContext : IdentityDbContext
    {
        public NZWalksAuthDbContext(DbContextOptions<NZWalksAuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var ReaderID = "9d78ca4f-37da-427f-9ec1-29fe0f0e0656";
            var WriterID = "338892f6-c896-40ce-b7b7-962e710d3b84";

            var roles = new List<IdentityRole>()
            {
                new IdentityRole()
                {
                    Id = ReaderID,
                    ConcurrencyStamp = ReaderID,
                    Name = "Reader",
                    NormalizedName = "Reader".ToUpper()
                },
                new IdentityRole()
                {
                    Id = WriterID,
                    ConcurrencyStamp = WriterID,
                    Name = "Writer",
                    NormalizedName = "Writer".ToUpper()
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
