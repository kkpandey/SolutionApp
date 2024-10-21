using Application.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.EmployeeFeatures.Add
{
    public class EmployeeCommand: IRequest<BaseResponse<bool>>
    {
        public int EmployeeId { get; set; } = 0;
        public string CompanyName { get; set; } = string.Empty;
        public string VerificationCode { get; set; } = string.Empty;
    }
}
