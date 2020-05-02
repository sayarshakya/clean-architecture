using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vesuvio.Generics.Application.Common.Interfaces;
using Vesuvio.Generics.Application.Employees.Commands;
using Vesuvio.Generics.Application.Employees.Queries;
using Vesuvio.Generics.Application.ViewModels;

namespace Vesuvio.Generics.Api.Controllers
{
    [Authorize]
    public class EmployeesController : ApiController
    {
        private readonly ICurrentUserService _currentUserService;

        public EmployeesController(ICurrentUserService currentUserService)
        {
            _currentUserService = currentUserService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateEmployeeCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpGet]
        public async Task<IList<EmployeeViewModel>> Get()
        {
            return await Mediator.Send(new GetEmployeesQuery { User = _currentUserService.UserId });
        }
    }
}