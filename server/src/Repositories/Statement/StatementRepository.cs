namespace Bank.Repositories;

public class StatementRepository : IStatementRepository
{
    private List<Statement> _repository = new()
    {
        new Statement()
        {
            BillingCycle = DateTime.Parse("2022-02-19T00:00:00"),
            Situation = 0,
            CreditCard = Guid.Parse("8103ffb7-e62b-4dcb-8a4d-980290a08cef"),
            Id = Guid.Parse("31bcc189-1b3a-4d3e-ac7a-0e38f493be77"),
            CreatedAt = DateTime.Parse("2022-02-14T06:27:55.1413814-03:00"),
            UpdatedAt = null,
            DeletedAt = null
        }
    };

    public Statement Create(CreateStatementDTO payload)
    {
        Statement statement = new()
        {
            BillingCycle = payload.BillingCycle,
            Situation = payload.Situation,
            CreditCard = payload.CreditCard,
        };

        _repository.Add(statement);

        return statement;
    }

    public List<Statement> FindByCreditCard(Guid id)
    {
        List<Statement> statements = _repository.Where<Statement>(statement => statement.CreditCard.Equals(id)).ToList();

        return statements;
    }

    public Statement? FindById(Guid id)
    {
        Statement? statement = _repository.FirstOrDefault<Statement>(statement => statement.Id.Equals(id));

        return statement;
    }

    public Statement Update(UpdateStatementDTO payload, Guid id)
    {
        Statement statement = _repository.First<Statement>(statement => statement.Id.Equals(id));
        int index = _repository.IndexOf(statement);

        statement.BillingCycle = payload.BillingCycle ?? statement.BillingCycle;
        statement.Situation = payload.Situation ?? statement.Situation;

        
        _repository[index] = statement;

        return _repository[index];
    }
}