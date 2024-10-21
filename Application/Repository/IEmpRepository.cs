using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public interface IEmpRepository:IBaseRepository<Employee>
    {
        Task<bool> GetByID(int EmployeeId, CancellationToken cancellationToken);
        Task<List<Employee>> GetByAll(CancellationToken cancellationToken);
    }
}
