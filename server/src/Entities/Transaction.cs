namespace Bank.Entities;

public class Transaction
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public int Amount { get; set; }

    public bool Status { get; set; } // paid or not

    public DateTime OperationDate { get; set; }

    public Guid Category { get; set; }

    public Guid Account { get; set; }

    public string? Attachment { get; set; }

    public bool Fixed { get; set; }

    public int? Repeat { get; set; }

    public TransactionType Type { get; set; }

    public Guid? Statement { get; set; }

    public int? Stallment { get; set; }

    public Guid? CreditCard { get; set; }
}