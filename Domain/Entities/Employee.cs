using Domain.Common;

namespace Domain.Entities
{
    public class Employee:BaseEntity
    {
        public int EmployeeId { get; set; } = 0;
        public string CompanyName { get; set; }=string.Empty;
        public string VerificationCode { get; set; }=string.Empty;

    }
}
