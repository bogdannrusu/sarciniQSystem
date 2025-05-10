using MediatR;
using Microsoft.EntityFrameworkCore;
using EmployeeService.Infrastructure.Data;
using EmployeeService.Application.Employees.Queries;

public record GetEmployeesQuery(
    string? SearchTerm,
    string? SortBy,
    int PageNumber = 1,
    int PageSize = 10
) : IRequest<List<EmployeeDto>>;

public class GetEmployeesHandler : IRequestHandler<GetEmployeesQuery, List<EmployeeDto>>
{
    private readonly AppDbContext _context;

    public GetEmployeesHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<EmployeeDto>> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
    {
        var query = _context.Employees
            .Include(e => e.JobTitle)
            .AsQueryable();

        // Filtrare
        if (!string.IsNullOrWhiteSpace(request.SearchTerm))
        {
            query = query.Where(e =>
                e.FullName.Contains(request.SearchTerm) ||
                e.JobTitle.Title.Contains(request.SearchTerm));
        }

        // Sortare
        query = request.SortBy?.ToLower() switch
        {
            "fullname" => query.OrderBy(e => e.FullName),
            "employmentdate" => query.OrderBy(e => e.EmploymentDate),
            "salary" => query.OrderBy(e => e.JobTitle.BaseSalary),
            _ => query.OrderBy(e => e.Id)
        };

        // Paginare
        var skip = (request.PageNumber - 1) * request.PageSize;

        var result = await query
            .Skip(skip)
            .Take(request.PageSize)
            .Select(e => new EmployeeDto
            {
                FullName = e.FullName,
                JobTitle = e.JobTitle.Title,
                DateOfBirth = e.DateOfBirth,
                EmploymentDate = e.EmploymentDate,
                Salary = e.JobTitle.BaseSalary
            })
            .ToListAsync(cancellationToken);

        return result;
    }
}
