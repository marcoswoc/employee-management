namespace EmployeeManagement.Domain.ValueObjects;

public class Cpf
{
    public string Value { get; }

    public Cpf(string value)
    {
        if (!IsValid(value))        
            throw new ArgumentException("CPF inválido");
        

        Value = value[..'.'][..'-'];
    }

    private static bool IsValid(string cpf) => !string.IsNullOrWhiteSpace(cpf) && cpf.Length >= 11;

    public override string ToString() => Value;
}
