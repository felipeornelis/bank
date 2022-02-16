namespace Bank.UseCases;

public class ListAllStatementsService
{
    private readonly IStatementRepository _repository;

    public ListAllStatementsService(IStatementRepository repository)
    {
        _repository = repository;
    }

    public List<Statement> Execute(Guid id)
    {
        List<Statement> statements = _repository.FindByCreditCard(id);

        if(statements.Count == 0)
        {
            throw new StatementNotFound(
                StatementNotFound.Information
            );
        }

        return statements;
    }
}