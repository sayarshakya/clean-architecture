using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Vesuvio.Generics.Application.Employees.Commands;

namespace Vesuvio.Generics.Application.Employees.Validators
{
    public class CreateEmployeeCommandValidator : AbstractValidator<CreateEmployeeCommand>
    {
        public CreateEmployeeCommandValidator()
        {
            RuleFor(v => v.FirstName).NotNull();
            RuleFor(v => v.LastName).NotNull();
            //RuleFor(v => v.DateOfBirth).NotNull();
        }
    }
}
