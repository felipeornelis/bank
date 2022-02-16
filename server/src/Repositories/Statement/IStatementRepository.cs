namespace Bank.Repositories;

public interface IStatementRepository
{
    Statement Create(CreateStatementDTO payload);
    Statement? FindById(Guid id);
    Statement Update(UpdateStatementDTO payload, Guid id);
    List<Statement> FindByCreditCard(Guid id);
}