using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Vesuvio.Generics.Application.ViewModels;

namespace Vesuvio.Generics.Application.Employees.Queries
{
    public class GetEmployeesQuery : IRequest<IList<EmployeeViewModel>>
    {
        public string User { get; set; }
    }
}
