namespace EmployeeManagement.Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public bool IsActive { get; set; }
    public string[] Roles { get; set; } = ["User"];
    public DateTime CreatedAt { get; set; }
    public DateTime LastLogin { get; set; }
}
