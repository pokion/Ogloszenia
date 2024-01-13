using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OgloszeniaDrobne.Models;

namespace OgloszeniaDrobne
{
    public class DBContext : IdentityDbContext<UserModel>
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<UserModel> UserModels { get; set; }
        public DbSet<AnnoucmentCategory> AnnoucmentCategory { get; set; }
        public DbSet<ForbiddenWords> ForbiddenWords { get; set; }
        public DbSet<ReportedAnnoucment> ReportedAnnoucments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var keysProperties = modelBuilder.Model.GetEntityTypes().Select(x => x.FindPrimaryKey()).SelectMany(x => x.Properties);
            foreach (var property in keysProperties)
            {
                property.ValueGenerated = ValueGenerated.OnAdd;
            }
        }
    }
}
