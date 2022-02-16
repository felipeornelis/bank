namespace Bank.Entities;

public class Statement : EntityBase
{
    public DateTime BillingCycle  { get; set; } // Data do vencimento do cartão

    public StatementSituation Situation { get; set; }

    public Guid CreditCard { get; set; }
}