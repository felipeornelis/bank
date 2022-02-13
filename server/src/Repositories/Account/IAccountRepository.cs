namespace Bank.Repositories;

public interface IAccountRepository
{
    Account Create(CreateAccountDTO payload);
    Account? FindByName(string name, Guid user);
}