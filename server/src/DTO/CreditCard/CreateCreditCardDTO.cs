namespace Bank.Dto;

public class CreateCreditCardDTO
{
    public string Name { get; set; } = string.Empty;

    public int StatementClosingDate { get; set; }

    public int PaymentDueDate { get; set; }

    public int Limit { get; set; } = 0;

    public Guid User { get; set; }

    public Guid Institution { get; set; }
}