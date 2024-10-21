using Application.Repository;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repository.EmployeeRepository
{
    public class EmployeeRepository:BaseRepository<Employee>,IEmpRepository
    {
        public EmployeeRepository(SolutionDBContext context) : base(context)
        {
        }

        public Task<bool> GetByID(int EmployeeId, CancellationToken cancellationToken)
        {
            return Context.Employees.AnyAsync(x => x.EmployeeId == EmployeeId, cancellationToken);
        }
        public Task<List<Employee>> GetByAll(CancellationToken cancellationToken)
        {
            return Context.Employees.ToListAsync(cancellationToken);
        }
    }
}
