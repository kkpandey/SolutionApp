using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repository.EmployeeRepository
{
    public class EmployeeRepository:BaseRepository<Employee>
    {
        public EmployeeRepository(SolutionDBContext context) : base(context)
        {
        }

        public Task<Employee?> GetByID(int EmployeeId, CancellationToken cancellationToken)
        {
            return Context.Employees.FirstOrDefaultAsync(x => x.EmployeeId == EmployeeId, cancellationToken);
        }
    }
}
