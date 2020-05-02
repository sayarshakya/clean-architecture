using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Vesuvio.Generics.Application.Employees.Commands;
using Vesuvio.Generics.Application.ViewModels;
using Vesuvio.Generics.Domain.Entities;

namespace Vesuvio.Generics.Application.Employees.MappingProfiles
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<Employee, EmployeeViewModel>();
            CreateMap<EmployeeViewModel, Employee>();
            CreateMap<CreateEmployeeCommand, Employee>();
        }
    }
}
