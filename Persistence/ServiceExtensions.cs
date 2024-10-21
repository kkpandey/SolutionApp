using Application.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repository;
using Persistence.Repository.EmployeeRepository;

namespace Persistence
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SolutionDBContext>(options => options.UseInMemoryDatabase("TestDb"));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IEmpRepository, EmployeeRepository>();
        }
    }
}
