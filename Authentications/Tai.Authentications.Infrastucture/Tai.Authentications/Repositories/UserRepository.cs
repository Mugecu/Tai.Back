using Common.Entities;
using Microsoft.EntityFrameworkCore;
using Tai.Authentications.Entities;
using Tai.Authentications.Infrastucture;

namespace Tai.Authentications.Infrastructure.Repositories
{
    public class UserRepository : Repository<User>
    {
        //добавить фабрику ORM вместо EF
        private readonly TaiDbContext _context;

        public UserRepository(TaiDbContext context)
        {
            _context = context;
        }

        public override async Task<User> CreateAsync(User root)
            => (await _context.Set<User>().AddAsync(root)).Entity;

        public override async Task<User?> GetAsync(Guid id)
            => await _context.Set<User>().FirstOrDefaultAsync(i => i.Id == id);

        public override async Task SaveAsync()
            => await _context.SaveChangesAsync();
    }
}
