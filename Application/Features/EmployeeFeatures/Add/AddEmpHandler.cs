using Application.Common;
using Application.Repository;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.EmployeeFeatures.Add
{
    public sealed class AddEmpHandler:IRequestHandler<EmployeeCommand,BaseResponse<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IEmpRepository _empRepository;
        public AddEmpHandler(IUnitOfWork unitOfWork, IMapper mapper, IEmpRepository empRepository)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _empRepository = empRepository;
        }
        public async Task<BaseResponse<bool>> Handle(EmployeeCommand request,CancellationToken cancellationToken) {
            var response = new BaseResponse<bool>();
            try
            {
                var emp = _mapper.Map<Employee>(request);
                var checkexit =await _empRepository.GetByID(request.EmployeeId, cancellationToken);
                if (!checkexit)
                {
                    _empRepository.Create(emp);
                    await _unitOfWork.Save(cancellationToken);
                    response.succcess = true;
                    response.Message = "Created";
                }
                else
                {
                    response.succcess = true;
                    response.Message = "Already exit";
                }
            }
            catch (Exception ex) {
            response.Message = ex.Message;
            }
            return response;
        }
    }
}
