namespace Bank.Dto;

public class CreateStatementDTO
{
    public DateTime BillingCycle  { get; set; } // Data do vencimento do cartão

    public StatementSituation Situation { get; set; }

    public Guid CreditCard { get; set; }
}