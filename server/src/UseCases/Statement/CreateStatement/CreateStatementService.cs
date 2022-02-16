namespace Bank.UseCases;

public class CreateStatementService
{
    private readonly IStatementRepository _repository;

    public CreateStatementService(IStatementRepository repository)
    {
        _repository = repository;
    }

    public Statement Execute(CreateStatementDTO payload)
    {
        if(!Enum.IsDefined<StatementSituation>(payload.Situation))
        {
            throw new InvalidStatementSituationException(
                InvalidStatementSituationException.Information
            );
        }

        Statement statement = _repository.Create(payload);

        return statement;
    }
}