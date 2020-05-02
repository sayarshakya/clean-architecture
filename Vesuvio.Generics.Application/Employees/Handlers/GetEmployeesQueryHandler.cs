using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vesuvio.Generics.Application.Common.Interfaces;
using Vesuvio.Generics.Application.Employees.Queries;
using Vesuvio.Generics.Application.ViewModels;

namespace Vesuvio.Generics.Application.Employees.Handlers
{
    public class GetEmployeesQueryHandler : IRequestHandler<GetEmployeesQuery, IList<EmployeeViewModel>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetEmployeesQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IList<EmployeeViewModel>> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
        {
            var employees = await _context.Employees.Where(i => i.CreatedBy == request.User).ToListAsync();
            var result = new List<EmployeeViewModel>();
            if(employees != null)
            {
                result = _mapper.Map<List<EmployeeViewModel>>(employees);
            }
            return result;
        }
    }
}
