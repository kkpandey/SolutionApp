using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class SolutionDBContext: DbContext
    {
        public SolutionDBContext(DbContextOptions<SolutionDBContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
