using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Wiz.Core.Domain;

namespace Wiz.Data
{
    public class WizContext:IdentityDbContext<ApplicationUser, IdentityRole,string>
    {
        public WizContext(DbContextOptions<WizContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }

        public DbSet<Test> Tests { get; set; }
        public DbSet<TestType> TestTypes { get; set; }
    }
}
