using Application.Repository;
using Persistence.Context;

namespace Persistence.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SolutionDBContext _context;

        public UnitOfWork(SolutionDBContext context)
        {
            _context = context;
        }
        public Task Save(CancellationToken cancellationToken)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }
    }
}
