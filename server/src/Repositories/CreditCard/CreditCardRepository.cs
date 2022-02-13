namespace Bank.Repositories;

public class CreditCardRepository : ICreditCardRepository
{
    private List<CreditCard> _repository = new()
    {
        new CreditCard()
        {
            Name = "Nubank",
            StatementClosingDate = 4,
            PaymentDueDate = 3,
            Institution = Guid.Parse("43f48f96-a447-4bce-add7-9533d1557430"),
            Limit = 0,
            Id = Guid.Parse("8103ffb7-e62b-4dcb-8a4d-980290a08cef"),
            CreatedAt = DateTime.Parse("2022-02-13T20:31:06.5684133-03:00"),
            UpdatedAt = null,
            DeletedAt = null
        }
    };

    public CreditCard Create(CreateCreditCardDTO payload)
    {
        CreditCard creditCard = new()
        {
            Name = payload.Name,
            StatementClosingDate = payload.StatementClosingDate,
            PaymentDueDate = payload.PaymentDueDate,
            Institution = payload.Institution,
            Limit = payload.Limit,
            User = payload.User,
        };

        _repository.Add(creditCard);

        return creditCard;
    }

    public CreditCard? FindByNameAndUser(string name, Guid user)
    {
        CreditCard? creditCard = _repository.FirstOrDefault<CreditCard>(creditCard => creditCard.Name.Equals(name) && creditCard.User.Equals(user));

        return creditCard;
    }
}