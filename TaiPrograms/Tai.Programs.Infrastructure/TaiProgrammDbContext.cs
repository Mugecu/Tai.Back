using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TaiProgramms.Entities;

namespace Tai.Programs.Infrastructure
{
    public class TaiProgrammDbContext : DbContext
    {
        public DbSet<TaiProgramm> TaiProgramms { get; set; }

        public TaiProgrammDbContext(DbContextOptions<TaiProgrammDbContext> options) : base(options) { }

        private static ModelBuilder CreateTaiProgrammTable(ModelBuilder modelBuilder)
        {
            var jsonSettings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

            //modelBuilder.Entity<TaiProgramm>()
            //    .ToTable("tai_programm")
            //    .HasKey(t => t.Id);

            return modelBuilder;
        }
    }
}