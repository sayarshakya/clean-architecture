using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vesuvio.Generics.Application.Employees.Commands
{
    public class CreateEmployeeCommand : IRequest<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
