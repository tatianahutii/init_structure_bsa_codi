using Codi.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Codi._Core.DAL
{
    public class CodiCoreContext : DbContext
    {
        public DbSet<Sample> Samples { get; private set; }
        public CodiCoreContext(DbContextOptions<CodiCoreContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Configure();
            //modelBuilder.Seed();
        }
    }
}