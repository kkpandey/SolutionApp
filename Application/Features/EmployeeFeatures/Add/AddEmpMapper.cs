using AutoMapper;
using Domain.Entities;
namespace Application.Features.EmployeeFeatures.Add
{
    public sealed class AddEmpMapper:Profile
    {
        public AddEmpMapper() {
            CreateMap<EmployeeCommand, Employee>();
            CreateMap<Employee,EmployeeCommand>();
        }
    }
}
