namespace Bank.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly List<Account> _repository = new();

    public Account Create(CreateAccountDTO payload)
    {
        Account account = new()
        {
            Name = payload.Name,
            Institution = payload.Institution,
            Type = payload.Type,
            Color = payload.Color,
            Considered = payload.Considered,
            User = payload.User,
        };

        _repository.Add(account);

        return account;
    }

    public Account? FindByName(string name, Guid user)
    {
        Account? account = _repository.FirstOrDefault<Account>(account => account.Name.Equals(name) && account.User.Equals(user));

        return account;
    }
}