namespace Bank.Entities;

public class Category : EntityBase
{
    public string Name { get; set; } = string.Empty;

    public string Icon { get; set; } = string.Empty;

    public TransactionType Type { get; set; }
}