namespace EmployeeManagement.Domain.Entities;

public class AuditLog
{
    public Guid Id { get; set; }
    public required string EntityName { get; set; }
    public Guid EntityId { get; set; }
    public required string Action { get; set; } 
    public string? OldValues { get; set; } 
    public required string NewValues { get; set; } 
    public DateTime CreatedAt { get; set; }
    public Guid CreatedBy { get; set; }
    public required string CreatedByName { get; set; }
}
