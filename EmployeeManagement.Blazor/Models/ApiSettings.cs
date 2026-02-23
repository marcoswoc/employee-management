using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Blazor.Models;

internal sealed class ApiSettings
{
    [Required(ErrorMessage = "BaseUrl é obrigatória")]
    [Url(ErrorMessage = "BaseUrl deve ser uma URL válida")]
    public Uri BaseUrl { get; set; } = null!;
}
