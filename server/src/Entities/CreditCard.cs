namespace Bank.Entities;

public class CreditCard : EntityBase
{
    public string Name { get; set; } = string.Empty;

    public int StatementClosingDate { get; set; }

    public int PaymentDueDate { get; set; }

    public Guid Institution { get; set; }

    public Guid User { get; set; }

    public int Limit { get; set; } = 0;
}