namespace Bank.Dto;

public class UpdateStatementDTO
{
    public DateTime? BillingCycle { get; set; }

    public StatementSituation? Situation { get; set; }
}