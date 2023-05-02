using Microsoft.EntityFrameworkCore;

namespace Tai.Authentications.Infrastucture
{
    public class TaiDbContext : DbContext
    {
        public TaiDbContext(DbContextOptions<TaiDbContext> options):base(options) { }
    }
}
