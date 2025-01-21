using Microsoft.EntityFrameworkCore;

namespace MyFirstWebApp.Data
{
    public class WebDbContext : DbContext
    {
        public WebDbContext(DbContextOptions<WebDbContext> options) : base(options) { }

        public DbSet<HangHoa> HangHoas { get; set; }

        public DbSet<Loai> Loais { get; set; }
    }
}
