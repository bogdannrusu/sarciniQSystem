using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService.Domain.Entity
{
    public class JobTitle
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public decimal BaseSalary { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }

}
