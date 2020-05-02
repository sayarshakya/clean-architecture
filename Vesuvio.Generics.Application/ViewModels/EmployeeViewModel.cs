using System;
using System.Collections.Generic;
using System.Text;

namespace Vesuvio.Generics.Application.ViewModels
{
    public class EmployeeViewModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime Created { get; set; }
    }
}
