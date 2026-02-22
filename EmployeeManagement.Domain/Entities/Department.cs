namespace EmployeeManagement.Domain.Entities;
public class Department
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    // Navigation
    public ICollection<Employee> Employees { get; private set; } = new List<Employee>();

}

