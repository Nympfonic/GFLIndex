using Microsoft.EntityFrameworkCore;

namespace GFLIndexBackend.Models
{
    public class GFLContext : DbContext
    {
        public static GFLContext Instance { get; } = new GFLContext();

        public GFLContext() { }

        public GFLContext(DbContextOptions<GFLContext> options) : base(options) { }

        public DbSet<Doll> Dolls { get; set; } = null!;
        public DbSet<DollSkill> DollSkills { get; set; } = null!;
        public DbSet<DollType> DollTypes { get; set; } = null!;
        public DbSet<DollRarity> DollRarities { get; set; } = null!;
        public DbSet<DollStats> DollStats { get; set; } = null!;
        public DbSet<DollTiles> DollTiles { get; set; } = null!;
        public DbSet<DollMod> DollMods { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
                options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GFLIndex;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
