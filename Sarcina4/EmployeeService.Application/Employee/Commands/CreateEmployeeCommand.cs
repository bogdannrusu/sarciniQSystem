using EmployeeService.Domain.Entity;
using EmployeeService.Infrastructure.Data;
using MediatR;

public record CreateEmployeeCommand(string FullName, DateTime DateOfBirth, DateTime EmploymentDate, int JobTitleId) : IRequest<int>;

public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, int>
{
    private readonly AppDbContext _context;

    public CreateEmployeeHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
    {
        var employee = new Employee
        {
            FullName = request.FullName,
            DateOfBirth = request.DateOfBirth,
            EmploymentDate = request.EmploymentDate,
            JobTitleId = request.JobTitleId
        };

        _context.Employees.Add(employee);
        await _context.SaveChangesAsync(cancellationToken);

        return employee.Id;
    }
}
