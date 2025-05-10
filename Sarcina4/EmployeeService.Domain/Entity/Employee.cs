using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService.Domain.Entity
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; } = default!;
        public DateTime DateOfBirth { get; set; }
        public DateTime EmploymentDate { get; set; }

        public int JobTitleId { get; set; }
        public JobTitle JobTitle { get; set; } = default!;
    }

}
