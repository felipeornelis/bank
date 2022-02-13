namespace Bank.Entities;

public class Account : EntityBase
{
    public string Name { get; set; } = string.Empty;

    public Guid Institution { get; set; }

    public AccountType Type { get; set; }

    public Colors Color { get; set; }

    public Guid User { get; set; }

    public bool Considered { get; set; }
}