using Common.Entities;
using Microsoft.EntityFrameworkCore;
using TaiProgramms.Entities;

namespace Tai.Programs.Infrastructure.Repositories
{
    public class TaiProgrammRepository : Repository<TaiProgramm>
    {
        private readonly TaiProgrammDbContext _context;

        public TaiProgrammRepository(TaiProgrammDbContext context)
        {
            _context = context;
        }

        public override async Task<TaiProgramm> CreateAsync(TaiProgramm root)
            => await _context.Set<TaiProgramm>().AnyAsync(p => p.Id == root.Id) 
                ? throw new Exception($"Программа с идентификатором {root.Id} уже существует.")
                : (await _context.Set<TaiProgramm>().AddAsync(root)).Entity;

        public override Task<TaiProgramm?> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public override Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
