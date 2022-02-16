namespace Bank.UseCases;

public class UpdateStatementService
{
    private readonly IStatementRepository _repository;

    public UpdateStatementService(IStatementRepository repository)
    {
        _repository = repository;
    }

    public Statement Execute(UpdateStatementDTO payload, Guid id)
    {
        // if(!Enum.IsDefined<StatementSituation>(payload.Situation))
        // {
        //     throw new InvalidStatementSituationException(
        //         InvalidStatementSituationException.Information
        //     );
        // }
        // if(!Enum.IsDefined<StatementSituation>(payload.Situation))
        // {
        //     throw new InvalidStatementSituationException(
        //         InvalidStatementSituationException.Information
        //     );
        // }

        Statement? findStatementById = _repository.FindById(id);

        if(findStatementById == null)
        {
            throw new StatementNotFound(
                StatementNotFound.Information
            );
        }

        Statement statement = _repository.Update(payload, id);

        return statement;
    }
}