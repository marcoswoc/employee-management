namespace EmployeeManagement.Domain.Entities;

public class Employee
{
    public Guid Id { get; set; }
    public required string FirstName { get; set; }
    public required string FullName { get; set; }
    public required string Email { get; set; }
    public required string CPF { get; set; }
    public required string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime HireDate { get; set; }

    // Foreign Keys
    public Guid DepartmentId { get; set; }
    public Guid? ManagerId { get; set; }

    // Navigation Properties
    public required Department Department { get; set; }
    public Employee? Manager { get; set; }
    public ICollection<Employee> DirectReports { get; private set; } = new List<Employee>();

    // Metadata
    public string Status { get; set; } = "Active"; // Active, Inactive, On Leave
    public DateTime CreatedAt { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime UpdatedAt { get; set; }
    public Guid UpdatedBy { get; set; }

    // Business Logic Methods
    public bool IsActive() => Status == "Active";

    public void Deactivate(Guid deactivatedBy)
    {
        Status = "Inactive";
        UpdatedAt = DateTime.UtcNow;
        UpdatedBy = deactivatedBy;
    }
}