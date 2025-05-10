namespace EmployeeService.Application.Employees.Queries;

public class EmployeeDto
{
    public string FullName { get; set; } = default!;
    public string JobTitle { get; set; } = default!;
    public DateTime DateOfBirth { get; set; }
    public DateTime EmploymentDate { get; set; }
    public decimal Salary { get; set; }
}
