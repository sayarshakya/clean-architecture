using System;
using System.Collections.Generic;
using System.Text;
using Vesuvio.Generics.Domain.Common;

namespace Vesuvio.Generics.Domain.Entities
{
    public class Employee : CommonEntity
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
