namespace Bank.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly List<Account> _repository = new()
    {
        new Account()
        {
            Name = "Carteira PicPay",
            Institution = Guid.Parse("43f48f96-a447-4bce-add7-9533d1557430"),
            Type = AccountType.Current,
            Color = Colors.Green,
            User = Guid.Parse("533fd8a9-5cbe-4b12-8257-8a2b3fbe9f38"),
            Considered = false,
            Id = Guid.Parse("cbf9b4fc-0cc9-41c3-acc3-e79a573356a4"),
            CreatedAt = DateTime.Parse("2022-02-13T20:43:17.1867942-03:00"),
            UpdatedAt = null,
            DeletedAt = null
        }
    };

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