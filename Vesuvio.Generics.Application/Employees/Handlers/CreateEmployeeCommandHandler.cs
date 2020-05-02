using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vesuvio.Generics.Application.Common.Interfaces;
using Vesuvio.Generics.Application.Employees.Commands;
using Vesuvio.Generics.Domain.Entities;

namespace Vesuvio.Generics.Application.Employees.Handlers
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, int>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CreateEmployeeCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Employee>(request);
            _context.Employees.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.ID;
        }
    }
}
