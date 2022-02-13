namespace Bank.Dto;

public class CreateAccountDTO
{
    public string Name { get; set; } = string.Empty;

    public Guid Institution { get; set; }

    public Guid User { get; set; 
    }
    public AccountType Type { get; set; }

    public Colors Color { get; set; }
    
    public bool Considered { get; set; }
}

